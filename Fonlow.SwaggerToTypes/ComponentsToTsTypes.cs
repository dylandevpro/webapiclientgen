﻿using Fonlow.Poco2Client;
using Fonlow.Reflection;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Fonlow.OpenApi.ClientTypes
{
	/// <summary>
	/// POCO to TypeScript interfaces generator. Create CodeDOM and output TS codes, with TypeScript CodeDOM provider
	/// </summary>
	public class ComponentsToTsTypes
	{
		public ComponentsToTsTypes(Settings settings, CodeCompileUnit codeCompileUnit)
		{
			this.codeCompileUnit = codeCompileUnit;
			this.settings = settings;
			this.nameComposer = new NameComposer(settings);
		}

		readonly CodeCompileUnit codeCompileUnit;

		readonly Settings settings;

		readonly NameComposer nameComposer;

		/// <summary>
		/// Save TypeScript codes generated into a file.
		/// </summary>
		/// <param name="fileName"></param>
		public void SaveCodeToFile(string fileName)
		{
			if (String.IsNullOrEmpty(fileName))
				throw new ArgumentException("A valid fileName is not defined.", "fileName");

			try
			{
				using (StreamWriter writer = new StreamWriter(fileName))
				{
					WriteCode(writer);
				}
			}
			catch (IOException e)
			{
				Trace.TraceWarning(e.Message);
			}
			catch (UnauthorizedAccessException e)
			{
				Trace.TraceWarning(e.Message);
			}
			catch (System.Security.SecurityException e)
			{
				Trace.TraceWarning(e.Message);
			}
		}

		public void WriteCode(TextWriter writer)
		{
			if (writer == null)
				throw new ArgumentNullException("writer", "No TextWriter instance is defined.");

			using (CodeDomProvider provider = new Fonlow.TypeScriptCodeDom.TypeScriptCodeProvider(true))
			{
				CodeGeneratorOptions options = Fonlow.TypeScriptCodeDom.TsCodeGenerationOptions.Instance;
				options.BracingStyle = "JS";
				options.IndentString = "\t";

				provider.GenerateCodeFromCompileUnit(codeCompileUnit, writer, options);
			}
		}

		CodeNamespace clientNamespace;

		/// <summary>
		/// Create TypeScript CodeDOM for POCO types. 
		/// For an enum type, all members will be processed regardless of EnumMemberAttribute.
		/// </summary>
		/// <param name="types">POCO types.</param>
		/// <param name="methods"></param>
		public void CreateCodeDom(OpenApiComponents components)
		{
			if (components == null)
			{
				throw new ArgumentNullException(nameof(components));
			}

			clientNamespace = new CodeNamespace(settings.ClientNamespace);
			codeCompileUnit.Namespaces.Add(clientNamespace);//namespace added to Dom

			foreach (var item in components.Schemas)
			{
				var typeName = ToTitleCase(item.Key);
				Debug.WriteLine("clientClass: " + typeName);
				var schema = item.Value;
				var type = schema.Type;
				var allOfBaseTypeSchemaList = schema.AllOf; //maybe empty
				var enumTypeList = schema.Enum; //maybe empty
				bool isForClass = enumTypeList.Count == 0;
				var schemaProperties = schema.Properties;
				CodeTypeDeclaration typeDeclaration;
				if (isForClass)
				{
					if (schema.Properties.Count > 0 || (schema.Properties.Count == 0 && allOfBaseTypeSchemaList.Count > 1))
					{
						typeDeclaration = PodGenHelper.CreatePodClientInterface(clientNamespace, typeName);
						if (String.IsNullOrEmpty(type) && allOfBaseTypeSchemaList.Count > 0)
						{
							var allOfRef = allOfBaseTypeSchemaList[0];
							var baseTypeName = allOfRef.Reference.Id; //pointing to parent class
							typeDeclaration.BaseTypes.Add(baseTypeName);

							var allOfProperteisSchema = allOfBaseTypeSchemaList[1];
							AddProperties(typeDeclaration, allOfProperteisSchema);
						}

						CreateTypeOrMemberDocComment(item, typeDeclaration);
						//	typeDeclarationDic.Add(typeName, typeDeclaration);

						AddProperties(typeDeclaration, schema);
					}
					else // type alias
					{
						//var typeFormat = schema.Format; No need to do C# Type Alias, since OpenApi.NET will translate the alias to the real type.
						//var realTypeName = nameComposer.PremitiveSwaggerTypeToClrType(type, typeFormat);
						//CodeNamespaceImport cd = new CodeNamespaceImport($"{typeName} = {realTypeName}");
						//clientNamespace.Imports.Add(cd);
					}
				}
				else
				{
					typeDeclaration = PodGenHelper.CreatePodClientEnum(clientNamespace, typeName);
					CreateTypeOrMemberDocComment(item, typeDeclaration);
					AddEnumMembers(typeDeclaration, enumTypeList);
				}
			}

		}

		void AddEnumMembers(CodeTypeDeclaration typeDeclaration, IList<IOpenApiAny> enumTypeList)
		{
			int k = 0;
			foreach (var enumMember in enumTypeList)
			{
				var stringMember = enumMember as OpenApiString;
				if (stringMember != null)
				{
					var memberName = stringMember.Value;
					var intValue = k;
					var clientField = new CodeMemberField()
					{
						Name = memberName,
						InitExpression = new CodePrimitiveExpression(intValue),
					};

					typeDeclaration.Members.Add(clientField);
					k++;
				}
				else
				{
					var intMember = enumMember as OpenApiInteger;
					var memberName = "_" + intMember.Value.ToString();
					var intValue = k;
					var clientField = new CodeMemberField()
					{
						Name = memberName,
						InitExpression = new CodePrimitiveExpression(intValue),
					};

					typeDeclaration.Members.Add(clientField);
					k++;
				}
			}
		}

		void AddProperties(CodeTypeDeclaration typeDeclaration, OpenApiSchema schema)
		{
			foreach (var p in schema.Properties)
			{
				var propertyName = p.Key;
				var propertySchema = p.Value;
				var premitivePropertyType = propertySchema.Type;
				var isRequired = schema.Required.Contains(propertyName);


				CodeMemberField clientProperty;
				if (String.IsNullOrEmpty(premitivePropertyType)) // for custom type, pointing to a custom time "$ref": "#/components/schemas/PhoneType"
				{
					var refToType = propertySchema.AllOf[0];
					var customPropertyType = refToType.Type;
					var customPropertyFormat = refToType.Format;
					var customType = nameComposer.PrimitiveSwaggerTypeToClrType(customPropertyType, customPropertyFormat);
					clientProperty = CreateProperty(propertyName, customType, isRequired);
				}
				else
				{
					if (propertySchema.Type == "array") // for array
					{
						var arrayItemsSchema = propertySchema.Items;
						if (arrayItemsSchema.Reference != null) //array of custom type
						{
							var arrayTypeName = arrayItemsSchema.Reference.Id;
							var arrayCodeTypeReference = CreateArrayOfCustomTypeReference(arrayTypeName, 1);
							clientProperty = CreateProperty(arrayCodeTypeReference, propertyName, isRequired);
						}
						else
						{
							var arrayType = arrayItemsSchema.Type;
							var clrType = nameComposer.PrimitiveSwaggerTypeToClrType(arrayType, null);
							var arrayCodeTypeReference = CreateArrayTypeReference(clrType, 1);
							clientProperty = CreateProperty(arrayCodeTypeReference, propertyName, isRequired);
						}
					}
					else if (propertySchema.Enum.Count == 0) // for premitive type
					{
						var simpleType = nameComposer.PrimitiveSwaggerTypeToClrType(premitivePropertyType, propertySchema.Format);
						clientProperty = CreateProperty(propertyName, simpleType, isRequired);
					}
					else // for casual enum
					{
						var casualEnumName = typeDeclaration.Name + ToTitleCase(propertyName);
						var casualEnumTypeDeclaration = PodGenHelper.CreatePodClientEnum(clientNamespace, casualEnumName);
						AddEnumMembers(casualEnumTypeDeclaration, propertySchema.Enum);
						clientProperty = CreateProperty(propertyName, casualEnumName, isRequired);
					}
				}

				if (isRequired)
				{
					clientProperty.CustomAttributes.Add(new CodeAttributeDeclaration("System.ComponentModel.DataAnnotations.RequiredAttribute"));
				}

				CreateTypeOrMemberDocComment(p, clientProperty);

				typeDeclaration.Members.Add(clientProperty);
			}
		}

		void CreateTypeOrMemberDocComment(KeyValuePair<string, OpenApiSchema> item, CodeTypeMember declaration)
		{
			if (String.IsNullOrEmpty(item.Value.Description))
				return;

			declaration.Comments.Add(new CodeCommentStatement(item.Value.Description, true));
		}

		CodeMemberField CreateProperty(string propertyName, Type type, bool isRequired)
		{
			var memberName = propertyName + (isRequired ? String.Empty : "?");
			CodeMemberField result = new CodeMemberField() { Type = TranslateToClientTypeReference(type), Name = memberName };
			result.Attributes = MemberAttributes.Public | MemberAttributes.Final;
			return result;
		}

		CodeMemberField CreateProperty(string propertyName, string typeName, bool isRequired)
		{
			var memberName = propertyName + (isRequired ? String.Empty : "?");
			CodeMemberField result = new CodeMemberField() { Type = TranslateToClientTypeReference(typeName), Name = memberName };
			result.Attributes = MemberAttributes.Public | MemberAttributes.Final;
			return result;
		}

		CodeMemberField CreateProperty(CodeTypeReference codeTypeReference, string propertyName, bool isRequired)
		{
			var memberName = propertyName + (isRequired ? String.Empty : "?");
			CodeMemberField result = new CodeMemberField(codeTypeReference, memberName);
			result.Attributes = MemberAttributes.Public | MemberAttributes.Final;
			return result;
		}

		static string ToTitleCase(string s)
		{
			return String.IsNullOrEmpty(s) ? s : (char.ToUpper(s[0]) + (s.Length > 1 ? s.Substring(1) : String.Empty));
		}

		/// <summary>
		/// Translate a service type into a CodeTypeReference for client.
		/// </summary>
		/// <param name="type">CLR type of the service</param>
		/// <returns></returns>
		public CodeTypeReference TranslateToClientTypeReference(Type type)
		{
			if (type == null)
				return new CodeTypeReference("void");

			if (TypeHelper.IsSimpleType(type))
			{
				var typeText = Fonlow.TypeScriptCodeDom.TypeMapper.MapToTsBasicType(type);
				return new CodeTypeReference(typeText);
			}
			else if (type.IsArray)
			{
				Debug.Assert(type.Name.EndsWith("]"));
				var elementType = type.GetElementType();
				var arrayRank = type.GetArrayRank();
				return CreateArrayTypeReference(elementType, arrayRank);
			}

			var tsBasicTypeText = Fonlow.TypeScriptCodeDom.TypeMapper.MapToTsBasicType(type);
			if (tsBasicTypeText != null)
				return new CodeTypeReference(tsBasicTypeText);

			var actionResultTypeReference = TranslateActionResultToClientTypeReference(type);
			if (actionResultTypeReference != null)
			{
				return actionResultTypeReference;
			}

			return new CodeTypeReference("any");
		}

		public CodeTypeReference TranslateToClientTypeReference(string typeName)
		{
			if (typeName == null)
				return null;// new CodeTypeReference("void");

			return new CodeTypeReference(typeName);

		}

		virtual protected CodeTypeReference TranslateActionResultToClientTypeReference(Type type)
		{
			if (type.FullName.Contains("System.Net.Http.HttpResponseMessage") || type.FullName.Contains("System.Web.Http.IHttpActionResult") || type.FullName.Contains("Microsoft.AspNetCore.Mvc.IActionResult") || type.FullName.Contains("Microsoft.AspNetCore.Mvc.ActionResult"))
			{
				return new CodeTypeReference("response");
			}

			return null;
		}

		CodeTypeReference CreateArrayTypeReference(Type elementType, int arrayRank)
		{
			var otherArrayType = new CodeTypeReference(new CodeTypeReference(), arrayRank)//CodeDom does not care. The baseType is always overwritten by ArrayElementType.
			{
				ArrayElementType = TranslateToClientTypeReference(elementType),
			};
			return otherArrayType;
		}

		CodeTypeReference CreateArrayOfCustomTypeReference(string typeName, int arrayRank)
		{
			var elementTypeReference = new CodeTypeReference(typeName);
			var typeReference = new CodeTypeReference(new CodeTypeReference(), arrayRank)
			{
				ArrayElementType = elementTypeReference,
			};
			return typeReference;
		}



	}

}
