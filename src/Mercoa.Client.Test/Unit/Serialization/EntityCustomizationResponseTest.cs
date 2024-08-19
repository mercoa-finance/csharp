using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class EntityCustomizationResponseTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""metadata"": [
    {
      ""key"": ""my_custom_field"",
      ""disabled"": true
    },
    {
      ""key"": ""my_other_field"",
      ""disabled"": false
    }
  ],
  ""paymentSource"": [
    {
      ""type"": ""bankAccount"",
      ""disabled"": true
    },
    {
      ""type"": ""custom"",
      ""schemaId"": ""cpms_7df2974a-4069-454c-912f-7e58ebe030fb"",
      ""disabled"": true
    }
  ],
  ""backupDisbursement"": [
    {
      ""type"": ""check"",
      ""disabled"": true
    }
  ],
  ""paymentDestination"": [
    {
      ""type"": ""bankAccount"",
      ""disabled"": true
    },
    {
      ""type"": ""check"",
      ""disabled"": true
    }
  ]
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<EntityCustomizationResponse>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
