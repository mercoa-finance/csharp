using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class EntityWebhookTest
{
    [Test]
    public void TestSerialization_1()
    {
        var inputJson =
            @"
        {
  ""eventType"": ""entity.created"",
  ""entity"": {
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
        ""ownersProvided"": true
      }
    }
  },
  ""user"": {
    ""id"": ""user_ec3aafc8-ea86-408a-a6c1-545497badbbb"",
    ""foreignId"": ""MY-DB-ID-12345"",
    ""email"": ""john.doe@acme.com"",
    ""name"": ""John Doe"",
    ""roles"": [
      ""admin"",
      ""approver""
    ],
    ""createdAt"": ""2024-01-01T00:00:00Z"",
    ""updatedAt"": ""2024-01-01T00:00:00Z""
  }
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<EntityWebhook>(
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
  ""eventType"": ""entity.updated"",
  ""entity"": {
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
        ""ownersProvided"": true
      }
    }
  },
  ""user"": {
    ""id"": ""user_ec3aafc8-ea86-408a-a6c1-545497badbbb"",
    ""foreignId"": ""MY-DB-ID-12345"",
    ""email"": ""john.doe@acme.com"",
    ""name"": ""John Doe"",
    ""roles"": [
      ""admin"",
      ""approver""
    ],
    ""createdAt"": ""2024-01-01T00:00:00Z"",
    ""updatedAt"": ""2024-01-01T00:00:00Z""
  }
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<EntityWebhook>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
