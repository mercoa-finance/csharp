using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class AccelerationFundsResponseTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""entityId"": ""ent_8545a84e-a45f-41bf-bdf1-33b42a55812c"",
  ""paymentMethodId"": ""pm_4794d597-70dc-4fec-b6ec-c5988e759769"",
  ""availableBalance"": {
    ""amount"": 100,
    ""currency"": ""USD""
  },
  ""pendingBalance"": {
    ""amount"": 5,
    ""currency"": ""USD""
  }
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<AccelerationFundsResponse>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
