namespace DemoWebApi.DemoData.Client
{
	
	
	[System.Runtime.Serialization.DataContract(Namespace="http://fonlowdemo.com/2020/09")]
	[System.SerializableAttribute()]
	public class Address : object
	{
		
		[System.Runtime.Serialization.DataMember()]
		public string City { get; set; }
		
		[System.ComponentModel.DefaultValueAttribute("Australia")]
		[System.Runtime.Serialization.DataMember()]
		public string Country { get; set; } = "Australia";
		
		[System.Runtime.Serialization.DataMember()]
		public System.Guid Id { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public string PostalCode { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public string State { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public string Street1 { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public string Street2 { get; set; }
		
		[System.ComponentModel.DefaultValueAttribute(AddressType.Residential)]
		[System.Runtime.Serialization.DataMember()]
		public DemoWebApi.DemoData.Client.AddressType Type { get; set; } = AddressType.Residential;
		
		/// <summary>
		/// It is a field
		/// </summary>
		[System.Runtime.Serialization.DataMember()]
		public DemoWebApi.DemoData.Another.Client.MyPoint Location { get; set; }
	}
	
	[System.Runtime.Serialization.DataContract(Namespace="http://fonlowdemo.com/2020/09")]
	[System.SerializableAttribute()]
	public enum AddressType
	{
		
		[System.Runtime.Serialization.EnumMember()]
		Postal,
		
		[System.Runtime.Serialization.EnumMember()]
		Residential,
	}
	
	[System.Runtime.Serialization.DataContract(Namespace="http://fonlowdemo.com/2020/09")]
	[System.SerializableAttribute()]
	public class Company : DemoWebApi.DemoData.Client.Entity
	{
		
		/// <summary>
		/// BusinessNumber to be serialized as BusinessNum
		/// </summary>
		[System.Runtime.Serialization.DataMember(Name="BusinessNum")]
		public string BusinessNumber { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public string BusinessNumberType { get; set; }
		
		/// <summary>
		/// Data type: Date
		/// </summary>
		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
		[System.Runtime.Serialization.DataMember()]
		public System.DateTimeOffset FoundDate { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public System.DateOnly RegisterDate { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public string[][] TextMatrix { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public int[,] Int2D { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public int[][] Int2DJagged { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public System.Collections.Generic.IEnumerable<string> Lines { get; set; }
	}
	
	[System.Runtime.Serialization.DataContract(Namespace="http://fonlowdemo.com/2020/09")]
	[System.SerializableAttribute()]
	public enum Days
	{
		
		[System.Runtime.Serialization.EnumMember()]
		Sat = 1,
		
		[System.Runtime.Serialization.EnumMember()]
		Sun = 2,
		
		[System.Runtime.Serialization.EnumMember()]
		Mon = 3,
		
		[System.Runtime.Serialization.EnumMember()]
		Tue = 4,
		
		[System.Runtime.Serialization.EnumMember()]
		Wed = 5,
		
		/// <summary>
		/// Thursday
		/// </summary>
		[System.Runtime.Serialization.EnumMember()]
		Thu = 6,
		
		[System.Runtime.Serialization.EnumMember()]
		Fri = 7,
	}
	
	/// <summary>
	/// Base class of company and person
	/// </summary>
	[System.Runtime.Serialization.DataContract(Namespace="http://fonlowdemo.com/2020/09")]
	[System.SerializableAttribute()]
	public class Entity : object
	{
		
		/// <summary>
		/// Multiple addresses
		/// </summary>
		[System.Runtime.Serialization.DataMember()]
		public System.Collections.Generic.IList<DemoWebApi.DemoData.Client.Address> Addresses { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public System.Nullable<System.Guid> Id { get; set; }
		
		/// <summary>
		/// Name of the entity.
		/// Required
		/// </summary>
		[System.ComponentModel.DataAnnotations.RequiredAttribute()]
		[System.Runtime.Serialization.DataMember(IsRequired =true)]
		public string Name { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public System.Collections.ObjectModel.ObservableCollection<DemoWebApi.DemoData.Client.PhoneNumber> PhoneNumbers { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public System.Uri Web { get; set; }
	}
	
	/// <summary>
	/// To test different serializations against Guid
	/// </summary>
	[System.Runtime.Serialization.DataContract(Namespace="http://fonlowdemo.com/2020/09")]
	[System.SerializableAttribute()]
	public class IdMap : object
	{
		
		[System.Runtime.Serialization.DataMember()]
		public System.Guid Id { get; set; }
		
		[System.Runtime.Serialization.DataMember(EmitDefaultValue=false)]
		public System.Guid IdNotEmitDefaultValue { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public System.Nullable<System.Guid> NullableId { get; set; }
		
		[System.ComponentModel.DataAnnotations.RequiredAttribute()]
		[System.Runtime.Serialization.DataMember(IsRequired =true)]
		public string RequiredName { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public string Text { get; set; }
	}
	
	[Newtonsoft.Json.JsonConverterAttribute(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
	[System.Runtime.Serialization.DataContract(Namespace="http://fonlowdemo.com/2020/09")]
	[System.SerializableAttribute()]
	public enum MedicalContraindiationResponseTypeReason
	{
		
		[System.Runtime.Serialization.EnumMember(Value="Mm")]
		M,
		
		[System.Runtime.Serialization.EnumMember(Value="Ss")]
		S,
		
		[System.Runtime.Serialization.EnumMember(Value="Pp")]
		P,
		
		[System.Runtime.Serialization.EnumMember(Value="I")]
		I,
		
		[System.Runtime.Serialization.EnumMember(Value="A")]
		A,
	}
	
	[System.Runtime.Serialization.DataContract(Namespace="http://fonlowdemo.com/2020/09")]
	[System.SerializableAttribute()]
	public enum MedicalContraindiationResponseTypeTypeCode
	{
		
		[System.Runtime.Serialization.EnumMember(Value="P")]
		P,
		
		[System.Runtime.Serialization.EnumMember(Value="Tt")]
		T,
	}
	
	[System.Runtime.Serialization.DataContract(Namespace="http://fonlowdemo.com/2020/09")]
	[System.SerializableAttribute()]
	public class MimsPackage : object
	{
		
		/// <summary>
		/// Range: inclusive between 10 and 100
		/// </summary>
		[System.ComponentModel.DefaultValueAttribute(20)]
		[System.ComponentModel.DataAnnotations.Range(typeof(System.Int32), "10", "100", ErrorMessage="KK has to be between 10 and 100.")]
		[System.Runtime.Serialization.DataMember()]
		public int KK { get; set; } = 20;
		
		/// <summary>
		/// Having an initialized value in the property is not like defining a DefaultValueAttribute. Such intialization happens at run time,
		/// and there's no reliable way for a codegen to know if the value is declared by the programmer, or is actually the natural default value like 0.
		/// </summary>
		[System.Runtime.Serialization.DataMember()]
		public int KK2 { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public System.Nullable<DemoWebApi.DemoData.Client.MyEnumType> OptionalEnum { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public System.Nullable<int> OptionalInt { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public DemoWebApi.DemoData.Client.MimsResult<decimal> Result { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public string Tag { get; set; }
	}
	
	[System.Runtime.Serialization.DataContract(Namespace="http://fonlowdemo.com/2020/09")]
	[System.SerializableAttribute()]
	public class MimsResult<T> : object
	{
		
		[System.Runtime.Serialization.DataMember()]
		public System.DateTime GeneratedAt { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public string Message { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public T Result { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public bool Success { get; set; }
	}
	
	[System.Runtime.Serialization.DataContract(Namespace="http://fonlowdemo.com/2020/09")]
	[System.SerializableAttribute()]
	public enum MyEnumType
	{
		
		[System.Runtime.Serialization.EnumMember()]
		First = 1,
		
		[System.Runtime.Serialization.EnumMember()]
		Two = 2,
	}
	
	[System.Runtime.Serialization.DataContract(Namespace="http://fonlowdemo.com/2020/09")]
	[System.SerializableAttribute()]
	public class MyGeneric<T, K, U> : object
	{
		
		[System.Runtime.Serialization.DataMember()]
		public K MyK { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public T MyT { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public U MyU { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public string Status { get; set; }
	}
	
	[System.Runtime.Serialization.DataContract(Namespace="http://fonlowdemo.com/2020/09")]
	[System.SerializableAttribute()]
	public class MyPeopleDic : object
	{
		
		[System.Runtime.Serialization.DataMember()]
		public System.Collections.Generic.IDictionary<string, string> AnotherDic { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public System.Collections.Generic.IDictionary<string, DemoWebApi.DemoData.Client.Person> Dic { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public System.Collections.Generic.IDictionary<int, string> IntDic { get; set; }
	}
	
	[System.Runtime.Serialization.DataContract(Namespace="http://fonlowdemo.com/2020/09")]
	[System.SerializableAttribute()]
	public class Person : DemoWebApi.DemoData.Client.Entity
	{
		
		/// <summary>
		/// Data type: Date
		/// </summary>
		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
		[System.Runtime.Serialization.DataMember()]
		public System.Nullable<System.DateTimeOffset> Baptised { get; set; }
		
		/// <summary>
		/// Date of Birth.
		/// This is optional.
		/// </summary>
		[System.Runtime.Serialization.DataMember()]
		public System.Nullable<System.DateOnly> DOB { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public string GivenName { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public string Surname { get; set; }
	}
	
	[System.Runtime.Serialization.DataContract(Namespace="http://fonlowdemo.com/2020/09")]
	[System.SerializableAttribute()]
	public class PhoneNumber : object
	{
		
		[System.Runtime.Serialization.DataMember()]
		public string FullNumber { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public DemoWebApi.DemoData.Client.PhoneType PhoneType { get; set; }
	}
	
	/// <summary>
	/// Phone type
	/// Tel, Mobile, Skyp and Fax
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContract(Namespace="http://fonlowdemo.com/2020/09")]
	[System.SerializableAttribute()]
	public enum PhoneType
	{
		
		/// <summary>
		/// Land line
		/// </summary>
		[System.Runtime.Serialization.EnumMember()]
		Tel,
		
		/// <summary>
		/// Mobile phone
		/// </summary>
		[System.Runtime.Serialization.EnumMember()]
		Mobile,
		
		[System.Runtime.Serialization.EnumMember()]
		Skype,
		
		[System.Runtime.Serialization.EnumMember()]
		Fax,
	}
}
namespace DemoWebApi.DemoData.Another.Client
{
	
	
	/// <summary>
	/// 2D position
	/// with X and Y
	/// for Demo
	/// </summary>
	[System.Runtime.Serialization.DataContract(Namespace="http://fonlowdemo.com/2020/09")]
	[System.SerializableAttribute()]
	public struct MyPoint
	{
		
		/// <summary>
		/// X
		/// </summary>
		public double X;
		
		/// <summary>
		/// Y
		/// </summary>
		public double Y;
	}
}
namespace DemoWebApi.Models.Client
{
	
	
	[System.Runtime.Serialization.DataContract(Namespace="http://fonlowdemo.com/2020/09")]
	[System.SerializableAttribute()]
	public class AddExternalLoginBindingModel : object
	{
		
		/// <summary>
		/// Required
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required()]
		public string ExternalAccessToken { get; set; }
	}
	
	[System.Runtime.Serialization.DataContract(Namespace="http://fonlowdemo.com/2020/09")]
	[System.SerializableAttribute()]
	public class ChangePasswordBindingModel : object
	{
		
		/// <summary>
		/// Data type: Password
		/// </summary>
		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
		public string ConfirmPassword { get; set; }
		
		/// <summary>
		/// Required
		/// String length: inclusive between 6 and 100
		/// Data type: Password
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required()]
		[System.ComponentModel.DataAnnotations.StringLength(100, MinimumLength=6, ErrorMessage="The {0} must be at least {2} characters long.")]
		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
		public string NewPassword { get; set; }
		
		/// <summary>
		/// Required
		/// Data type: Password
		/// </summary>
		[System.ComponentModel.DataAnnotations.RequiredAttribute()]
		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
		public string OldPassword { get; set; }
	}
	
	[System.Runtime.Serialization.DataContract(Namespace="http://fonlowdemo.com/2020/09")]
	[System.SerializableAttribute()]
	public class RegisterBindingModel : object
	{
		
		/// <summary>
		/// Data type: Password
		/// </summary>
		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
		public string ConfirmPassword { get; set; }
		
		/// <summary>
		/// Required
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required()]
		public string Email { get; set; }
		
		/// <summary>
		/// Required
		/// String length: inclusive between 6 and 100
		/// Data type: Password
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required()]
		[System.ComponentModel.DataAnnotations.StringLength(100, MinimumLength=6, ErrorMessage="The {0} must be at least {2} characters long.")]
		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
		public string Password { get; set; }
	}
	
	[System.Runtime.Serialization.DataContract(Namespace="http://fonlowdemo.com/2020/09")]
	[System.SerializableAttribute()]
	public class RegisterExternalBindingModel : object
	{
		
		/// <summary>
		/// Required
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required()]
		public string Email { get; set; }
	}
	
	[System.Runtime.Serialization.DataContract(Namespace="http://fonlowdemo.com/2020/09")]
	[System.SerializableAttribute()]
	public class RemoveLoginBindingModel : object
	{
		
		/// <summary>
		/// Required
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required()]
		public string LoginProvider { get; set; }
		
		/// <summary>
		/// Required
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required()]
		public string ProviderKey { get; set; }
	}
	
	[System.Runtime.Serialization.DataContract(Namespace="http://fonlowdemo.com/2020/09")]
	[System.SerializableAttribute()]
	public class SetPasswordBindingModel : object
	{
		
		/// <summary>
		/// Data type: Password
		/// </summary>
		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
		public string ConfirmPassword { get; set; }
		
		/// <summary>
		/// Required
		/// String length: inclusive between 6 and 100
		/// Data type: Password
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required()]
		[System.ComponentModel.DataAnnotations.StringLength(100, MinimumLength=6, ErrorMessage="The {0} must be at least {2} characters long.")]
		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
		public string NewPassword { get; set; }
	}
	
	/// <summary>
	/// Auth token
	/// </summary>
	[System.Runtime.Serialization.DataContract(Namespace="http://fonlowdemo.com/2020/09")]
	[System.SerializableAttribute()]
	public class TokenResponseModel : object
	{
		
		[System.Runtime.Serialization.DataMember(Name="access_token")]
		public string AccessToken { get; set; }
		
		[System.Runtime.Serialization.DataMember(Name="expires")]
		public string Expires { get; set; }
		
		[System.Runtime.Serialization.DataMember(Name="expires_in")]
		public int ExpiresIn { get; set; }
		
		[System.Runtime.Serialization.DataMember(Name="issued")]
		public string Issued { get; set; }
		
		[System.Runtime.Serialization.DataMember(Name="token_type")]
		public string TokenType { get; set; }
		
		[System.Runtime.Serialization.DataMember(Name="username")]
		public string Username { get; set; }
	}
}
namespace DemoWebApi.Controllers.Client
{
	
	
	/// <summary>
	/// This class is used to carry the result of various file uploads.
	/// </summary>
	[System.Runtime.Serialization.DataContract(Namespace="http://fonlowdemo.com/2020/09")]
	[System.SerializableAttribute()]
	public class FileResult : object
	{
		
		/// <summary>
		/// Gets or sets the local path of the file saved on the server.
		/// </summary>
		[System.Runtime.Serialization.DataMember()]
		public System.Collections.Generic.IEnumerable<string> FileNames { get; set; }
		
		/// <summary>
		/// Gets or sets the submitter as indicated in the HTML form used to upload the data.
		/// </summary>
		[System.Runtime.Serialization.DataMember()]
		public string Submitter { get; set; }
	}
	
	/// <summary>
	/// Complex hero type
	/// </summary>
	[System.Runtime.Serialization.DataContract(Namespace="http://fonlowdemo.com/2020/09")]
	[System.SerializableAttribute()]
	public class Hero : object
	{
		
		[System.Runtime.Serialization.DataMember()]
		public long Id { get; set; }
		
		[System.Runtime.Serialization.DataMember()]
		public string Name { get; set; }
	}
}
#nullable enable
namespace DemoCoreWeb.Controllers.Client
{
	using System;
	using System.Linq;
	using System.Collections.Generic;
	using System.Threading.Tasks;
	using System.Net.Http;
	using Newtonsoft.Json;
	using Fonlow.Net.Http;
	
	
	public partial class SpecialTypes
	{
		
		private System.Net.Http.HttpClient client;
		
		private JsonSerializerSettings? jsonSerializerSettings;
		
		public SpecialTypes(System.Net.Http.HttpClient client, JsonSerializerSettings? jsonSerializerSettings=null)
		{
			if (client == null)
				throw new ArgumentNullException(nameof(client), "Null HttpClient.");

			if (client.BaseAddress == null)
				throw new ArgumentNullException(nameof(client), "HttpClient has no BaseAddress");

			this.client = client;
			this.jsonSerializerSettings = jsonSerializerSettings;
		}
		
		/// <summary>
		/// Anonymous Dynamic of C#
		/// GET api/SpecialTypes/AnonymousDynamic
		/// </summary>
		/// <returns>dyanmic things</returns>
		public async Task<Newtonsoft.Json.Linq.JObject> GetAnonymousDynamicAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SpecialTypes/AnonymousDynamic";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<Newtonsoft.Json.Linq.JObject>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Anonymous Dynamic of C#
		/// GET api/SpecialTypes/AnonymousDynamic
		/// </summary>
		/// <returns>dyanmic things</returns>
		public Newtonsoft.Json.Linq.JObject GetAnonymousDynamic(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SpecialTypes/AnonymousDynamic";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<Newtonsoft.Json.Linq.JObject>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Async function returing dynamic
		/// GET api/SpecialTypes/AnonymousDynamic2
		/// </summary>
		public async Task<Newtonsoft.Json.Linq.JObject> GetAnonymousDynamic2Async(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SpecialTypes/AnonymousDynamic2";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<Newtonsoft.Json.Linq.JObject>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Async function returing dynamic
		/// GET api/SpecialTypes/AnonymousDynamic2
		/// </summary>
		public Newtonsoft.Json.Linq.JObject GetAnonymousDynamic2(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SpecialTypes/AnonymousDynamic2";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<Newtonsoft.Json.Linq.JObject>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SpecialTypes/AnonymousObject
		/// </summary>
		public async Task<Newtonsoft.Json.Linq.JObject> GetAnonymousObjectAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SpecialTypes/AnonymousObject";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<Newtonsoft.Json.Linq.JObject>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SpecialTypes/AnonymousObject
		/// </summary>
		public Newtonsoft.Json.Linq.JObject GetAnonymousObject(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SpecialTypes/AnonymousObject";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<Newtonsoft.Json.Linq.JObject>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Async function returning object
		/// GET api/SpecialTypes/AnonymousObject2
		/// </summary>
		public async Task<Newtonsoft.Json.Linq.JObject> GetAnonymousObject2Async(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SpecialTypes/AnonymousObject2";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<Newtonsoft.Json.Linq.JObject>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Async function returning object
		/// GET api/SpecialTypes/AnonymousObject2
		/// </summary>
		public Newtonsoft.Json.Linq.JObject GetAnonymousObject2(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SpecialTypes/AnonymousObject2";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<Newtonsoft.Json.Linq.JObject>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/SpecialTypes/AnonymousObject
		/// </summary>
		public async Task<Newtonsoft.Json.Linq.JObject> PostAnonymousObjectAsync(Newtonsoft.Json.Linq.JObject obj, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SpecialTypes/AnonymousObject";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, obj);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<Newtonsoft.Json.Linq.JObject>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/SpecialTypes/AnonymousObject
		/// </summary>
		public Newtonsoft.Json.Linq.JObject PostAnonymousObject(Newtonsoft.Json.Linq.JObject obj, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SpecialTypes/AnonymousObject";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, obj);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<Newtonsoft.Json.Linq.JObject>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Async returning object, Post dynamic
		/// POST api/SpecialTypes/AnonymousObject2
		/// </summary>
		public async Task<Newtonsoft.Json.Linq.JObject> PostAnonymousObject2Async(Newtonsoft.Json.Linq.JObject obj, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SpecialTypes/AnonymousObject2";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, obj);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<Newtonsoft.Json.Linq.JObject>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Async returning object, Post dynamic
		/// POST api/SpecialTypes/AnonymousObject2
		/// </summary>
		public Newtonsoft.Json.Linq.JObject PostAnonymousObject2(Newtonsoft.Json.Linq.JObject obj, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SpecialTypes/AnonymousObject2";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, obj);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<Newtonsoft.Json.Linq.JObject>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
	}
}
#nullable disable
#nullable enable
namespace DemoWebApi.Controllers.Client
{
	using System;
	using System.Linq;
	using System.Collections.Generic;
	using System.Threading.Tasks;
	using System.Net.Http;
	using Newtonsoft.Json;
	using Fonlow.Net.Http;
	
	
	public partial class DateTypes
	{
		
		private System.Net.Http.HttpClient client;
		
		private JsonSerializerSettings? jsonSerializerSettings;
		
		public DateTypes(System.Net.Http.HttpClient client, JsonSerializerSettings? jsonSerializerSettings=null)
		{
			if (client == null)
				throw new ArgumentNullException(nameof(client), "Null HttpClient.");

			if (client.BaseAddress == null)
				throw new ArgumentNullException(nameof(client), "HttpClient has no BaseAddress");

			this.client = client;
			this.jsonSerializerSettings = jsonSerializerSettings;
		}
		
		/// <summary>
		/// GET api/DateTypes/NullableDatetime/{hasValue}
		/// </summary>
		public async Task<System.Nullable<System.DateTime>> GetDateTimeAsync(bool hasValue, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/NullableDatetime/"+hasValue;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Nullable<System.DateTime>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/DateTypes/NullableDatetime/{hasValue}
		/// </summary>
		public System.Nullable<System.DateTime> GetDateTime(bool hasValue, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/NullableDatetime/"+hasValue;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Nullable<System.DateTime>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// return DateTimeOffset.Now
		/// GET api/DateTypes/ForDateTimeOffset
		/// </summary>
		public async Task<System.DateTimeOffset> GetDateTimeOffsetAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/ForDateTimeOffset";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.DateTimeOffset>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// return DateTimeOffset.Now
		/// GET api/DateTypes/ForDateTimeOffset
		/// </summary>
		public System.DateTimeOffset GetDateTimeOffset(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/ForDateTimeOffset";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.DateTimeOffset>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/DateTypes/NextHour/{dt}
		/// </summary>
		public async Task<System.DateTimeOffset> GetNextHourAsync(System.DateTimeOffset dt, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/NextHour/"+dt.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffffffZ");
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.DateTimeOffset>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/DateTypes/NextHour/{dt}
		/// </summary>
		public System.DateTimeOffset GetNextHour(System.DateTimeOffset dt, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/NextHour/"+dt.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffffffZ");
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.DateTimeOffset>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/DateTypes/NextHourNullable?n={n}&dt={dt}
		/// </summary>
		public async Task<System.DateTimeOffset> GetNextHourNullableAsync(int n, System.Nullable<System.DateTimeOffset> dt, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/NextHourNullable?n="+n+(dt.HasValue?"&dt="+dt.Value.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffffffZ"):String.Empty);
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.DateTimeOffset>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/DateTypes/NextHourNullable?n={n}&dt={dt}
		/// </summary>
		public System.DateTimeOffset GetNextHourNullable(int n, System.Nullable<System.DateTimeOffset> dt, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/NextHourNullable?n="+n+(dt.HasValue?"&dt="+dt.Value.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffffffZ"):String.Empty);
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.DateTimeOffset>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/DateTypes/NextYear/{dt}
		/// </summary>
		public async Task<System.DateTime> GetNextYearAsync(System.DateTime dt, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/NextYear/"+dt.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffffffZ");
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.DateTime>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/DateTypes/NextYear/{dt}
		/// </summary>
		public System.DateTime GetNextYear(System.DateTime dt, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/NextYear/"+dt.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffffffZ");
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.DateTime>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/DateTypes/NextYearNullable?n={n}&dt={dt}
		/// </summary>
		public async Task<System.DateTime> GetNextYearNullableAsync(int n, System.Nullable<System.DateTime> dt, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/NextYearNullable?n="+n+(dt.HasValue?"&dt="+dt.Value.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffffffZ"):String.Empty);
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.DateTime>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/DateTypes/NextYearNullable?n={n}&dt={dt}
		/// </summary>
		public System.DateTime GetNextYearNullable(int n, System.Nullable<System.DateTime> dt, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/NextYearNullable?n="+n+(dt.HasValue?"&dt="+dt.Value.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffffffZ"):String.Empty);
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.DateTime>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Client should send DateTime.Date
		/// POST api/DateTypes/IsDateTimeDate
		/// </summary>
		public async Task<System.Tuple<System.DateOnly, System.DateTime>> IsDateTimeDateAsync(System.DateTime dt, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/IsDateTimeDate";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, dt);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<System.DateOnly, System.DateTime>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Client should send DateTime.Date
		/// POST api/DateTypes/IsDateTimeDate
		/// </summary>
		public System.Tuple<System.DateOnly, System.DateTime> IsDateTimeDate(System.DateTime dt, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/IsDateTimeDate";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, dt);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<System.DateOnly, System.DateTime>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/DateTypes/IsDateTimeOffsetDate
		/// </summary>
		public async Task<System.Tuple<System.DateOnly, System.DateTimeOffset>> IsDateTimeOffsetDateAsync(System.DateTimeOffset dt, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/IsDateTimeOffsetDate";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, dt);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<System.DateOnly, System.DateTimeOffset>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/DateTypes/IsDateTimeOffsetDate
		/// </summary>
		public System.Tuple<System.DateOnly, System.DateTimeOffset> IsDateTimeOffsetDate(System.DateTimeOffset dt, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/IsDateTimeOffsetDate";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, dt);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<System.DateOnly, System.DateTimeOffset>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/DateTypes/ForDateOnly
		/// </summary>
		public async Task<System.DateOnly> PostDateOnlyAsync(System.DateOnly d, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/ForDateOnly";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, d);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.DateOnly>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/DateTypes/ForDateOnly
		/// </summary>
		public System.DateOnly PostDateOnly(System.DateOnly d, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/ForDateOnly";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, d);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.DateOnly>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/DateTypes/DateOnlyNullable
		/// </summary>
		public async Task<System.Nullable<System.DateOnly>> PostDateOnlyNullableAsync(System.Nullable<System.DateOnly> d, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/DateOnlyNullable";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, d);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Nullable<System.DateOnly>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/DateTypes/DateOnlyNullable
		/// </summary>
		public System.Nullable<System.DateOnly> PostDateOnlyNullable(System.Nullable<System.DateOnly> d, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/DateOnlyNullable";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, d);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Nullable<System.DateOnly>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/DateTypes/ForDateTime
		/// </summary>
		public async Task<System.DateTime> PostDateTimeAsync(System.DateTime d, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/ForDateTime";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, d);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.DateTime>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/DateTypes/ForDateTime
		/// </summary>
		public System.DateTime PostDateTime(System.DateTime d, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/ForDateTime";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, d);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.DateTime>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// return d;
		/// POST api/DateTypes/ForDateTimeOffset
		/// </summary>
		public async Task<System.DateTimeOffset> PostDateTimeOffsetAsync(System.DateTimeOffset d, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/ForDateTimeOffset";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, d);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.DateTimeOffset>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// return d;
		/// POST api/DateTypes/ForDateTimeOffset
		/// </summary>
		public System.DateTimeOffset PostDateTimeOffset(System.DateTimeOffset d, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/ForDateTimeOffset";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, d);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.DateTimeOffset>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// return d.ToString("O")
		/// POST api/DateTypes/ForDateTimeOffsetForO
		/// </summary>
		public async Task<string> PostDateTimeOffsetForOAsync(System.DateTimeOffset d, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/ForDateTimeOffsetForO";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, d);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// return d.ToString("O")
		/// POST api/DateTypes/ForDateTimeOffsetForO
		/// </summary>
		public string PostDateTimeOffsetForO(System.DateTimeOffset d, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/ForDateTimeOffsetForO";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, d);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/DateTypes/ForDateTimeOffsetForOffset
		/// </summary>
		public async Task<System.TimeSpan> PostDateTimeOffsetForOffsetAsync(System.DateTimeOffset d, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/ForDateTimeOffsetForOffset";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, d);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.TimeSpan>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/DateTypes/ForDateTimeOffsetForOffset
		/// </summary>
		public System.TimeSpan PostDateTimeOffsetForOffset(System.DateTimeOffset d, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/ForDateTimeOffsetForOffset";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, d);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.TimeSpan>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/DateTypes/DateTimeOffsetNullable
		/// </summary>
		public async Task<System.Nullable<System.DateTimeOffset>> PostDateTimeOffsetNullableAsync(System.Nullable<System.DateTimeOffset> d, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/DateTimeOffsetNullable";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, d);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Nullable<System.DateTimeOffset>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/DateTypes/DateTimeOffsetNullable
		/// </summary>
		public System.Nullable<System.DateTimeOffset> PostDateTimeOffsetNullable(System.Nullable<System.DateTimeOffset> d, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/DateTimeOffsetNullable";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, d);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Nullable<System.DateTimeOffset>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/DateTypes/ForDateTimeOffsetStringForOffset
		/// </summary>
		public async Task<System.TimeSpan> PostDateTimeOffsetStringForOffsetAsync(string s, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/ForDateTimeOffsetStringForOffset";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, s);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.TimeSpan>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/DateTypes/ForDateTimeOffsetStringForOffset
		/// </summary>
		public System.TimeSpan PostDateTimeOffsetStringForOffset(string s, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/ForDateTimeOffsetStringForOffset";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, s);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.TimeSpan>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/DateTypes/NextYear
		/// </summary>
		public async Task<System.DateTime> PostNextYearAsync(System.DateTime dt, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/NextYear";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, dt);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.DateTime>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/DateTypes/NextYear
		/// </summary>
		public System.DateTime PostNextYear(System.DateTime dt, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/NextYear";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, dt);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.DateTime>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/DateTypes/DateOnlyStringQuery?d={d}
		/// </summary>
		public async Task<System.DateOnly> QueryDateOnlyAsStringAsync(string d, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/DateOnlyStringQuery?d="+(d == null ? "" : Uri.EscapeDataString(d));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.DateOnly>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/DateTypes/DateOnlyStringQuery?d={d}
		/// </summary>
		public System.DateOnly QueryDateOnlyAsString(string d, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/DateOnlyStringQuery?d="+(d == null ? "" : Uri.EscapeDataString(d));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.DateOnly>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/DateTypes/RouteDateTimeOffset/{d}
		/// </summary>
		public async Task<System.DateTimeOffset> RouteDateTimeOffsetAsync(System.DateTimeOffset d, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/RouteDateTimeOffset/"+d.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffffffZ");
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.DateTimeOffset>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/DateTypes/RouteDateTimeOffset/{d}
		/// </summary>
		public System.DateTimeOffset RouteDateTimeOffset(System.DateTimeOffset d, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/RouteDateTimeOffset/"+d.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffffffZ");
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.DateTimeOffset>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/DateTypes/SearchDateRange?startDate={startDate}&endDate={endDate}
		/// </summary>
		public async Task<System.Tuple<System.Nullable<System.DateTime>, System.Nullable<System.DateTime>>> SearchDateRangeAsync(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/SearchDateRange?"+(startDate.HasValue?"startDate="+startDate.Value.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffffffZ"):String.Empty)+(endDate.HasValue?"&endDate="+endDate.Value.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffffffZ"):String.Empty);
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<System.Nullable<System.DateTime>, System.Nullable<System.DateTime>>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/DateTypes/SearchDateRange?startDate={startDate}&endDate={endDate}
		/// </summary>
		public System.Tuple<System.Nullable<System.DateTime>, System.Nullable<System.DateTime>> SearchDateRange(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/DateTypes/SearchDateRange?"+(startDate.HasValue?"startDate="+startDate.Value.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffffffZ"):String.Empty)+(endDate.HasValue?"&endDate="+endDate.Value.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffffffZ"):String.Empty);
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<System.Nullable<System.DateTime>, System.Nullable<System.DateTime>>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
	}
	
	public partial class Entities
	{
		
		private System.Net.Http.HttpClient client;
		
		private JsonSerializerSettings? jsonSerializerSettings;
		
		public Entities(System.Net.Http.HttpClient client, JsonSerializerSettings? jsonSerializerSettings=null)
		{
			if (client == null)
				throw new ArgumentNullException(nameof(client), "Null HttpClient.");

			if (client.BaseAddress == null)
				throw new ArgumentNullException(nameof(client), "HttpClient has no BaseAddress");

			this.client = client;
			this.jsonSerializerSettings = jsonSerializerSettings;
		}
		
		/// <summary>
		/// POST api/Entities/createCompany
		/// </summary>
		public async Task<DemoWebApi.DemoData.Client.Company> CreateCompanyAsync(DemoWebApi.DemoData.Client.Company p, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/createCompany";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, p);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Company>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Entities/createCompany
		/// </summary>
		public DemoWebApi.DemoData.Client.Company CreateCompany(DemoWebApi.DemoData.Client.Company p, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/createCompany";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, p);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Company>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Entities/createPerson
		/// </summary>
		public async Task<long> CreatePersonAsync(DemoWebApi.DemoData.Client.Person p, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/createPerson";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, p);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Int64.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Entities/createPerson
		/// </summary>
		public long CreatePerson(DemoWebApi.DemoData.Client.Person p, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/createPerson";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, p);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Int64.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Entities/createPerson2
		/// </summary>
		public async Task<DemoWebApi.DemoData.Client.Person> CreatePerson2Async(DemoWebApi.DemoData.Client.Person p, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/createPerson2";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, p);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Person>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Entities/createPerson2
		/// </summary>
		public DemoWebApi.DemoData.Client.Person CreatePerson2(DemoWebApi.DemoData.Client.Person p, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/createPerson2";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, p);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Person>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Entities/createPerson3
		/// </summary>
		public async Task<DemoWebApi.DemoData.Client.Person> CreatePerson3Async(DemoWebApi.DemoData.Client.Person p, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/createPerson3";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, p);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Person>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Entities/createPerson3
		/// </summary>
		public DemoWebApi.DemoData.Client.Person CreatePerson3(DemoWebApi.DemoData.Client.Person p, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/createPerson3";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, p);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Person>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// DELETE api/Entities/{id}
		/// </summary>
		public async Task DeleteAsync(long id, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/"+id;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// DELETE api/Entities/{id}
		/// </summary>
		public void Delete(long id, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/"+id;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/Entities/Company/{id}
		/// </summary>
		public async Task<DemoWebApi.DemoData.Client.Company> GetCompanyAsync(long id, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/Company/"+id;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Company>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/Entities/Company/{id}
		/// </summary>
		public DemoWebApi.DemoData.Client.Company GetCompany(long id, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/Company/"+id;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Company>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Entities/Mims
		/// </summary>
		public async Task<DemoWebApi.DemoData.Client.MimsResult<string>> GetMimsAsync(DemoWebApi.DemoData.Client.MimsPackage p, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/Mims";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, p);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.MimsResult<string>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Entities/Mims
		/// </summary>
		public DemoWebApi.DemoData.Client.MimsResult<string> GetMims(DemoWebApi.DemoData.Client.MimsPackage p, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/Mims";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, p);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.MimsResult<string>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Entities/MyGeneric
		/// </summary>
		public async Task<DemoWebApi.DemoData.Client.MyGeneric<string, decimal, double>> GetMyGenericAsync(DemoWebApi.DemoData.Client.MyGeneric<string, decimal, double> s, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/MyGeneric";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, s);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.MyGeneric<string, decimal, double>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Entities/MyGeneric
		/// </summary>
		public DemoWebApi.DemoData.Client.MyGeneric<string, decimal, double> GetMyGeneric(DemoWebApi.DemoData.Client.MyGeneric<string, decimal, double> s, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/MyGeneric";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, s);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.MyGeneric<string, decimal, double>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Entities/MyGenericPerson
		/// </summary>
		public async Task<DemoWebApi.DemoData.Client.MyGeneric<string, decimal, DemoWebApi.DemoData.Client.Person>> GetMyGenericPersonAsync(DemoWebApi.DemoData.Client.MyGeneric<string, decimal, DemoWebApi.DemoData.Client.Person> s, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/MyGenericPerson";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, s);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.MyGeneric<string, decimal, DemoWebApi.DemoData.Client.Person>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Entities/MyGenericPerson
		/// </summary>
		public DemoWebApi.DemoData.Client.MyGeneric<string, decimal, DemoWebApi.DemoData.Client.Person> GetMyGenericPerson(DemoWebApi.DemoData.Client.MyGeneric<string, decimal, DemoWebApi.DemoData.Client.Person> s, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/MyGenericPerson";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, s);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.MyGeneric<string, decimal, DemoWebApi.DemoData.Client.Person>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Return empty body, status 204.
		/// GET api/Entities/NullCompany
		/// </summary>
		public async Task<DemoWebApi.DemoData.Client.Company?> GetNullCompanyAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/NullCompany";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Company>(jsonReader);
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Return empty body, status 204.
		/// GET api/Entities/NullCompany
		/// </summary>
		public DemoWebApi.DemoData.Client.Company? GetNullCompany(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/NullCompany";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Company>(jsonReader);
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Get a person
		/// so to know the person
		/// GET api/Entities/getPerson/{id}
		/// </summary>
		/// <param name="id">unique id of that guy</param>
		/// <returns>person in db</returns>
		public async Task<DemoWebApi.DemoData.Client.Person> GetPersonAsync(long id, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/getPerson/"+id;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Person>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Get a person
		/// so to know the person
		/// GET api/Entities/getPerson/{id}
		/// </summary>
		/// <param name="id">unique id of that guy</param>
		/// <returns>person in db</returns>
		public DemoWebApi.DemoData.Client.Person GetPerson(long id, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/getPerson/"+id;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Person>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/Entities/getPerson2/{id}
		/// </summary>
		public async Task<DemoWebApi.DemoData.Client.Person> GetPerson2Async(long id, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/getPerson2/"+id;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Person>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/Entities/getPerson2/{id}
		/// </summary>
		public DemoWebApi.DemoData.Client.Person GetPerson2(long id, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/getPerson2/"+id;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Person>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// PUT api/Entities/link?id={id}&relationship={relationship}
		/// </summary>
		public async Task<bool> LinkPersonAsync(long id, string relationship, DemoWebApi.DemoData.Client.Person person, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/link?id="+id+"&relationship="+(relationship == null ? "" : Uri.EscapeDataString(relationship));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Put, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, person);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Boolean.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// PUT api/Entities/link?id={id}&relationship={relationship}
		/// </summary>
		public bool LinkPerson(long id, string relationship, DemoWebApi.DemoData.Client.Person person, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/link?id="+id+"&relationship="+(relationship == null ? "" : Uri.EscapeDataString(relationship));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Put, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, person);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Boolean.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// PATCH api/Entities/patchPerson
		/// </summary>
		public async Task<string> PatchPersonAsync(DemoWebApi.DemoData.Client.Person person, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/patchPerson";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, person);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// PATCH api/Entities/patchPerson
		/// </summary>
		public string PatchPerson(DemoWebApi.DemoData.Client.Person person, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/patchPerson";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, person);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Entities/IdMap
		/// </summary>
		public async Task<DemoWebApi.DemoData.Client.IdMap> PostIdMapAsync(DemoWebApi.DemoData.Client.IdMap idMap, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/IdMap";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, idMap);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.IdMap>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Entities/IdMap
		/// </summary>
		public DemoWebApi.DemoData.Client.IdMap PostIdMap(DemoWebApi.DemoData.Client.IdMap idMap, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/IdMap";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, idMap);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.IdMap>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// PUT api/Entities/updatePerson
		/// </summary>
		public async Task<string> UpdatePersonAsync(DemoWebApi.DemoData.Client.Person person, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/updatePerson";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Put, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, person);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// PUT api/Entities/updatePerson
		/// </summary>
		public string UpdatePerson(DemoWebApi.DemoData.Client.Person person, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Entities/updatePerson";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Put, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, person);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
	}
	
	public partial class Heroes
	{
		
		private System.Net.Http.HttpClient client;
		
		private JsonSerializerSettings? jsonSerializerSettings;
		
		public Heroes(System.Net.Http.HttpClient client, JsonSerializerSettings? jsonSerializerSettings=null)
		{
			if (client == null)
				throw new ArgumentNullException(nameof(client), "Null HttpClient.");

			if (client.BaseAddress == null)
				throw new ArgumentNullException(nameof(client), "HttpClient has no BaseAddress");

			this.client = client;
			this.jsonSerializerSettings = jsonSerializerSettings;
		}
		
		/// <summary>
		/// DELETE api/Heroes/{id}
		/// </summary>
		public async Task DeleteAsync(long id, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Heroes/"+id;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// DELETE api/Heroes/{id}
		/// </summary>
		public void Delete(long id, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Heroes/"+id;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/Heroes/asyncHeroes
		/// </summary>
		public async Task<DemoWebApi.Controllers.Client.Hero[]> GetAsyncHeroesAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Heroes/asyncHeroes";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.Controllers.Client.Hero[]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/Heroes/asyncHeroes
		/// </summary>
		public DemoWebApi.Controllers.Client.Hero[] GetAsyncHeroes(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Heroes/asyncHeroes";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.Controllers.Client.Hero[]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Get a hero. Nullable reference.
		/// GET api/Heroes/{id}
		/// </summary>
		public async Task<DemoWebApi.Controllers.Client.Hero?> GetHeroAsync(long id, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Heroes/"+id;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.Controllers.Client.Hero>(jsonReader);
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Get a hero. Nullable reference.
		/// GET api/Heroes/{id}
		/// </summary>
		public DemoWebApi.Controllers.Client.Hero? GetHero(long id, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Heroes/"+id;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.Controllers.Client.Hero>(jsonReader);
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Get all heroes.
		/// GET api/Heroes
		/// </summary>
		public async Task<DemoWebApi.Controllers.Client.Hero[]> GetHerosAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Heroes";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.Controllers.Client.Hero[]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Get all heroes.
		/// GET api/Heroes
		/// </summary>
		public DemoWebApi.Controllers.Client.Hero[] GetHeros(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Heroes";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.Controllers.Client.Hero[]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Heroes
		/// </summary>
		public async Task<DemoWebApi.Controllers.Client.Hero> PostAsync(string name, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Heroes";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, name);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.Controllers.Client.Hero>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Heroes
		/// </summary>
		public DemoWebApi.Controllers.Client.Hero Post(string name, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Heroes";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, name);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.Controllers.Client.Hero>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Add a hero. The client will not expect null.
		/// POST api/Heroes/q?name={name}
		/// </summary>
		/// <returns>Always object.</returns>
		public async Task<DemoWebApi.Controllers.Client.Hero> PostWithQueryAsync(string name, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Heroes/q?name="+(name == null ? "" : Uri.EscapeDataString(name));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.Controllers.Client.Hero>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Add a hero. The client will not expect null.
		/// POST api/Heroes/q?name={name}
		/// </summary>
		/// <returns>Always object.</returns>
		public DemoWebApi.Controllers.Client.Hero PostWithQuery(string name, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Heroes/q?name="+(name == null ? "" : Uri.EscapeDataString(name));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.Controllers.Client.Hero>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Update hero.
		/// PUT api/Heroes
		/// </summary>
		public async Task<DemoWebApi.Controllers.Client.Hero> PutAsync(DemoWebApi.Controllers.Client.Hero hero, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Heroes";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Put, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, hero);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.Controllers.Client.Hero>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Update hero.
		/// PUT api/Heroes
		/// </summary>
		public DemoWebApi.Controllers.Client.Hero Put(DemoWebApi.Controllers.Client.Hero hero, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Heroes";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Put, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, hero);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.Controllers.Client.Hero>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Search heroes
		/// GET api/Heroes/search/{name}
		/// </summary>
		/// <param name="name">keyword contained in hero name.</param>
		/// <returns>Hero array matching the keyword.</returns>
		public async Task<DemoWebApi.Controllers.Client.Hero[]> SearchAsync(string name, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Heroes/search/"+(name == null ? "" : Uri.EscapeDataString(name));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.Controllers.Client.Hero[]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Search heroes
		/// GET api/Heroes/search/{name}
		/// </summary>
		/// <param name="name">keyword contained in hero name.</param>
		/// <returns>Hero array matching the keyword.</returns>
		public DemoWebApi.Controllers.Client.Hero[] Search(string name, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Heroes/search/"+(name == null ? "" : Uri.EscapeDataString(name));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.Controllers.Client.Hero[]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
	}
	
	public partial class StringData
	{
		
		private System.Net.Http.HttpClient client;
		
		private JsonSerializerSettings? jsonSerializerSettings;
		
		public StringData(System.Net.Http.HttpClient client, JsonSerializerSettings? jsonSerializerSettings=null)
		{
			if (client == null)
				throw new ArgumentNullException(nameof(client), "Null HttpClient.");

			if (client.BaseAddress == null)
				throw new ArgumentNullException(nameof(client), "HttpClient has no BaseAddress");

			this.client = client;
			this.jsonSerializerSettings = jsonSerializerSettings;
		}
		
		/// <summary>
		/// GET api/StringData/AthletheSearch?take={take}&skip={skip}&order={order}&sort={sort}&search={search}
		/// </summary>
		public async Task<string> AthletheSearchAsync(System.Nullable<int> take, int skip, string order, string sort, string search, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/StringData/AthletheSearch?"+(take.HasValue?"take="+take.Value.ToString():String.Empty)+"&skip="+skip+"&order="+(order == null ? "" : Uri.EscapeDataString(order))+"&sort="+(sort == null ? "" : Uri.EscapeDataString(sort))+"&search="+(search == null ? "" : Uri.EscapeDataString(search));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/StringData/AthletheSearch?take={take}&skip={skip}&order={order}&sort={sort}&search={search}
		/// </summary>
		public string AthletheSearch(System.Nullable<int> take, int skip, string order, string sort, string search, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/StringData/AthletheSearch?"+(take.HasValue?"take="+take.Value.ToString():String.Empty)+"&skip="+skip+"&order="+(order == null ? "" : Uri.EscapeDataString(order))+"&sort="+(sort == null ? "" : Uri.EscapeDataString(sort))+"&search="+(search == null ? "" : Uri.EscapeDataString(search));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/StringData/String
		/// </summary>
		public async Task<string> GetABCDEAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/StringData/String";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/StringData/String
		/// </summary>
		public string GetABCDE(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/StringData/String";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Return empty string JSON object. Status 200.
		/// GET api/StringData/EmptyString
		/// </summary>
		public async Task<string> GetEmptyStringAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/StringData/EmptyString";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Return empty string JSON object. Status 200.
		/// GET api/StringData/EmptyString
		/// </summary>
		public string GetEmptyString(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/StringData/EmptyString";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Return empty body with status 204 No Content, even though the default mime type is application/json.
		/// GET api/StringData/NullString
		/// </summary>
		public async Task<System.String?> GetNullStringAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/StringData/NullString";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				if (responseMessage.StatusCode == System.Net.HttpStatusCode.NoContent) { return null; }
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Return empty body with status 204 No Content, even though the default mime type is application/json.
		/// GET api/StringData/NullString
		/// </summary>
		public System.String? GetNullString(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/StringData/NullString";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				if (responseMessage.StatusCode == System.Net.HttpStatusCode.NoContent) { return null; }
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
	}
	
	public partial class SuperDemo
	{
		
		private System.Net.Http.HttpClient client;
		
		private JsonSerializerSettings? jsonSerializerSettings;
		
		public SuperDemo(System.Net.Http.HttpClient client, JsonSerializerSettings? jsonSerializerSettings=null)
		{
			if (client == null)
				throw new ArgumentNullException(nameof(client), "Null HttpClient.");

			if (client.BaseAddress == null)
				throw new ArgumentNullException(nameof(client), "HttpClient has no BaseAddress");

			this.client = client;
			this.jsonSerializerSettings = jsonSerializerSettings;
		}
		
		/// <summary>
		/// GET api/SuperDemo/ActionResult
		/// </summary>
		public async Task<System.Net.Http.HttpResponseMessage> GetActionResultAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/ActionResult";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			responseMessage.EnsureSuccessStatusCodeEx();
			return responseMessage;
		}
		
		/// <summary>
		/// GET api/SuperDemo/ActionResult
		/// </summary>
		public System.Net.Http.HttpResponseMessage GetActionResult(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/ActionResult";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			responseMessage.EnsureSuccessStatusCodeEx();
			return responseMessage;
		}
		
		/// <summary>
		/// GET api/SuperDemo/ActionResult2
		/// </summary>
		public async Task<System.Net.Http.HttpResponseMessage> GetActionResult2Async(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/ActionResult2";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			responseMessage.EnsureSuccessStatusCodeEx();
			return responseMessage;
		}
		
		/// <summary>
		/// GET api/SuperDemo/ActionResult2
		/// </summary>
		public System.Net.Http.HttpResponseMessage GetActionResult2(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/ActionResult2";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			responseMessage.EnsureSuccessStatusCodeEx();
			return responseMessage;
		}
		
		/// <summary>
		/// GET api/SuperDemo/ActionStringResult
		/// </summary>
		public async Task<string> GetActionStringResultAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/ActionStringResult";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/ActionStringResult
		/// </summary>
		public string GetActionStringResult(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/ActionStringResult";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/BadRequest
		/// </summary>
		public async Task<System.Net.Http.HttpResponseMessage> GetBadRequestAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/BadRequest";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			responseMessage.EnsureSuccessStatusCodeEx();
			return responseMessage;
		}
		
		/// <summary>
		/// GET api/SuperDemo/BadRequest
		/// </summary>
		public System.Net.Http.HttpResponseMessage GetBadRequest(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/BadRequest";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			responseMessage.EnsureSuccessStatusCodeEx();
			return responseMessage;
		}
		
		/// <summary>
		/// GET api/SuperDemo/BadRequest2
		/// </summary>
		public async Task<System.Net.Http.HttpResponseMessage> GetBadRequest2Async(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/BadRequest2";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			responseMessage.EnsureSuccessStatusCodeEx();
			return responseMessage;
		}
		
		/// <summary>
		/// GET api/SuperDemo/BadRequest2
		/// </summary>
		public System.Net.Http.HttpResponseMessage GetBadRequest2(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/BadRequest2";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			responseMessage.EnsureSuccessStatusCodeEx();
			return responseMessage;
		}
		
		/// <summary>
		/// GET api/SuperDemo/bool
		/// </summary>
		public async Task<bool> GetBoolAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/bool";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Boolean.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/bool
		/// </summary>
		public bool GetBool(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/bool";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Boolean.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/byte
		/// </summary>
		public async Task<byte> GetbyteAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/byte";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Byte.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/byte
		/// </summary>
		public byte Getbyte(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/byte";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Byte.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/ByteArray
		/// </summary>
		public async Task<byte[]> GetByteArrayAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/ByteArray";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<byte[]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/ByteArray
		/// </summary>
		public byte[] GetByteArray(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/ByteArray";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<byte[]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/char
		/// </summary>
		public async Task<char> GetCharAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/char";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<char>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/char
		/// </summary>
		public char GetChar(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/char";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<char>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/Collection
		/// </summary>
		public async Task<System.Collections.ObjectModel.Collection<DemoWebApi.DemoData.Client.Person>> GetCollectionAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/Collection";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Collections.ObjectModel.Collection<DemoWebApi.DemoData.Client.Person>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/Collection
		/// </summary>
		public System.Collections.ObjectModel.Collection<DemoWebApi.DemoData.Client.Person> GetCollection(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/Collection";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Collections.ObjectModel.Collection<DemoWebApi.DemoData.Client.Person>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/enumGet?d={d}
		/// </summary>
		public async Task<DemoWebApi.DemoData.Client.Days> GetDayAsync(DemoWebApi.DemoData.Client.Days d, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/enumGet?d="+d;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Days>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/enumGet?d={d}
		/// </summary>
		public DemoWebApi.DemoData.Client.Days GetDay(DemoWebApi.DemoData.Client.Days d, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/enumGet?d="+d;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Days>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/decimal
		/// </summary>
		public async Task<decimal> GetDecimalAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/decimal";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<decimal>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/decimal
		/// </summary>
		public decimal GetDecimal(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/decimal";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<decimal>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Demo
		/// GET api/SuperDemo/decimalArrayQ?a={a}
		/// </summary>
		public async Task<decimal[]> GetDecimalArrayQAsync(decimal[] a, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/decimalArrayQ?"+String.Join("&", a.Select(k => $"a={Uri.EscapeDataString(k.ToString())}"));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<decimal[]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Demo
		/// GET api/SuperDemo/decimalArrayQ?a={a}
		/// </summary>
		public decimal[] GetDecimalArrayQ(decimal[] a, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/decimalArrayQ?"+String.Join("&", a.Select(k => $"a={Uri.EscapeDataString(k.ToString())}"));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<decimal[]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/decimal/{d}
		/// </summary>
		public async Task<decimal> GetDecimalSquareAsync(decimal d, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/decimal/"+d;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<decimal>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/decimal/{d}
		/// </summary>
		public decimal GetDecimalSquare(decimal d, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/decimal/"+d;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<decimal>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/DecimalZero
		/// </summary>
		public async Task<decimal> GetDecimalZeroAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/DecimalZero";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<decimal>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/DecimalZero
		/// </summary>
		public decimal GetDecimalZero(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/DecimalZero";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<decimal>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/StringStringDic
		/// </summary>
		public async Task<System.Collections.Generic.IDictionary<string, string>> GetDictionaryAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/StringStringDic";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Collections.Generic.IDictionary<string, string>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/StringStringDic
		/// </summary>
		public System.Collections.Generic.IDictionary<string, string> GetDictionary(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/StringStringDic";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Collections.Generic.IDictionary<string, string>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/StringPersonDic
		/// </summary>
		public async Task<System.Collections.Generic.IDictionary<string, DemoWebApi.DemoData.Client.Person>> GetDictionaryOfPeopleAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/StringPersonDic";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Collections.Generic.IDictionary<string, DemoWebApi.DemoData.Client.Person>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/StringPersonDic
		/// </summary>
		public System.Collections.Generic.IDictionary<string, DemoWebApi.DemoData.Client.Person> GetDictionaryOfPeople(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/StringPersonDic";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Collections.Generic.IDictionary<string, DemoWebApi.DemoData.Client.Person>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/doulbe
		/// </summary>
		public async Task<double> GetdoubleAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/doulbe";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Double.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/doulbe
		/// </summary>
		public double Getdouble(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/doulbe";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Double.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Result of 0.1d + 0.2d - 0.3d
		/// GET api/SuperDemo/DoubleZero
		/// </summary>
		public async Task<double> GetDoubleZeroAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/DoubleZero";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Double.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Result of 0.1d + 0.2d - 0.3d
		/// GET api/SuperDemo/DoubleZero
		/// </summary>
		public double GetDoubleZero(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/DoubleZero";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Double.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/enumArrayDays?a={a}
		/// </summary>
		public async Task<DemoWebApi.DemoData.Client.Days[]> GetEnumArrayDaysAsync(System.Collections.Generic.IEnumerable<DemoWebApi.DemoData.Client.Days> a, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/enumArrayDays?"+String.Join("&", a.Select(k => $"a={Uri.EscapeDataString(k.ToString())}"));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Days[]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/enumArrayDays?a={a}
		/// </summary>
		public DemoWebApi.DemoData.Client.Days[] GetEnumArrayDays(System.Collections.Generic.IEnumerable<DemoWebApi.DemoData.Client.Days> a, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/enumArrayDays?"+String.Join("&", a.Select(k => $"a={Uri.EscapeDataString(k.ToString())}"));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Days[]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/enumArrayQ2?a={a}
		/// </summary>
		public async Task<System.DayOfWeek[]> GetEnumArrayQ2Async(System.Collections.Generic.List<System.DayOfWeek> a, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/enumArrayQ2?"+String.Join("&", a.Select(k => $"a={Uri.EscapeDataString(k.ToString())}"));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.DayOfWeek[]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/enumArrayQ2?a={a}
		/// </summary>
		public System.DayOfWeek[] GetEnumArrayQ2(System.Collections.Generic.List<System.DayOfWeek> a, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/enumArrayQ2?"+String.Join("&", a.Select(k => $"a={Uri.EscapeDataString(k.ToString())}"));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.DayOfWeek[]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/FloatZero
		/// </summary>
		public async Task<float> GetFloatZeroAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/FloatZero";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Single.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/FloatZero
		/// </summary>
		public float GetFloatZero(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/FloatZero";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Single.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/ICollection
		/// </summary>
		public async Task<System.Collections.Generic.ICollection<DemoWebApi.DemoData.Client.Person>> GetICollectionAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/ICollection";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Collections.Generic.ICollection<DemoWebApi.DemoData.Client.Person>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/ICollection
		/// </summary>
		public System.Collections.Generic.ICollection<DemoWebApi.DemoData.Client.Person> GetICollection(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/ICollection";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Collections.Generic.ICollection<DemoWebApi.DemoData.Client.Person>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/IList
		/// </summary>
		public async Task<System.Collections.Generic.IList<DemoWebApi.DemoData.Client.Person>> GetIListAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/IList";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Collections.Generic.IList<DemoWebApi.DemoData.Client.Person>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/IList
		/// </summary>
		public System.Collections.Generic.IList<DemoWebApi.DemoData.Client.Person> GetIList(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/IList";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Collections.Generic.IList<DemoWebApi.DemoData.Client.Person>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/int2d
		/// </summary>
		public async Task<int[,]> GetInt2DAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/int2d";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<int[,]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/int2d
		/// </summary>
		public int[,] GetInt2D(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/int2d";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<int[,]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/int2dJagged
		/// </summary>
		public async Task<int[][]> GetInt2DJaggedAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/int2dJagged";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<int[][]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/int2dJagged
		/// </summary>
		public int[][] GetInt2DJagged(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/int2dJagged";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<int[][]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/intArray
		/// </summary>
		public async Task<int[]> GetIntArrayAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/intArray";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<int[]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/intArray
		/// </summary>
		public int[] GetIntArray(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/intArray";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<int[]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Demo int[];
		/// GET api/SuperDemo/intArrayQ?a={a}
		/// </summary>
		public async Task<int[]> GetIntArrayQAsync(int[] a, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/intArrayQ?"+String.Join("&", a.Select(k => $"a={Uri.EscapeDataString(k.ToString())}"));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<int[]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Demo int[];
		/// GET api/SuperDemo/intArrayQ?a={a}
		/// </summary>
		public int[] GetIntArrayQ(int[] a, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/intArrayQ?"+String.Join("&", a.Select(k => $"a={Uri.EscapeDataString(k.ToString())}"));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<int[]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/intArrayQ2?a={a}
		/// </summary>
		public async Task<long[]> GetIntArrayQ2Async(System.Collections.Generic.IEnumerable<long> a, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/intArrayQ2?"+String.Join("&", a.Select(k => $"a={Uri.EscapeDataString(k.ToString())}"));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<long[]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/intArrayQ2?a={a}
		/// </summary>
		public long[] GetIntArrayQ2(System.Collections.Generic.IEnumerable<long> a, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/intArrayQ2?"+String.Join("&", a.Select(k => $"a={Uri.EscapeDataString(k.ToString())}"));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<long[]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/int/{d}
		/// </summary>
		public async Task<int> GetIntSquareAsync(int d, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/int/"+d;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Int32.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/int/{d}
		/// </summary>
		public int GetIntSquare(int d, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/int/"+d;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Int32.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/IReadOnlyCollection
		/// </summary>
		public async Task<System.Collections.Generic.IReadOnlyCollection<DemoWebApi.DemoData.Client.Person>> GetIReadOnlyCollectionAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/IReadOnlyCollection";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Collections.Generic.IReadOnlyCollection<DemoWebApi.DemoData.Client.Person>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/IReadOnlyCollection
		/// </summary>
		public System.Collections.Generic.IReadOnlyCollection<DemoWebApi.DemoData.Client.Person> GetIReadOnlyCollection(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/IReadOnlyCollection";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Collections.Generic.IReadOnlyCollection<DemoWebApi.DemoData.Client.Person>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/IReadOnlyList
		/// </summary>
		public async Task<System.Collections.Generic.IReadOnlyList<DemoWebApi.DemoData.Client.Person>> GetIReadOnlyListAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/IReadOnlyList";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Collections.Generic.IReadOnlyList<DemoWebApi.DemoData.Client.Person>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/IReadOnlyList
		/// </summary>
		public System.Collections.Generic.IReadOnlyList<DemoWebApi.DemoData.Client.Person> GetIReadOnlyList(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/IReadOnlyList";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Collections.Generic.IReadOnlyList<DemoWebApi.DemoData.Client.Person>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/KeyValuePair
		/// </summary>
		public async Task<System.Collections.Generic.KeyValuePair<string, DemoWebApi.DemoData.Client.Person>> GetKeyhValuePairAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/KeyValuePair";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Collections.Generic.KeyValuePair<string, DemoWebApi.DemoData.Client.Person>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/KeyValuePair
		/// </summary>
		public System.Collections.Generic.KeyValuePair<string, DemoWebApi.DemoData.Client.Person> GetKeyhValuePair(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/KeyValuePair";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Collections.Generic.KeyValuePair<string, DemoWebApi.DemoData.Client.Person>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/List
		/// </summary>
		public async Task<System.Collections.Generic.List<DemoWebApi.DemoData.Client.Person>> GetListAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/List";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Collections.Generic.List<DemoWebApi.DemoData.Client.Person>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/List
		/// </summary>
		public System.Collections.Generic.List<DemoWebApi.DemoData.Client.Person> GetList(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/List";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Collections.Generic.List<DemoWebApi.DemoData.Client.Person>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/NullableDecimal/{hasValue}
		/// </summary>
		public async Task<System.Nullable<decimal>> GetNullableDecimalAsync(bool hasValue, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/NullableDecimal/"+hasValue;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Nullable<decimal>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/NullableDecimal/{hasValue}
		/// </summary>
		public System.Nullable<decimal> GetNullableDecimal(bool hasValue, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/NullableDecimal/"+hasValue;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Nullable<decimal>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/NullObject
		/// </summary>
		public async Task<DemoWebApi.DemoData.Client.Person?> GetNullPersonAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/NullObject";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Person>(jsonReader);
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/NullObject
		/// </summary>
		public DemoWebApi.DemoData.Client.Person? GetNullPerson(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/NullObject";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Person>(jsonReader);
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/DoubleNullable?location={location}&dd={dd}&de={de}
		/// </summary>
		public async Task<System.Tuple<string, System.Nullable<double>, System.Nullable<decimal>>> GetPrimitiveNullableAsync(string location, System.Nullable<double> dd, System.Nullable<decimal> de, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/DoubleNullable?location="+(location == null ? "" : Uri.EscapeDataString(location))+(dd.HasValue?"&dd="+dd.Value.ToString():String.Empty)+(de.HasValue?"&de="+de.Value.ToString():String.Empty);
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<string, System.Nullable<double>, System.Nullable<decimal>>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/DoubleNullable?location={location}&dd={dd}&de={de}
		/// </summary>
		public System.Tuple<string, System.Nullable<double>, System.Nullable<decimal>> GetPrimitiveNullable(string location, System.Nullable<double> dd, System.Nullable<decimal> de, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/DoubleNullable?location="+(location == null ? "" : Uri.EscapeDataString(location))+(dd.HasValue?"&dd="+dd.Value.ToString():String.Empty)+(de.HasValue?"&de="+de.Value.ToString():String.Empty);
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<string, System.Nullable<double>, System.Nullable<decimal>>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/DoubleNullable2?dd={dd}&de={de}
		/// </summary>
		public async Task<System.Tuple<System.Nullable<double>, System.Nullable<decimal>>> GetPrimitiveNullable2Async(System.Nullable<double> dd, System.Nullable<decimal> de, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/DoubleNullable2?"+(dd.HasValue?"dd="+dd.Value.ToString():String.Empty)+(de.HasValue?"&de="+de.Value.ToString():String.Empty);
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<System.Nullable<double>, System.Nullable<decimal>>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/DoubleNullable2?dd={dd}&de={de}
		/// </summary>
		public System.Tuple<System.Nullable<double>, System.Nullable<decimal>> GetPrimitiveNullable2(System.Nullable<double> dd, System.Nullable<decimal> de, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/DoubleNullable2?"+(dd.HasValue?"dd="+dd.Value.ToString():String.Empty)+(de.HasValue?"&de="+de.Value.ToString():String.Empty);
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<System.Nullable<double>, System.Nullable<decimal>>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/sbyte
		/// </summary>
		public async Task<sbyte> GetsbyteAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/sbyte";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.SByte.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/sbyte
		/// </summary>
		public sbyte Getsbyte(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/sbyte";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.SByte.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/short
		/// </summary>
		public async Task<short> GetShortAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/short";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Int16.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/short
		/// </summary>
		public short GetShort(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/short";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Int16.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Demo string array
		/// GET api/SuperDemo/stringArrayQ?a={a}
		/// </summary>
		public async Task<string[]> GetStringArrayQAsync(string[] a, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/stringArrayQ?"+String.Join("&", a.Select(k => $"a={Uri.EscapeDataString(k.ToString())}"));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<string[]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Demo string array
		/// GET api/SuperDemo/stringArrayQ?a={a}
		/// </summary>
		public string[] GetStringArrayQ(string[] a, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/stringArrayQ?"+String.Join("&", a.Select(k => $"a={Uri.EscapeDataString(k.ToString())}"));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<string[]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/stringArrayQ2?a={a}
		/// </summary>
		public async Task<string[]> GetStringArrayQ2Async(System.Collections.Generic.List<string> a, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/stringArrayQ2?"+String.Join("&", a.Select(k => $"a={Uri.EscapeDataString(k.ToString())}"));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<string[]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/stringArrayQ2?a={a}
		/// </summary>
		public string[] GetStringArrayQ2(System.Collections.Generic.List<string> a, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/stringArrayQ2?"+String.Join("&", a.Select(k => $"a={Uri.EscapeDataString(k.ToString())}"));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<string[]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// ActionResult with FileStreamResult
		/// GET api/SuperDemo/TextStream
		/// </summary>
		public async Task<System.Net.Http.HttpResponseMessage> GetTextStreamAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/TextStream";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			responseMessage.EnsureSuccessStatusCodeEx();
			return responseMessage;
		}
		
		/// <summary>
		/// ActionResult with FileStreamResult
		/// GET api/SuperDemo/TextStream
		/// </summary>
		public System.Net.Http.HttpResponseMessage GetTextStream(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/TextStream";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			responseMessage.EnsureSuccessStatusCodeEx();
			return responseMessage;
		}
		
		/// <summary>
		/// GET api/SuperDemo/uint
		/// </summary>
		public async Task<uint> GetUintAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/uint";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.UInt32.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/uint
		/// </summary>
		public uint GetUint(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/uint";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.UInt32.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/ulong
		/// </summary>
		public async Task<ulong> GetulongAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/ulong";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.UInt64.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/ulong
		/// </summary>
		public ulong Getulong(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/ulong";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.UInt64.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/ushort
		/// </summary>
		public async Task<ushort> GetUShortAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/ushort";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.UInt16.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/SuperDemo/ushort
		/// </summary>
		public ushort GetUShort(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/ushort";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.UInt16.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/SuperDemo/ActionResult
		/// </summary>
		public async Task<System.Net.Http.HttpResponseMessage> PostActionResultAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/ActionResult";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			responseMessage.EnsureSuccessStatusCodeEx();
			return responseMessage;
		}
		
		/// <summary>
		/// POST api/SuperDemo/ActionResult
		/// </summary>
		public System.Net.Http.HttpResponseMessage PostActionResult(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/ActionResult";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			responseMessage.EnsureSuccessStatusCodeEx();
			return responseMessage;
		}
		
		/// <summary>
		/// POST api/SuperDemo/PostActionResult2
		/// </summary>
		public async Task<System.Net.Http.HttpResponseMessage> PostActionResult2Async(string s, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/PostActionResult2";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, s);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			responseMessage.EnsureSuccessStatusCodeEx();
			return responseMessage;
		}
		
		/// <summary>
		/// POST api/SuperDemo/PostActionResult2
		/// </summary>
		public System.Net.Http.HttpResponseMessage PostActionResult2(string s, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/PostActionResult2";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, s);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			responseMessage.EnsureSuccessStatusCodeEx();
			return responseMessage;
		}
		
		/// <summary>
		/// POST api/SuperDemo/PostActionResult3
		/// </summary>
		public async Task<System.Net.Http.HttpResponseMessage> PostActionResult3Async(DemoWebApi.DemoData.Client.Person person, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/PostActionResult3";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, person);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			responseMessage.EnsureSuccessStatusCodeEx();
			return responseMessage;
		}
		
		/// <summary>
		/// POST api/SuperDemo/PostActionResult3
		/// </summary>
		public System.Net.Http.HttpResponseMessage PostActionResult3(DemoWebApi.DemoData.Client.Person person, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/PostActionResult3";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, person);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			responseMessage.EnsureSuccessStatusCodeEx();
			return responseMessage;
		}
		
		/// <summary>
		/// POST api/SuperDemo/Collection
		/// </summary>
		public async Task<int> PostCollectionAsync(System.Collections.ObjectModel.Collection<DemoWebApi.DemoData.Client.Person> list, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/Collection";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, list);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Int32.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/SuperDemo/Collection
		/// </summary>
		public int PostCollection(System.Collections.ObjectModel.Collection<DemoWebApi.DemoData.Client.Person> list, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/Collection";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, list);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Int32.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/SuperDemo/enumPost?d={d}
		/// </summary>
		public async Task<DemoWebApi.DemoData.Client.Days[]> PostDayAsync(DemoWebApi.DemoData.Client.Days d, DemoWebApi.DemoData.Client.Days d2, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/enumPost?d="+d;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, d2);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Days[]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/SuperDemo/enumPost?d={d}
		/// </summary>
		public DemoWebApi.DemoData.Client.Days[] PostDay(DemoWebApi.DemoData.Client.Days d, DemoWebApi.DemoData.Client.Days d2, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/enumPost?d="+d;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, d2);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Days[]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/SuperDemo/StringPersonDic
		/// </summary>
		public async Task<int> PostDictionaryAsync(System.Collections.Generic.IDictionary<string, DemoWebApi.DemoData.Client.Person> dic, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/StringPersonDic";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, dic);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Int32.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/SuperDemo/StringPersonDic
		/// </summary>
		public int PostDictionary(System.Collections.Generic.IDictionary<string, DemoWebApi.DemoData.Client.Person> dic, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/StringPersonDic";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, dic);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Int32.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/SuperDemo/Guids
		/// </summary>
		public async Task<System.Guid[]> PostGuidsAsync(System.Guid[] guids, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/Guids";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, guids);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Guid[]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/SuperDemo/Guids
		/// </summary>
		public System.Guid[] PostGuids(System.Guid[] guids, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/Guids";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, guids);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Guid[]>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/SuperDemo/ICollection
		/// </summary>
		public async Task<int> PostICollectionAsync(System.Collections.Generic.ICollection<DemoWebApi.DemoData.Client.Person> list, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/ICollection";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, list);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Int32.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/SuperDemo/ICollection
		/// </summary>
		public int PostICollection(System.Collections.Generic.ICollection<DemoWebApi.DemoData.Client.Person> list, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/ICollection";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, list);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Int32.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/SuperDemo/IList
		/// </summary>
		public async Task<int> PostIListAsync(System.Collections.Generic.IList<DemoWebApi.DemoData.Client.Person> list, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/IList";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, list);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Int32.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/SuperDemo/IList
		/// </summary>
		public int PostIList(System.Collections.Generic.IList<DemoWebApi.DemoData.Client.Person> list, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/IList";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, list);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Int32.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/SuperDemo/int2d
		/// </summary>
		public async Task<bool> PostInt2DAsync(int[,] a, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/int2d";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, a);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Boolean.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/SuperDemo/int2d
		/// </summary>
		public bool PostInt2D(int[,] a, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/int2d";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, a);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Boolean.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Demo int[][]
		/// POST api/SuperDemo/int2djagged
		/// </summary>
		public async Task<bool> PostInt2DJaggedAsync(int[][] a, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/int2djagged";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, a);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Boolean.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Demo int[][]
		/// POST api/SuperDemo/int2djagged
		/// </summary>
		public bool PostInt2DJagged(int[][] a, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/int2djagged";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, a);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Boolean.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Demo int[]
		/// POST api/SuperDemo/intArray
		/// </summary>
		public async Task<bool> PostIntArrayAsync(int[] a, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/intArray";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, a);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Boolean.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Demo int[]
		/// POST api/SuperDemo/intArray
		/// </summary>
		public bool PostIntArray(int[] a, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/intArray";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, a);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Boolean.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/SuperDemo/IReadOnlyCollection
		/// </summary>
		public async Task<int> PostIReadOnlyCollectionAsync(System.Collections.Generic.IReadOnlyCollection<DemoWebApi.DemoData.Client.Person> list, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/IReadOnlyCollection";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, list);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Int32.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/SuperDemo/IReadOnlyCollection
		/// </summary>
		public int PostIReadOnlyCollection(System.Collections.Generic.IReadOnlyCollection<DemoWebApi.DemoData.Client.Person> list, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/IReadOnlyCollection";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, list);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Int32.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/SuperDemo/IReadOnlyList
		/// </summary>
		public async Task<int> PostIReadOnlyListAsync(System.Collections.Generic.IReadOnlyList<DemoWebApi.DemoData.Client.Person> list, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/IReadOnlyList";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, list);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Int32.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/SuperDemo/IReadOnlyList
		/// </summary>
		public int PostIReadOnlyList(System.Collections.Generic.IReadOnlyList<DemoWebApi.DemoData.Client.Person> list, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/IReadOnlyList";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, list);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Int32.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/SuperDemo/List
		/// </summary>
		public async Task<int> PostListAsync(System.Collections.Generic.List<DemoWebApi.DemoData.Client.Person> list, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/List";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, list);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Int32.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/SuperDemo/List
		/// </summary>
		public int PostList(System.Collections.Generic.List<DemoWebApi.DemoData.Client.Person> list, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/List";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, list);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Int32.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/SuperDemo/PostEmpty/{i}
		/// </summary>
		public async Task<System.Tuple<string, int>> PostWithQueryButEmptyBodyAsync(string s, int i, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/PostEmpty/"+i;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, s);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<string, int>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/SuperDemo/PostEmpty/{i}
		/// </summary>
		public System.Tuple<string, int> PostWithQueryButEmptyBody(string s, int i, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/SuperDemo/PostEmpty/"+i;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, s);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<string, int>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
	}
	
	public partial class TextData
	{
		
		private System.Net.Http.HttpClient client;
		
		private JsonSerializerSettings? jsonSerializerSettings;
		
		public TextData(System.Net.Http.HttpClient client, JsonSerializerSettings? jsonSerializerSettings=null)
		{
			if (client == null)
				throw new ArgumentNullException(nameof(client), "Null HttpClient.");

			if (client.BaseAddress == null)
				throw new ArgumentNullException(nameof(client), "HttpClient has no BaseAddress");

			this.client = client;
			this.jsonSerializerSettings = jsonSerializerSettings;
		}
		
		/// <summary>
		/// GET api/TextData/AthletheSearch?take={take}&skip={skip}&order={order}&sort={sort}&search={search}
		/// </summary>
		public async Task<string> AthletheSearchAsync(System.Nullable<int> take, int skip, string order, string sort, string search, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/TextData/AthletheSearch?"+(take.HasValue?"take="+take.Value.ToString():String.Empty)+"&skip="+skip+"&order="+(order == null ? "" : Uri.EscapeDataString(order))+"&sort="+(sort == null ? "" : Uri.EscapeDataString(sort))+"&search="+(search == null ? "" : Uri.EscapeDataString(search));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/TextData/AthletheSearch?take={take}&skip={skip}&order={order}&sort={sort}&search={search}
		/// </summary>
		public string AthletheSearch(System.Nullable<int> take, int skip, string order, string sort, string search, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/TextData/AthletheSearch?"+(take.HasValue?"take="+take.Value.ToString():String.Empty)+"&skip="+skip+"&order="+(order == null ? "" : Uri.EscapeDataString(order))+"&sort="+(sort == null ? "" : Uri.EscapeDataString(sort))+"&search="+(search == null ? "" : Uri.EscapeDataString(search));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/TextData/String
		/// </summary>
		public async Task<string> GetABCDEAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/TextData/String";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/TextData/String
		/// </summary>
		public string GetABCDE(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/TextData/String";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Return empty body with status 200.
		/// GET api/TextData/EmptyString
		/// </summary>
		public async Task<string> GetEmptyStringAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/TextData/EmptyString";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Return empty body with status 200.
		/// GET api/TextData/EmptyString
		/// </summary>
		public string GetEmptyString(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/TextData/EmptyString";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Return empty body with status 204 No Content.
		/// GET api/TextData/NullString
		/// </summary>
		public async Task<System.String?> GetNullStringAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/TextData/NullString";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				if (responseMessage.StatusCode == System.Net.HttpStatusCode.NoContent) { return null; }
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Return empty body with status 204 No Content.
		/// GET api/TextData/NullString
		/// </summary>
		public System.String? GetNullString(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/TextData/NullString";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				if (responseMessage.StatusCode == System.Net.HttpStatusCode.NoContent) { return null; }
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
	}
	
	public partial class Tuple
	{
		
		private System.Net.Http.HttpClient client;
		
		private JsonSerializerSettings? jsonSerializerSettings;
		
		public Tuple(System.Net.Http.HttpClient client, JsonSerializerSettings? jsonSerializerSettings=null)
		{
			if (client == null)
				throw new ArgumentNullException(nameof(client), "Null HttpClient.");

			if (client.BaseAddress == null)
				throw new ArgumentNullException(nameof(client), "HttpClient has no BaseAddress");

			this.client = client;
			this.jsonSerializerSettings = jsonSerializerSettings;
		}
		
		/// <summary>
		/// PUT api/Tuple/A1TupleArray
		/// </summary>
		public async Task A1TupleArrayAsync(System.Tuple<System.Guid, int>[] idAndOrderArray, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/A1TupleArray";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Put, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, idAndOrderArray);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// PUT api/Tuple/A1TupleArray
		/// </summary>
		public void A1TupleArray(System.Tuple<System.Guid, int>[] idAndOrderArray, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/A1TupleArray";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Put, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, idAndOrderArray);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// PUT api/Tuple/A1TupleArray
		/// </summary>
		public async Task A2TupleIEnumerableAsync(System.Collections.Generic.IEnumerable<System.Tuple<System.Guid, int>> idAndOrderArray, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/A1TupleArray";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Put, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, idAndOrderArray);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// PUT api/Tuple/A1TupleArray
		/// </summary>
		public void A2TupleIEnumerable(System.Collections.Generic.IEnumerable<System.Tuple<System.Guid, int>> idAndOrderArray, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/A1TupleArray";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Put, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, idAndOrderArray);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/ChangeName
		/// </summary>
		public async Task<DemoWebApi.DemoData.Client.Person> ChangeNameAsync(System.Tuple<string, DemoWebApi.DemoData.Client.Person> d, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/ChangeName";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, d);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Person>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/ChangeName
		/// </summary>
		public DemoWebApi.DemoData.Client.Person ChangeName(System.Tuple<string, DemoWebApi.DemoData.Client.Person> d, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/ChangeName";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, d);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Person>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Get Tuple in return
		/// GET api/Tuple/PeopleCompany4
		/// </summary>
		public async Task<System.Tuple<DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Company>> GetPeopleCompany4Async(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/PeopleCompany4";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Company>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Get Tuple in return
		/// GET api/Tuple/PeopleCompany4
		/// </summary>
		public System.Tuple<DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Company> GetPeopleCompany4(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/PeopleCompany4";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Company>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/Tuple/PeopleCompany5
		/// </summary>
		public async Task<System.Tuple<DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Company>> GetPeopleCompany5Async(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/PeopleCompany5";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Company>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/Tuple/PeopleCompany5
		/// </summary>
		public System.Tuple<DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Company> GetPeopleCompany5(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/PeopleCompany5";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Company>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/Tuple/Tuple1
		/// </summary>
		public async Task<System.Tuple<int>> GetTuple1Async(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple1";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<int>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/Tuple/Tuple1
		/// </summary>
		public System.Tuple<int> GetTuple1(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple1";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<int>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/Tuple/Tuple2
		/// </summary>
		public async Task<System.Tuple<string, int>> GetTuple2Async(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple2";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<string, int>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/Tuple/Tuple2
		/// </summary>
		public System.Tuple<string, int> GetTuple2(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple2";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<string, int>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/Tuple/Tuple3
		/// </summary>
		public async Task<System.Tuple<string, string, int>> GetTuple3Async(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple3";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<string, string, int>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/Tuple/Tuple3
		/// </summary>
		public System.Tuple<string, string, int> GetTuple3(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple3";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<string, string, int>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/Tuple/Tuple4
		/// </summary>
		public async Task<System.Tuple<string, string, string, int>> GetTuple4Async(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple4";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<string, string, string, int>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/Tuple/Tuple4
		/// </summary>
		public System.Tuple<string, string, string, int> GetTuple4(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple4";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<string, string, string, int>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/Tuple/Tuple5
		/// </summary>
		public async Task<System.Tuple<string, string, string, string, int>> GetTuple5Async(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple5";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<string, string, string, string, int>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/Tuple/Tuple5
		/// </summary>
		public System.Tuple<string, string, string, string, int> GetTuple5(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple5";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<string, string, string, string, int>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/Tuple/Tuple6
		/// </summary>
		public async Task<System.Tuple<string, string, string, string, string, int>> GetTuple6Async(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple6";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<string, string, string, string, string, int>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/Tuple/Tuple6
		/// </summary>
		public System.Tuple<string, string, string, string, string, int> GetTuple6(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple6";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<string, string, string, string, string, int>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/Tuple/Tuple7
		/// </summary>
		public async Task<System.Tuple<string, string, string, string, string, long, int>> GetTuple7Async(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple7";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<string, string, string, string, string, long, int>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/Tuple/Tuple7
		/// </summary>
		public System.Tuple<string, string, string, string, string, long, int> GetTuple7(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple7";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<string, string, string, string, string, long, int>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Post nested tuple
		/// GET api/Tuple/Tuple8
		/// </summary>
		public async Task<System.Tuple<string, string, string, string, string, string, int, System.Tuple<string, string, string>>> GetTuple8Async(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple8";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<string, string, string, string, string, string, int, System.Tuple<string, string, string>>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Post nested tuple
		/// GET api/Tuple/Tuple8
		/// </summary>
		public System.Tuple<string, string, string, string, string, string, int, System.Tuple<string, string, string>> GetTuple8(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple8";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Tuple<string, string, string, string, string, string, int, System.Tuple<string, string, string>>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/PeopleCompany2
		/// </summary>
		public async Task<DemoWebApi.DemoData.Client.Person> LinkPeopleCompany2Async(System.Tuple<DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Company> peopleAndCompany, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/PeopleCompany2";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, peopleAndCompany);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Person>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/PeopleCompany2
		/// </summary>
		public DemoWebApi.DemoData.Client.Person LinkPeopleCompany2(System.Tuple<DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Company> peopleAndCompany, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/PeopleCompany2";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, peopleAndCompany);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Person>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/PeopleCompany3
		/// </summary>
		public async Task<DemoWebApi.DemoData.Client.Person> LinkPeopleCompany3Async(System.Tuple<DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Company> peopleAndCompany, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/PeopleCompany3";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, peopleAndCompany);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Person>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/PeopleCompany3
		/// </summary>
		public DemoWebApi.DemoData.Client.Person LinkPeopleCompany3(System.Tuple<DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Company> peopleAndCompany, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/PeopleCompany3";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, peopleAndCompany);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Person>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/PeopleCompany4
		/// </summary>
		public async Task<DemoWebApi.DemoData.Client.Person> LinkPeopleCompany4Async(System.Tuple<DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Company> peopleAndCompany, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/PeopleCompany4";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, peopleAndCompany);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Person>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/PeopleCompany4
		/// </summary>
		public DemoWebApi.DemoData.Client.Person LinkPeopleCompany4(System.Tuple<DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Company> peopleAndCompany, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/PeopleCompany4";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, peopleAndCompany);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Person>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/PeopleCompany5
		/// </summary>
		public async Task<DemoWebApi.DemoData.Client.Person> LinkPeopleCompany5Async(System.Tuple<DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Company> peopleAndCompany, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/PeopleCompany5";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, peopleAndCompany);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Person>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/PeopleCompany5
		/// </summary>
		public DemoWebApi.DemoData.Client.Person LinkPeopleCompany5(System.Tuple<DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Company> peopleAndCompany, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/PeopleCompany5";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, peopleAndCompany);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Person>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/PeopleCompany6
		/// </summary>
		public async Task<DemoWebApi.DemoData.Client.Person> LinkPeopleCompany6Async(System.Tuple<DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Company> peopleAndCompany, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/PeopleCompany6";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, peopleAndCompany);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Person>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/PeopleCompany6
		/// </summary>
		public DemoWebApi.DemoData.Client.Person LinkPeopleCompany6(System.Tuple<DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Company> peopleAndCompany, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/PeopleCompany6";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, peopleAndCompany);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Person>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/PeopleCompany7
		/// </summary>
		public async Task<DemoWebApi.DemoData.Client.Person> LinkPeopleCompany7Async(System.Tuple<DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Company> peopleAndCompany, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/PeopleCompany7";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, peopleAndCompany);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Person>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/PeopleCompany7
		/// </summary>
		public DemoWebApi.DemoData.Client.Person LinkPeopleCompany7(System.Tuple<DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Company> peopleAndCompany, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/PeopleCompany7";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, peopleAndCompany);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Person>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/PeopleCompany8
		/// </summary>
		public async Task<DemoWebApi.DemoData.Client.Person> LinkPeopleCompany8Async(System.Tuple<DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Company> peopleAndCompany, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/PeopleCompany8";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, peopleAndCompany);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Person>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/PeopleCompany8
		/// </summary>
		public DemoWebApi.DemoData.Client.Person LinkPeopleCompany8(System.Tuple<DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Company> peopleAndCompany, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/PeopleCompany8";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, peopleAndCompany);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Person>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/PersonCompany1
		/// </summary>
		public async Task<DemoWebApi.DemoData.Client.Person> LinkPersonCompany1Async(System.Tuple<DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Company> peopleAndCompany, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/PersonCompany1";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, peopleAndCompany);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Person>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/PersonCompany1
		/// </summary>
		public DemoWebApi.DemoData.Client.Person LinkPersonCompany1(System.Tuple<DemoWebApi.DemoData.Client.Person, DemoWebApi.DemoData.Client.Company> peopleAndCompany, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/PersonCompany1";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, peopleAndCompany);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<DemoWebApi.DemoData.Client.Person>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/Tuple1
		/// </summary>
		public async Task<int> PostTuple1Async(System.Tuple<int> tuple, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple1";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, tuple);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Int32.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/Tuple1
		/// </summary>
		public int PostTuple1(System.Tuple<int> tuple, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple1";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, tuple);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				return System.Int32.Parse(jsonReader.ReadAsString()!)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/Tuple2
		/// </summary>
		public async Task<string> PostTuple2Async(System.Tuple<string, int> tuple, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple2";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, tuple);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/Tuple2
		/// </summary>
		public string PostTuple2(System.Tuple<string, int> tuple, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple2";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, tuple);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/Tuple3
		/// </summary>
		public async Task<string> PostTuple3Async(System.Tuple<string, string, int> tuple, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple3";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, tuple);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/Tuple3
		/// </summary>
		public string PostTuple3(System.Tuple<string, string, int> tuple, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple3";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, tuple);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/Tuple4
		/// </summary>
		public async Task<string> PostTuple4Async(System.Tuple<string, string, string, int> tuple, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple4";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, tuple);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/Tuple4
		/// </summary>
		public string PostTuple4(System.Tuple<string, string, string, int> tuple, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple4";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, tuple);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/Tuple5
		/// </summary>
		public async Task<string> PostTuple5Async(System.Tuple<string, string, string, string, int> tuple, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple5";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, tuple);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/Tuple5
		/// </summary>
		public string PostTuple5(System.Tuple<string, string, string, string, int> tuple, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple5";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, tuple);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/Tuple6
		/// </summary>
		public async Task<string> PostTuple6Async(System.Tuple<string, string, string, string, string, int> tuple, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple6";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, tuple);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/Tuple6
		/// </summary>
		public string PostTuple6(System.Tuple<string, string, string, string, string, int> tuple, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple6";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, tuple);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/Tuple7
		/// </summary>
		public async Task<string> PostTuple7Async(System.Tuple<string, string, string, string, string, long, int> tuple, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple7";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, tuple);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/Tuple7
		/// </summary>
		public string PostTuple7(System.Tuple<string, string, string, string, string, long, int> tuple, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple7";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, tuple);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/Tuple8
		/// </summary>
		public async Task<string> PostTuple8Async(System.Tuple<string, string, string, string, string, string, string, System.Tuple<string, string, string>> tuple, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple8";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, tuple);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Tuple/Tuple8
		/// </summary>
		public string PostTuple8(System.Tuple<string, string, string, string, string, string, string, System.Tuple<string, string, string>> tuple, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Tuple/Tuple8";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, tuple);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
	}
	
	public partial class Values
	{
		
		private System.Net.Http.HttpClient client;
		
		private JsonSerializerSettings? jsonSerializerSettings;
		
		public Values(System.Net.Http.HttpClient client, JsonSerializerSettings? jsonSerializerSettings=null)
		{
			if (client == null)
				throw new ArgumentNullException(nameof(client), "Null HttpClient.");

			if (client.BaseAddress == null)
				throw new ArgumentNullException(nameof(client), "HttpClient has no BaseAddress");

			this.client = client;
			this.jsonSerializerSettings = jsonSerializerSettings;
		}
		
		/// <summary>
		/// DELETE api/Values/{id}
		/// </summary>
		public async Task DeleteAsync(int id, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Values/"+id;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// DELETE api/Values/{id}
		/// </summary>
		public void Delete(int id, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Values/"+id;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Get a list of value
		/// GET api/Values
		/// </summary>
		public async Task<System.Collections.Generic.IEnumerable<string>> GetAsync(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Values";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Collections.Generic.IEnumerable<string>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Get a list of value
		/// GET api/Values
		/// </summary>
		public System.Collections.Generic.IEnumerable<string> Get(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Values";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Collections.Generic.IEnumerable<string>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Get by both Id and name
		/// GET api/Values/{id}?name={name}
		/// </summary>
		public async Task<string> GetAsync(int id, string name, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Values/"+id+"?name="+(name == null ? "" : Uri.EscapeDataString(name));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Get by both Id and name
		/// GET api/Values/{id}?name={name}
		/// </summary>
		public string Get(int id, string name, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Values/"+id+"?name="+(name == null ? "" : Uri.EscapeDataString(name));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/Values?name={name}
		/// </summary>
		public async Task<string> GetAsync(string name, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Values?name="+(name == null ? "" : Uri.EscapeDataString(name));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/Values?name={name}
		/// </summary>
		public string Get(string name, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Values?name="+(name == null ? "" : Uri.EscapeDataString(name));
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/Values/{id}
		/// </summary>
		public async Task<string> GetAsync(int id, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Values/"+id;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/Values/{id}
		/// </summary>
		public string Get(int id, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Values/"+id;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/Values/Get2
		/// </summary>
		public async Task<System.Collections.Generic.IEnumerable<string>> Get2Async(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Values/Get2";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Collections.Generic.IEnumerable<string>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// GET api/Values/Get2
		/// </summary>
		public System.Collections.Generic.IEnumerable<string> Get2(Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Values/Get2";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using JsonReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream));
				var serializer = JsonSerializer.Create(jsonSerializerSettings);
				return serializer.Deserialize<System.Collections.Generic.IEnumerable<string>>(jsonReader)!;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Values
		/// </summary>
		public async Task<string> PostAsync(string value, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Values";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, value);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = await responseMessage.Content.ReadAsStreamAsync();
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// POST api/Values
		/// </summary>
		public string Post(string value, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Values";
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, value);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
				var stream = responseMessage.Content.ReadAsStreamAsync().Result;
				using System.IO.StreamReader streamReader = new System.IO.StreamReader(stream);
				return streamReader.ReadToEnd();;
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Update with valjue
		/// PUT api/Values/{id}
		/// </summary>
		public async Task PutAsync(int id, string value, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Values/"+id;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Put, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, value);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = await client.SendAsync(httpRequestMessage);
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
		
		/// <summary>
		/// Update with valjue
		/// PUT api/Values/{id}
		/// </summary>
		public void Put(int id, string value, Action<System.Net.Http.Headers.HttpRequestHeaders>? handleHeaders = null)
		{
			var requestUri = "api/Values/"+id;
			using var httpRequestMessage = new HttpRequestMessage(HttpMethod.Put, requestUri);
			using var requestWriter = new System.IO.StringWriter();
			var requestSerializer = JsonSerializer.Create(jsonSerializerSettings);
			requestSerializer.Serialize(requestWriter, value);
			var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
			httpRequestMessage.Content = content;
			handleHeaders?.Invoke(httpRequestMessage.Headers);
			var responseMessage = client.SendAsync(httpRequestMessage).Result;
			try
			{
				responseMessage.EnsureSuccessStatusCodeEx();
			}
			finally
			{
				responseMessage.Dispose();
			}
		}
	}
}
#nullable disable
#nullable enable

namespace Fonlow.Net.Http
{
	using System.Net.Http;

	public class WebApiRequestException : HttpRequestException
	{
		public new System.Net.HttpStatusCode? StatusCode { get; private set; }

		public string Response { get; private set; }

		public System.Net.Http.Headers.HttpResponseHeaders Headers { get; private set; }

		public System.Net.Http.Headers.MediaTypeHeaderValue? ContentType { get; private set; }

		public WebApiRequestException(string? message, System.Net.HttpStatusCode statusCode, string response, System.Net.Http.Headers.HttpResponseHeaders headers, System.Net.Http.Headers.MediaTypeHeaderValue? contentType) : base(message)
		{
			StatusCode = statusCode;
			Response = response;
			Headers = headers;
			ContentType = contentType;
		}
	}

	public static class ResponseMessageExtensions
	{
		public static void EnsureSuccessStatusCodeEx(this HttpResponseMessage responseMessage)
		{
			if (!responseMessage.IsSuccessStatusCode)
			{
				var responseText = responseMessage.Content.ReadAsStringAsync().Result;
				var contentType = responseMessage.Content.Headers.ContentType;
				throw new WebApiRequestException(responseMessage.ReasonPhrase, responseMessage.StatusCode, responseText, responseMessage.Headers, contentType);
			}
		}
	}
}
#nullable disable
