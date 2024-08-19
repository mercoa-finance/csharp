using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class CustomPaymentMethodSchemaResponseTest
{
    [Test]
    public void TestSerialization_1()
    {
        var inputJson =
            @"
        {
  ""id"": ""cpms_4794d597-70dc-4fec-b6ec-c5988e759769"",
  ""name"": ""Wire"",
  ""isSource"": false,
  ""isDestination"": true,
  ""supportedCurrencies"": [
    ""USD"",
    ""EUR""
  ],
  ""fields"": [
    {
      ""name"": ""bankName"",
      ""displayName"": ""Bank Name"",
      ""type"": ""text"",
      ""optional"": false
    },
    {
      ""name"": ""recipientName"",
      ""displayName"": ""Recipient Name"",
      ""type"": ""text"",
      ""optional"": false
    },
    {
      ""name"": ""accountNumber"",
      ""displayName"": ""Account Number"",
      ""type"": ""usBankAccountNumber"",
      ""optional"": false,
      ""useAsAccountNumber"": true
    },
    {
      ""name"": ""routingNumber"",
      ""displayName"": ""Routing Number"",
      ""type"": ""usBankRoutingNumber"",
      ""optional"": false
    }
  ],
  ""createdAt"": ""2021-01-01T00:00:00Z"",
  ""updatedAt"": ""2021-01-01T00:00:00Z"",
  ""estimatedProcessingTime"": 0,
  ""maxAmount"": 100000,
  ""minAmount"": 1
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<CustomPaymentMethodSchemaResponse>(
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
  ""id"": ""cpms_14f78dcd-4614-426e-a37a-7af262431d41"",
  ""name"": ""Check"",
  ""isSource"": false,
  ""isDestination"": true,
  ""supportedCurrencies"": [
    ""USD""
  ],
  ""fields"": [
    {
      ""name"": ""payToTheOrderOf"",
      ""displayName"": ""Pay To The Order Of"",
      ""type"": ""text"",
      ""optional"": false
    },
    {
      ""name"": ""accountNumber"",
      ""displayName"": ""Account Number"",
      ""type"": ""usBankAccountNumber"",
      ""optional"": false,
      ""useAsAccountNumber"": true
    },
    {
      ""name"": ""routingNumber"",
      ""displayName"": ""Routing Number"",
      ""type"": ""usBankRoutingNumber"",
      ""optional"": false
    },
    {
      ""name"": ""address"",
      ""displayName"": ""Address"",
      ""type"": ""address"",
      ""optional"": false
    }
  ],
  ""createdAt"": ""2021-01-01T00:00:00Z"",
  ""updatedAt"": ""2021-01-01T00:00:00Z"",
  ""estimatedProcessingTime"": 7,
  ""maxAmount"": 50000,
  ""minAmount"": 1
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<CustomPaymentMethodSchemaResponse>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
