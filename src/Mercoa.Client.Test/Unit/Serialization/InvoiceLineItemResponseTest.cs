using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class InvoiceLineItemResponseTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""id"": ""inli_26672f38-eb9a-48f1-a7a0-f1b855e38cd7"",
  ""amount"": 100,
  ""currency"": ""USD"",
  ""description"": ""Product A"",
  ""name"": ""Product A"",
  ""quantity"": 1,
  ""unitPrice"": 100,
  ""category"": ""EXPENSE"",
  ""serviceStartDate"": ""2021-01-01T00:00:00Z"",
  ""serviceEndDate"": ""2021-01-31T00:00:00Z"",
  ""metadata"": {
    ""key1"": ""value1"",
    ""key2"": ""value2""
  },
  ""glAccountId"": ""600394"",
  ""createdAt"": ""2021-01-01T00:00:00Z"",
  ""updatedAt"": ""2021-01-01T00:00:00Z""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<InvoiceLineItemResponse>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
