using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class BusinessProfileResponseTest
{
    [Test]
    public void TestSerialization_1()
    {
        var inputJson =
            @"
        {
  ""email"": ""customer@acme.com"",
  ""legalBusinessName"": ""Acme Inc."",
  ""businessType"": ""llc"",
  ""phone"": {
    ""countryCode"": ""1"",
    ""number"": ""4155551234""
  },
  ""address"": {
    ""addressLine1"": ""123 Main St"",
    ""addressLine2"": ""Unit 1"",
    ""city"": ""San Francisco"",
    ""stateOrProvince"": ""CA"",
    ""postalCode"": ""94105"",
    ""country"": ""US""
  },
  ""taxIDProvided"": true,
  ""taxId"": {
    ""ein"": {
      ""number"": ""12-3456789""
    }
  },
  ""ownersProvided"": true
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<BusinessProfileResponse>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }

    [Test]
    public void TestSerialization_2()
    {
        var inputJson =
            @"
        {
  ""email"": ""vendor@bigboxstore.com"",
  ""legalBusinessName"": ""Big Box Store"",
  ""businessType"": ""publicCorporation"",
  ""taxIDProvided"": false,
  ""ownersProvided"": false
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<BusinessProfileResponse>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
