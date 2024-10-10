using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class EntityGroupResponseTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""id"": ""entg_a3582b70-fd04-4888-9185-a640ae9048be"",
  ""foreignId"": ""your-group-id"",
  ""name"": ""AcmeConglomerate"",
  ""emailToName"": ""acmegroup"",
  ""metadata"": {
    ""key1"": ""value1""
  },
  ""entities"": [
    {
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
    {
      ""id"": ""ent_21661ac1-a2a8-4465-a6c0-64474ba8181d"",
      ""foreignId"": ""MY-DB-ID-90909"",
      ""name"": ""Big Box Store"",
      ""email"": ""vendor@bigboxstore.com"",
      ""acceptedTos"": false,
      ""status"": ""unverified"",
      ""isCustomer"": false,
      ""isPayor"": false,
      ""isPayee"": true,
      ""isNetworkPayor"": false,
      ""isNetworkPayee"": false,
      ""accountType"": ""business"",
      ""updatedAt"": ""2024-01-02T00:00:00Z"",
      ""createdAt"": ""2024-01-01T00:00:00Z"",
      ""profile"": {
        ""business"": {
          ""email"": ""vendor@bigboxstore.com"",
          ""legalBusinessName"": ""Big Box Store"",
          ""businessType"": ""publicCorporation"",
          ""taxIDProvided"": false,
          ""ownersProvided"": false
        }
      }
    }
  ]
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<EntityGroupResponse>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
