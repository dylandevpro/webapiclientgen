﻿namespace Fonlow.OpenApi.ClientTypes
{
	public enum ActionNameStrategy
	{
		/// <summary>
		/// Either OperationId or MethodQueryParameters
		/// </summary>
		Default,

		OperationId,

		/// <summary>
		/// Compose something like GetSomeWhereById1AndId2. Generally used with ContainerNameStrategy.Path
		/// </summary>
		MethodQueryParameters,

		PathMethodQueryParameters,

		/// <summary>
		/// According to Open API specification, it is RECOMMENDED that the naming of operationId follows common programming naming conventions. 
		/// However, some YAML may name operationId after a valid function name. For example, "list-data-sets", "Search by name" or "SearchByName@WkUld". 
		/// Regular expression (regex) may be needed to pick up alphanumeric words from such operationId and create a valid function name.
		/// The default RegexForNormalizedOperationId is /w*.
		/// </summary>
		NormalizedOperationId,
	}

	public enum ContainerNameStrategy
	{
		/// <summary>
		/// All client functions will be constructed in a god class named after ContainerClassName
		/// </summary>
		None,

		/// <summary>
		/// Use tags
		/// </summary>
		Tags,

		/// <summary>
		/// Use path as resource for grouping, as a container class name.
		/// </summary>
		Path,
	}

	public class Settings
	{
		/// <summary>
		/// The generated codes should be contained in a namespace. The default is My.Namespace.
		/// </summary>
		public string ClientNamespace { get; set; } = "My.Namespace";

		/// <summary>
		/// To compose client function name through removing path prefix. Typically / or /api. The default is /.
		/// The lenght of the prefix is used to remove path prefix.
		/// </summary>
		public string PathPrefixToRemove { get; set; } = "/";

		public ActionNameStrategy ActionNameStrategy { get; set; }

		/// <summary>
		/// Default is \w* for picking up alphanumeric words from crikey operationId. Applied when ActionNameStrategy is NorrmalizedOperationId.
		/// </summary>
		public string RegexForNormalizedOperationId { get; set; } = @"\w*";

		public ContainerNameStrategy ContainerNameStrategy { get; set; }

		/// <summary>
		/// Container class name when ContainerNameStrategy is None. The default is Misc.
		/// </summary>
		public string ContainerClassName { get; set; } = "Misc";

		/// <summary>
		/// Suffix of container class name if ContainerNameStrategy is not None. The default is Client
		/// </summary>
		public string SuffixOfContainerName { get; set; } = "Client";

		/// <summary>
		/// Assuming the client API project is the sibling of Web API project. Relative path to the WebApi project should be fine.
		/// </summary>
		public string ClientLibraryProjectFolderName { get; set; }

		/// <summary>
		/// The name of the CS file to be generated under client library project folder. The default is OpenApiClientAuto.cs.
		/// </summary>
		public string ClientLibraryFileName { get; set; } = "OpenApiClientAuto.cs";

		/// <summary>
		/// For .NET client, generate both async and sync functions for each Web API function
		/// </summary>
		public bool GenerateBothAsyncAndSync { get; set; }

		public bool? CamelCase { get; set; }

		public JSPlugin[] Plugins { get; set; }

	}

	/// <summary>
	/// A DTO class, not part of the CodeGen.json 
	/// </summary>
	public class JSOutput
	{
		/// <summary>
		/// Whether to conform to the camel casing convention of javascript and JSON.
		/// If not defined, WebApiClientGen will check if GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ContractResolver is Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver;
		/// If CamelCasePropertyNamesContractResolver is presented, camelCasing will be used. If not, no camelCasing transformation will be used.
		/// </summary>
		public bool? CamelCase { get; set; }

		public string JSPath { get; set; }

		public bool AsModule { get; set; }

		///// <summary>
		///// HTTP content type used in POST of HTTP of NG2. so text/plain could be used to avoid preflight in CORS.
		///// </summary>
		public string ContentType { get; set; }

		public string ClientNamespaceSuffix { get; set; } = ".Client";
	}

	public class JSPlugin
	{
		public string AssemblyName { get; set; }

		public string TargetDir { get; set; }

		public string TSFile { get; set; }

		///// <summary>
		///// HTTP content type used in POST of HTTP of NG2. so text/plain could be used to avoid preflight in CORS.
		///// </summary>
		public string ContentType { get; set; }

		/// <summary>
		/// True to have "export namespace"; false to have "namespace". jQuery wants "namespace".
		/// </summary>
		public bool AsModule { get; set; }

		public string ClientNamespaceSuffix { get; set; } = ".Client";
	}
}
