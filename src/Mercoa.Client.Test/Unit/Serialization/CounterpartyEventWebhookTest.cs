using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class CounterpartyEventWebhookTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""eventType"": ""counterparty.onboarding.completed"",
  ""entityId"": ""ent_21661ac1-a2a8-4465-a6c0-64474ba8181d"",
  ""counterpartyId"": ""ent_8545a84e-a45f-41bf-bdf1-33b42a55812c""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<CounterpartyEventWebhook>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
