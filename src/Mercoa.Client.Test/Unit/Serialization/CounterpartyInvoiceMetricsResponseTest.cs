using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class CounterpartyInvoiceMetricsResponseTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""totalCount"": 17,
  ""totalAmount"": 1700,
  ""statuses"": [
    {
      ""status"": ""PAID"",
      ""totalCount"": 10,
      ""totalAmount"": 1000
    },
    {
      ""status"": ""PENDING"",
      ""totalCount"": 5,
      ""totalAmount"": 500
    },
    {
      ""status"": ""APPROVED"",
      ""totalCount"": 2,
      ""totalAmount"": 200
    }
  ]
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<CounterpartyInvoiceMetricsResponse>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
