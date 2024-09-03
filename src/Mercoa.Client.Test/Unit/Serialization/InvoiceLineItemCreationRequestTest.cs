using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class InvoiceLineItemCreationRequestTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
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
  ""glAccountId"": ""600394""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<InvoiceLineItemCreationRequest>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
