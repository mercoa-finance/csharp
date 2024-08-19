using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class BankAccountResponseTest
{
    [Test]
    public void TestSerialization_1()
    {
        var inputJson =
            @"
        {
  ""id"": ""pm_4794d597-70dc-4fec-b6ec-c5988e759769"",
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
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<BankAccountResponse>(
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
  ""id"": ""pm_7610541f-4619-4033-8620-cfccfb811293"",
  ""accountName"": ""Vendor Checking Account"",
  ""bankName"": ""Chase"",
  ""routingNumber"": ""66554433"",
  ""accountNumber"": ""55934059697648"",
  ""accountType"": ""CHECKING"",
  ""status"": ""NEW"",
  ""isDefaultSource"": true,
  ""isDefaultDestination"": true,
  ""supportedCurrencies"": [
    ""USD""
  ],
  ""metadata"": {},
  ""frozen"": false,
  ""createdAt"": ""2021-01-01T00:00:00Z"",
  ""updatedAt"": ""2021-01-01T00:00:00Z""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<BankAccountResponse>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
