using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class EntityEventTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""webhookIds"": [
    ""webhook_12345""
  ],
  ""userId"": ""user_e24fc81c-c5ee-47e8-af42-4fe29d895506"",
  ""data"": {
    ""id"": ""ent_8545a84e-a45f-41bf-bdf1-33b42a55812c"",
    ""foreignId"": ""MY-DB-ID-12345"",
    ""name"": ""Acme Inc."",
    ""email"": ""customer@acme.com"",
    ""acceptedTos"": true,
    ""status"": ""verified"",
    ""isCustomer"": true,
    ""isPayor"": true,
    ""isPayee"": false,
    ""isNetworkPayor"": false,
    ""isNetworkPayee"": false,
    ""accountType"": ""business"",
    ""updatedAt"": ""2024-01-02T00:00:00Z"",
    ""createdAt"": ""2024-01-01T00:00:00Z"",
    ""profile"": {
      ""business"": {
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
    }
  },
  ""createdAt"": ""2024-01-01T00:00:00.000Z""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<EntityEvent>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
