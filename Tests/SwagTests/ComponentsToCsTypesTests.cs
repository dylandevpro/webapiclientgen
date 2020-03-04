using Fonlow.OpenApi.ClientTypes;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;
using System.IO;
using Xunit;

namespace SwagTests
{
    public class ToCsTypes
    {
        static OpenApiDocument ReadJson(string filePath)
        {
            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                return new OpenApiStreamReader().Read(stream, out var diagnostic);
            }
        }

        static string TranslateJsonToCode(string filePath)
        {
            OpenApiDocument doc = ReadJson(filePath);

            Settings settings = new Settings()
            {
                ClientNamespace = "MyNS",
            };
            var gen = new ComponentsToCsTypes(settings, new System.CodeDom.CodeCompileUnit());
            gen.CreateCodeDom(doc.Components);
            using (var writer = new StringWriter())
            {
                gen.WriteCode(writer);
                return writer.ToString();
            }

        }

        [Fact]
        public void TestSimplePet()
        {
            string expected = @"//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyNS {
    
    
    public class Pet {
        
        /// <summary>
        /// The name given to a pet
        /// </summary>
        public string Name { get; set; }//;
        
        /// <summary>
        /// Type of a pet
        /// </summary>
        public string PetType { get; set; }//;
    }
}
";
            var s = TranslateJsonToCode("SwagMock\\SimplePet.json");
            Assert.Equal(expected, s);
        }


        [Fact]
        public void TestSimplePetCat()
        {
            string expected = @"//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyNS {
    
    
    public class Pet {
        
        /// <summary>
        /// The name given to a pet
        /// </summary>
        public string Name { get; set; }//;
        
        /// <summary>
        /// Type of a pet
        /// </summary>
        public string PetType { get; set; }//;
    }
    
    /// <summary>
    /// A representation of a cat
    /// </summary>
    public class Cat : Pet {
        
        /// <summary>
        /// The measured skill for hunting
        /// </summary>
        public string HuntingSkill { get; set; }//;
    }
}
";
            var s = TranslateJsonToCode("SwagMock\\SimplePetCat.json");
            Assert.Equal(expected, s);
        }

        [Fact]
        public void TestSimpleEnum()
        {
            string expected = @"//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyNS {
    
    
    /// <summary>
    /// Phone types
    /// </summary>
    public enum PhoneType {
        
        Tel = 0,
        
        Mobile = 1,
        
        Skype = 2,
        
        Fax = 3,
    }
}
";
            var s = TranslateJsonToCode("SwagMock\\Enum.json");
            Assert.Equal(expected, s);
        }

        [Fact]
        public void TestSimpleIntEnum()
        {
            string expected = @"//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyNS {
    
    
    /// <summary>
    /// Integer enum types
    /// </summary>
    public enum IntType {
        
        _1 = 0,
        
        _2 = 1,
        
        _3 = 2,
        
        _4 = 3,
    }
}
";
            var s = TranslateJsonToCode("SwagMock\\IntEnum.json");
            Assert.Equal(expected, s);
        }


        [Fact]
        public void TestCasualEnum()
        {
            string expected = @"//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyNS {
    
    
    public class Pet {
        
        /// <summary>
        /// The name given to a pet
        /// </summary>
        public string Name { get; set; }//;
        
        /// <summary>
        /// Type of a pet
        /// </summary>
        public string PetType { get; set; }//;
        
        /// <summary>
        /// Pet status in the store
        /// </summary>
        public PetStatus Status { get; set; }//;
    }
    
    public enum PetStatus {
        
        available = 0,
        
        pending = 1,
        
        sold = 2,
    }
}
";
            var s = TranslateJsonToCode("SwagMock\\CasualEnum.json");
            Assert.Equal(expected, s);
        }

        [Fact]
        public void TestStringArray()
        {
            string expected = @"//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyNS {
    
    
    public class Pet {
        
        /// <summary>
        /// The name given to a pet
        /// </summary>
        public string Name { get; set; }//;
        
        /// <summary>
        /// Type of a pet
        /// </summary>
        public string PetType { get; set; }//;
        
        /// <summary>
        /// The list of URL to a cute photos featuring pet
        /// </summary>
        public string[] PhotoUrls { get; set; }//;
    }
}
";
            var s = TranslateJsonToCode("SwagMock\\StringArray.json");
            Assert.Equal(expected, s);
        }

        [Fact]
        public void TestCustomTypeArray()
        {
            string expected = @"//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyNS {
    
    
    public class Pet {
        
        /// <summary>
        /// The name given to a pet
        /// </summary>
        public string Name { get; set; }//;
        
        /// <summary>
        /// Type of a pet
        /// </summary>
        public string PetType { get; set; }//;
        
        /// <summary>
        /// Tags attached to the pet
        /// </summary>
        public Tag[] Tags { get; set; }//;
    }
    
    public class Tag {
        
        /// <summary>
        /// Tag ID
        /// </summary>
        public long Id { get; set; }//;
        
        /// <summary>
        /// Tag name
        /// </summary>
        public string Name { get; set; }//;
    }
}
";
            var s = TranslateJsonToCode("SwagMock\\CustomTypeArray.json");
            Assert.Equal(expected, s);
        }

        [Fact]
        public void TestSimpleOrder()
        {
            string expected = @"//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyNS {
    
    
    public class Order {
        
        public int Quantity { get; set; }//;
        
        /// <summary>
        /// Estimated ship date
        /// </summary>
        public System.DateTime ShipDate { get; set; }//;
        
        /// <summary>
        /// Order Status
        /// </summary>
        public OrderStatus Status { get; set; }//;
        
        /// <summary>
        /// Indicates whenever order was completed or not
        /// </summary>
        public bool Complete { get; set; }//;
        
        /// <summary>
        /// Unique Request Id
        /// </summary>
        public string RequestId { get; set; }//;
    }
    
    public enum OrderStatus {
        
        placed = 0,
        
        approved = 1,
        
        delivered = 2,
    }
}
";
            var s = TranslateJsonToCode("SwagMock\\SimpleOrder.json");
            Assert.Equal(expected, s);
        }

        [Fact]
        public void TestTypeAlias()
        {
            string expected = @"//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyNS {
    
    
    public class Tag {
        
        /// <summary>
        /// Tag ID
        /// </summary>
        public long Id { get; set; }//;
        
        /// <summary>
        /// Tag name
        /// </summary>
        public string Name { get; set; }//;
    }
}
";
            var s = TranslateJsonToCode("SwagMock\\TypeAlias.json");
            Assert.Equal(expected, s);
        }

        //[Fact]
        //public void TestArrayProperty()
        //{
        //    var doc = ReadJson("SwagMock\\StringArray.json");
        //    var property = doc.Components.Schemas["Pet"].Properties["photoUrls"];
        //    Assert.Equal("array", property.Type);
        //    Assert.Equal(20, property.MaxItems);
        //    Assert.NotNull(property.Items); //failed with 1.1.4 and 1.2.0 preview
        //}


        [Fact]
        public void TestRequired()
        {
            string expected = @"//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyNS {
    
    
    public class Pet {
        
        /// <summary>
        /// The name given to a pet
        /// </summary>
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        public string Name { get; set; }//;
        
        /// <summary>
        /// Type of a pet
        /// </summary>
        public string PetType { get; set; }//;
    }
    
    /// <summary>
    /// A representation of a cat
    /// </summary>
    public class Cat : Pet {
        
        /// <summary>
        /// The measured skill for hunting
        /// </summary>
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        public string HuntingSkill { get; set; }//;
    }
}
";
            var s = TranslateJsonToCode("SwagMock\\Required.json");
            Assert.Equal(expected, s);
        }

    }
}