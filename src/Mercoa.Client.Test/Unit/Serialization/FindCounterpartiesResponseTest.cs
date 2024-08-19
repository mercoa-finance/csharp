using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class FindCounterpartiesResponseTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""count"": 1,
  ""hasMore"": false,
  ""data"": [
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
      },
      ""paymentMethods"": [
        {
          ""id"": ""pm_7610541f-4619-4033-8620-cfccfb811293"",
          ""type"": ""bankAccount"",
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
      ],
      ""counterpartyType"": [
        ""ENTITY""
      ]
    }
  ]
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<FindCounterpartiesResponse>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
