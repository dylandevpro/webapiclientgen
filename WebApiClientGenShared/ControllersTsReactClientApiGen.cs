﻿using System.CodeDom;

namespace Fonlow.CodeDom.Web.Ts
{
	/// <summary>
	/// Generate React TypeScript codes of the client API of the controllers
	/// </summary>
	public class ControllersTsReactClientApiGen : ControllersTsClientApiGenBase
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="excludedControllerNames">Excluse some Api Controllers from being exposed to the client API. Each item should be fully qualified class name but without the assembly name.</param>
		/// <remarks>The client data types should better be generated through SvcUtil.exe with the DC option. The client namespace will then be the original namespace plus suffix ".client". </remarks>
		public ControllersTsReactClientApiGen(JSOutput jsOutput) : base(jsOutput, new ClientApiTsReactFunctionGen(jsOutput.ContentType))
		{
		}

		protected override Fonlow.Poco2Client.IPoco2Client CreatePoco2TsGen()
		{
			return new Fonlow.Poco2Ts.PocoToTsNgGen(TargetUnit);
		}

		protected override void AddBasicReferences()
		{
			TargetUnit.ReferencedAssemblies.Add("import React from 'react';");
			TargetUnit.ReferencedAssemblies.Add("import ReactDOM from 'react-dom';");
			TargetUnit.ReferencedAssemblies.Add("import Axios from 'axios';");
			TargetUnit.ReferencedAssemblies.Add("import { AxiosResponse } from 'axios';");
		}

		protected override void AddConstructor(CodeTypeDeclaration targetClass)
		{
			CodeConstructor constructor = new CodeConstructor();
			constructor.Attributes =
				MemberAttributes.Public | MemberAttributes.Final;

			// Add parameters.
			constructor.Parameters.Add(new CodeParameterDeclarationExpression(
				"string = location.protocol + '//' + location.hostname + (location.port ? ':' + location.port : '') + '/'", "private baseUri"));
			targetClass.Members.Add(constructor);
		}
	}


}
