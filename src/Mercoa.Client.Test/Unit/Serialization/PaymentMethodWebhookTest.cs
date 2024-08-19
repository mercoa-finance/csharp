using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class PaymentMethodWebhookTest
{
    [Test]
    public void TestSerialization_1()
    {
        var inputJson =
            @"
        {
  ""eventType"": ""paymentMethod.created"",
  ""entityId"": ""ent_21661ac1-a2a8-4465-a6c0-64474ba8181d"",
  ""paymentMethod"": {
    ""id"": ""pm_4794d597-70dc-4fec-b6ec-c5988e759769"",
    ""type"": ""bankAccount"",
    ""accountName"": ""My Checking Account"",
    ""bankName"": ""Chase"",
    ""routingNumber"": ""12345678"",
    ""accountNumber"": ""99988767623"",
    ""accountType"": ""CHECKING"",
    ""status"": ""VERIFIED"",
    ""isDefaultSource"": true,
    ""isDefaultDestination"": true,
    ""supportedCurrencies"": [
      ""USD""
    ],
    ""metadata"": {},
    ""frozen"": false,
    ""createdAt"": ""2021-01-01T00:00:00Z"",
    ""updatedAt"": ""2021-01-01T00:00:00Z""
  },
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

        var deserializedObject = JsonSerializer.Deserialize<PaymentMethodWebhook>(
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
  ""eventType"": ""paymentMethod.updated"",
  ""entityId"": ""ent_21661ac1-a2a8-4465-a6c0-64474ba8181d"",
  ""paymentMethod"": {
    ""id"": ""pm_4794d597-70dc-4fec-b6ec-c5988e759769"",
    ""type"": ""bankAccount"",
    ""accountName"": ""My Checking Account"",
    ""bankName"": ""Chase"",
    ""routingNumber"": ""12345678"",
    ""accountNumber"": ""99988767623"",
    ""accountType"": ""CHECKING"",
    ""status"": ""VERIFIED"",
    ""isDefaultSource"": true,
    ""isDefaultDestination"": true,
    ""supportedCurrencies"": [
      ""USD""
    ],
    ""metadata"": {},
    ""frozen"": false,
    ""createdAt"": ""2021-01-01T00:00:00Z"",
    ""updatedAt"": ""2021-01-01T00:00:00Z""
  },
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

        var deserializedObject = JsonSerializer.Deserialize<PaymentMethodWebhook>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }

    [Test]
    public void TestSerialization_3()
    {
        var inputJson =
            @"
        {
  ""eventType"": ""paymentMethod.deleted"",
  ""entityId"": ""ent_21661ac1-a2a8-4465-a6c0-64474ba8181d"",
  ""paymentMethod"": {
    ""id"": ""pm_4794d597-70dc-4fec-b6ec-c5988e759769"",
    ""type"": ""bankAccount"",
    ""accountName"": ""My Checking Account"",
    ""bankName"": ""Chase"",
    ""routingNumber"": ""12345678"",
    ""accountNumber"": ""99988767623"",
    ""accountType"": ""CHECKING"",
    ""status"": ""VERIFIED"",
    ""isDefaultSource"": true,
    ""isDefaultDestination"": true,
    ""supportedCurrencies"": [
      ""USD""
    ],
    ""metadata"": {},
    ""frozen"": false,
    ""createdAt"": ""2021-01-01T00:00:00Z"",
    ""updatedAt"": ""2021-01-01T00:00:00Z""
  },
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

        var deserializedObject = JsonSerializer.Deserialize<PaymentMethodWebhook>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
