using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class EmailLogTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""id"": ""1234"",
  ""subject"": ""Invoice #1234"",
  ""from"": ""John Doe <john.doe@example.com>"",
  ""to"": ""Jane Doe <jane.doe@example.com>"",
  ""htmlBody"": ""<html><body><p>Hi Jane,</p><p>Please find attached the invoice for your recent purchase.</p><p>Thanks,</p><p>John</p></body></html>"",
  ""textBody"": ""Hi Jane,\n\nPlease find attached the invoice for your recent purchase.\n\nThanks,\nJohn"",
  ""createdAt"": ""2021-01-01T00:00:00Z""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<EmailLog>(inputJson, serializerOptions);

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
