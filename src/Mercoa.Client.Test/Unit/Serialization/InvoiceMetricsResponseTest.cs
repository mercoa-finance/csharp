using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class InvoiceMetricsResponseTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""totalAmount"": 1000,
  ""totalCount"": 10,
  ""averageAmount"": 100,
  ""currency"": ""USD"",
  ""dates"": {
    ""2021-01-01T00:00:00Z"": {
      ""date"": ""2021-01-01T00:00:00Z"",
      ""totalAmount"": 100,
      ""totalCount"": 1,
      ""averageAmount"": 100,
      ""currency"": ""USD""
    },
    ""2021-01-02T00:00:00Z"": {
      ""date"": ""2021-01-02T00:00:00Z"",
      ""totalAmount"": 200,
      ""totalCount"": 2,
      ""averageAmount"": 100,
      ""currency"": ""USD""
    },
    ""2021-01-03T00:00:00Z"": {
      ""date"": ""2021-01-03T00:00:00Z"",
      ""totalAmount"": 400,
      ""totalCount"": 2,
      ""averageAmount"": 200,
      ""currency"": ""USD""
    }
  }
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<InvoiceMetricsResponse>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
