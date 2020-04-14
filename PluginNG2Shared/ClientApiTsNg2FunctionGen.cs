﻿using System;
using System.CodeDom;
using System.Linq;
using System.Collections.ObjectModel;
using System.Collections.Generic;

using System.Diagnostics;
using System.Text;
using Fonlow.TypeScriptCodeDom;
using Fonlow.Poco2Ts;
using Fonlow.Reflection;
using Fonlow.Web.Meta;

namespace Fonlow.CodeDom.Web.Ts
{
	/// <summary>
	/// Generate a client function upon ApiDescription for Angular
	/// </summary>
	public class ClientApiTsNG2FunctionGen : ClientApiTsFunctionGenBase
	{
		const string NG2HttpResponse = "Response";
		const string NG2HttpBlobResponse = "HttpResponse<Blob>";
		const string NG2HttpStringResponse = "HttpResponse<string>";

		string returnTypeText = null;
		string contentType;

		public ClientApiTsNG2FunctionGen(string contentType) : base()
		{
			this.contentType = contentType;
		}

		protected override CodeMemberMethod CreateMethodName()
		{
			Debug.Assert(ReturnType==null || ReturnType.Name != "DayOfWeek[]");
			var returnTypeReference = Poco2TsGen.TranslateToClientTypeReference(ReturnType);
			returnTypeText = TypeMapper.MapCodeTypeReferenceToTsText(returnTypeReference);
			if (returnTypeText == "any" || returnTypeText == "void")
			{
				returnTypeText = NG2HttpResponse;
			}
			else if (returnTypeText == "response")
			{
				returnTypeText = NG2HttpStringResponse;
			}
			else if (returnTypeText == "blobresponse")
			{
				returnTypeText = NG2HttpBlobResponse;
			}

			var callbackTypeText = $"Observable<{returnTypeText}>";
			Debug.WriteLine("callback: " + callbackTypeText);
			var returnTypeReferenceWithObservable = new CodeSnipetTypeReference(callbackTypeText);

			return new CodeMemberMethod()
			{
				Attributes = MemberAttributes.Public | MemberAttributes.Final,
				Name = MethodName,
				ReturnType = returnTypeReferenceWithObservable,
			};
		}


