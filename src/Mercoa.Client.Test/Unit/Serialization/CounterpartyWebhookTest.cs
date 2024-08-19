using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class CounterpartyWebhookTest
{
    [Test]
    public void TestSerialization_1()
    {
        var inputJson =
            @"
        {
  ""eventType"": ""counterparty.added"",
  ""payeeId"": [
    ""ent_21661ac1-a2a8-4465-a6c0-64474ba8181d""
  ],
  ""payorId"": [
    ""ent_8545a84e-a45f-41bf-bdf1-33b42a55812c""
  ],
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

        var deserializedObject = JsonSerializer.Deserialize<CounterpartyWebhook>(
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
  ""eventType"": ""counterparty.hidden"",
  ""payeeId"": [
    ""ent_21661ac1-a2a8-4465-a6c0-64474ba8181d""
  ],
  ""payorId"": [
    ""ent_8545a84e-a45f-41bf-bdf1-33b42a55812c""
  ],
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

        var deserializedObject = JsonSerializer.Deserialize<CounterpartyWebhook>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
