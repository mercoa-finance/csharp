using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class NotificationResponseTest
{
    [Test]
    public void TestSerialization_1()
    {
        var inputJson =
            @"
        {
  ""id"": ""notif_7df2974a-4069-454c-912f-7e58ebe030fb"",
  ""invoiceId"": ""inv_26e7b5d3-a739-4b23-9ad9-6aaa085f47a9"",
  ""type"": ""INVOICE_APPROVAL_NEEDED"",
  ""status"": ""SENT"",
  ""createdAt"": ""2024-01-01T00:00:00Z""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<NotificationResponse>(
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
  ""id"": ""notif_958c4ffb-dc06-494c-a0e0-1b4946c6bb0f"",
  ""invoiceId"": ""inv_26e7b5d3-a739-4b23-9ad9-6aaa085f47a9"",
  ""type"": ""INVOICE_APPROVED"",
  ""status"": ""SENT"",
  ""createdAt"": ""2024-01-01T00:00:00Z""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<NotificationResponse>(
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
  ""id"": ""notif_958c4ffb-dc06-494c-a0e0-1b4946c6bb0f"",
  ""invoiceId"": ""inv_26e7b5d3-a739-4b23-9ad9-6aaa085f47a9"",
  ""type"": ""INVOICE_APPROVED"",
  ""status"": ""READ"",
  ""createdAt"": ""2024-01-01T00:00:00Z""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<NotificationResponse>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