		protected override void RenderImplementation()
		{
			var httpMethod = Description.HttpMethod.ToLower(); //Method is always uppercase.
															   //deal with parameters
			var parameters = Description.ParameterDescriptions.Select(d =>
				 new CodeParameterDeclarationExpression(Poco2TsGen.TranslateToClientTypeReference(d.ParameterDescriptor.ParameterType), d.Name)
			).ToList();

			//parameters.Add(new CodeParameterDeclarationExpression(callbackTypeReference, "callback"));

			Method.Parameters.AddRange(parameters.ToArray());

			var jsUriQuery = UriQueryHelper.CreateUriQueryForTs(Description.RelativePath, Description.ParameterDescriptions);
			var hasArrayJoin = jsUriQuery !=null && jsUriQuery.Contains(".join(");
			var uriText = jsUriQuery == null ? $"this.baseUri + '{Description.RelativePath}'" :
				RemoveTrialEmptyString(hasArrayJoin? $"this.baseUri + '{jsUriQuery}": $"this.baseUri + '{jsUriQuery}'");

			// var mapFunction = returnTypeText == NG2HttpResponse ? String.Empty : ".map(response=> response.json())";

			if (ReturnType!=null && TypeHelper.IsStringType(ReturnType) && this.StringAsString)//stringAsString is for .NET Core Web API
			{
				if (httpMethod == "get" || httpMethod == "delete")
				{
					Method.Statements.Add(new CodeSnippetStatement($"return this.http.{httpMethod}({uriText}, {{ responseType: 'text' }});"));
					return;
				}

				if (httpMethod == "post" || httpMethod == "put")
				{
					var fromBodyParameterDescriptions = Description.ParameterDescriptions.Where(d => d.ParameterDescriptor.ParameterBinder == ParameterBinder.FromBody
						|| (TypeHelper.IsComplexType(d.ParameterDescriptor.ParameterType) && (!(d.ParameterDescriptor.ParameterBinder == ParameterBinder.FromUri)
						|| (d.ParameterDescriptor.ParameterBinder == ParameterBinder.None)))).ToArray();
					if (fromBodyParameterDescriptions.Length > 1)
					{
						throw new InvalidOperationException(String.Format("This API function {0} has more than 1 FromBody bindings in parameters", Description.ActionDescriptor.ActionName));
					}
					var singleFromBodyParameterDescription = fromBodyParameterDescriptions.FirstOrDefault();

					var dataToPost = singleFromBodyParameterDescription == null ? "null" : singleFromBodyParameterDescription.ParameterDescriptor.ParameterName;

					if (String.IsNullOrEmpty(contentType))
					{
						contentType = "application/json;charset=UTF-8";
					}

					if (dataToPost == "null")
					{
						Method.Statements.Add(new CodeSnippetStatement($"return this.http.{httpMethod}({uriText}, null, {{headers: {{ 'Content-Type': '{contentType}' }}, responseType: 'text' }});"));
					}
					else
					{
						Method.Statements.Add(new CodeSnippetStatement($"return this.http.{httpMethod}({uriText}, JSON.stringify({dataToPost}), {{ headers: {{ 'Content-Type': '{contentType}' }}, responseType: 'text' }});"));
					}

					return;
				}

			}
			else if (returnTypeText == NG2HttpBlobResponse)//translated from blobresponse to this
			{
				const string optionForStream = "{ observe: 'response', responseType: 'blob' }";

				if (httpMethod == "get" || httpMethod == "delete")
				{
					Method.Statements.Add(new CodeSnippetStatement($"return this.http.{httpMethod}({uriText}, {optionForStream});"));
					return;
				}

				if (httpMethod == "post" || httpMethod == "put")
				{
					var fromBodyParameterDescriptions = Description.ParameterDescriptions.Where(d => d.ParameterDescriptor.ParameterBinder == ParameterBinder.FromBody
						|| (TypeHelper.IsComplexType(d.ParameterDescriptor.ParameterType) && (!(d.ParameterDescriptor.ParameterBinder == ParameterBinder.FromUri)
						|| (d.ParameterDescriptor.ParameterBinder == ParameterBinder.None)))).ToArray();
					if (fromBodyParameterDescriptions.Length > 1)
					{
						throw new InvalidOperationException(String.Format("This API function {0} has more than 1 FromBody bindings in parameters", Description.ActionDescriptor.ActionName));
					}
					var singleFromBodyParameterDescription = fromBodyParameterDescriptions.FirstOrDefault();

					var dataToPost = singleFromBodyParameterDescription == null ? "null" : singleFromBodyParameterDescription.ParameterDescriptor.ParameterName;

					if (dataToPost == "null")
					{
						Method.Statements.Add(new CodeSnippetStatement($"return this.http.{httpMethod}({uriText}, null, {optionForStream});"));
					}
					else
					{
						Method.Statements.Add(new CodeSnippetStatement($"return this.http.{httpMethod}({uriText}, JSON.stringify({dataToPost}), {optionForStream});"));
					}

					return;
				}

			}
			else if (returnTypeText == NG2HttpStringResponse)//translated from response to this
			{
				const string optionForActionResult = "{ observe: 'response', responseType: 'text' }";

				if (httpMethod == "get" || httpMethod == "delete")
				{
					Method.Statements.Add(new CodeSnippetStatement($"return this.http.{httpMethod}({uriText}, {optionForActionResult});"));
					return;
				}

				if (httpMethod == "post" || httpMethod == "put")
				{
					var fromBodyParameterDescriptions = Description.ParameterDescriptions.Where(d => d.ParameterDescriptor.ParameterBinder == ParameterBinder.FromBody
						|| (TypeHelper.IsComplexType(d.ParameterDescriptor.ParameterType) && (!(d.ParameterDescriptor.ParameterBinder == ParameterBinder.FromUri)
						|| (d.ParameterDescriptor.ParameterBinder == ParameterBinder.None)))).ToArray();
					if (fromBodyParameterDescriptions.Length > 1)
					{
						throw new InvalidOperationException(String.Format("This API function {0} has more than 1 FromBody bindings in parameters", Description.ActionDescriptor.ActionName));
					}
					var singleFromBodyParameterDescription = fromBodyParameterDescriptions.FirstOrDefault();

					var dataToPost = singleFromBodyParameterDescription == null ? "null" : singleFromBodyParameterDescription.ParameterDescriptor.ParameterName;

					if (dataToPost == "null")
					{
						Method.Statements.Add(new CodeSnippetStatement($"return this.http.{httpMethod}({uriText}, null, {optionForActionResult});"));
					}
					else
					{
						Method.Statements.Add(new CodeSnippetStatement($"return this.http.{httpMethod}({uriText}, JSON.stringify({dataToPost}), {{ headers: {{ 'Content-Type': '{contentType}' }}, observe: 'response', responseType: 'text' }});"));
					}

					return;
				}

			}
			else
			{
				if (httpMethod == "get" || httpMethod == "delete")
				{
					if (hasArrayJoin)
					{
						Method.Statements.Add(new CodeSnippetStatement($"return this.http.{httpMethod}<{returnTypeText}>({uriText};"));
					}
					else
					{
						Method.Statements.Add(new CodeSnippetStatement($"return this.http.{httpMethod}<{returnTypeText}>({uriText});"));
					}
					return;
				}

				if (httpMethod == "post" || httpMethod == "put")
				{
					var fromBodyParameterDescriptions = Description.ParameterDescriptions.Where(d => d.ParameterDescriptor.ParameterBinder == ParameterBinder.FromBody
						|| (TypeHelper.IsComplexType(d.ParameterDescriptor.ParameterType) && (!(d.ParameterDescriptor.ParameterBinder == ParameterBinder.FromUri)
						|| (d.ParameterDescriptor.ParameterBinder == ParameterBinder.None)))).ToArray();
					if (fromBodyParameterDescriptions.Length > 1)
					{
						throw new InvalidOperationException(String.Format("This API function {0} has more than 1 FromBody bindings in parameters", Description.ActionDescriptor.ActionName));
					}
					var singleFromBodyParameterDescription = fromBodyParameterDescriptions.FirstOrDefault();

					var dataToPost = singleFromBodyParameterDescription == null ? "null" : singleFromBodyParameterDescription.ParameterDescriptor.ParameterName;

					if (String.IsNullOrEmpty(contentType))
					{
						contentType = "application/json;charset=UTF-8";
					}

					if (dataToPost == "null")
					{
						Method.Statements.Add(new CodeSnippetStatement($"return this.http.{httpMethod}<{returnTypeText}>({uriText}, null, {{ headers: {{ 'Content-Type': '{contentType}' }} }});"));
					}
					else
					{
						Method.Statements.Add(new CodeSnippetStatement($"return this.http.{httpMethod}<{returnTypeText}>({uriText}, JSON.stringify({dataToPost}), {{ headers: {{ 'Content-Type': '{contentType}' }} }});"));
					}

					return;
				}
			}

			Debug.Assert(false, "How come?");
		}

	}

}
