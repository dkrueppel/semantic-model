using System;
using System.Collections.Generic;
using Conizi.Model.Core.Conversion;
using Conizi.Model.Core.Generation;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Test.Library.Entities;
using Newtonsoft.Json;
using Xunit;
using Xunit.Sdk;

namespace Conizi.Model.UnitTests.Conversion
{
    public class DeserializerTests
    {
        //[Fact]
        //[Trait("Category", TraitCategory.UNIT_TEST)]
        //public void SerializerInvalidModel_AssertJsonSerializationException()
        //{
        //    var m = new InvalidModel();

        //    var result = Converter.Serialize(m);

        //    Assert.True(result.HasValidationErrors);
        //    Assert.Equal("Invalid URI: The format of the URI could not be determined.", result.ValidationErrors[1]);
        //}

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void DeserializerBasicModel_AssertValidDeserialization()
        {
            // Simple test model
            // Simple test model
            var m = new TestModel
            {
                Receiver = new EdiIdIdentification
                {
                    EdiId = "CONIZIVK"
                },
                Sender = new EdiAddress
                {
                    Name = "Fleetboard Logistics",
                    Street = "Am Alten Bahnhof",
                    HouseNumber = "8",
                    City = "Volkach"
                },
                TestReceivingPartner = new EdiIdIdentification
                {
                    EdiId = "FLELOVK"
                },
                TestShippingPartner = new EdiPartner
                {
                    PartnerId = "1234"
                },
                Network = new EdiNetwork
                {
                    NetworkId = "CL"
                },
                TestFileContent = new EdiFileContent
                {
                    FileName = "MyFuzzyFile.jpeg",
                    ContentType = "image/jpeg",
                    FileReference = new EdiFileReference
                    {
                        AbsoluteUri = "http://imnotexistend.org",
                        UriValidFrom = DateTime.Today,
                        UriValidTo = DateTime.Now.AddDays(5)
                    }
                }

            };

            var result = Converter.Serialize(m);
            Assert.False(result.HasValidationErrors);

            var dm = Converter.Deserialize<TestModel>(result.ToString());
        }
    }
}