using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class NotificationPolicyResponseTest
{
    [Test]
    public void TestSerialization_1()
    {
        var inputJson =
            @"
        {
  ""disabled"": false,
  ""additionalRoles"": [
    ""admin"",
    ""approver""
  ],
  ""type"": ""INVOICE_APPROVAL_NEEDED"",
  ""notifyPayeeCounterparty"": true,
  ""notifyPayorCounterparty"": true
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<NotificationPolicyResponse>(
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
  ""disabled"": false,
  ""additionalRoles"": [
    ""admin"",
    ""bookkeeper""
  ],
  ""type"": ""INVOICE_APPROVED"",
  ""notifyPayeeCounterparty"": false,
  ""notifyPayorCounterparty"": true
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<NotificationPolicyResponse>(
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
  ""disabled"": true,
  ""additionalRoles"": [],
  ""type"": ""INVOICE_APPROVED"",
  ""notifyPayeeCounterparty"": true,
  ""notifyPayorCounterparty"": false
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<NotificationPolicyResponse>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
