using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class ProfileRequestTest
{
    [Test]
    public void TestSerialization_1()
    {
        var inputJson =
            @"
        {
  ""business"": {
    ""email"": ""customer@acme.com"",
    ""legalBusinessName"": ""Acme Inc."",
    ""website"": ""http://www.acme.com"",
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
    ""taxId"": {
      ""ein"": {
        ""number"": ""12-3456789""
      }
    }
  }
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<ProfileRequest>(
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
  ""business"": {
    ""email"": ""vendor@bigboxstore.com"",
    ""legalBusinessName"": ""Big Box Store"",
    ""website"": ""http://www.bigboxstore.com"",
    ""businessType"": ""publicCorporation""
  }
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<ProfileRequest>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
