using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class EntityGroupUserEntityResponseTest
{
    [Test]
    public void TestSerialization_1()
    {
        var inputJson =
            @"
        {
  ""id"": ""user_ec3aafc8-ea86-408a-a6c1-545497badbbb"",
  ""roles"": [
    ""admin"",
    ""approver""
  ],
  ""entityId"": ""ent_21661ac1-a2a8-4465-a6c0-64474ba8181d""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<EntityGroupUserEntityResponse>(
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
  ""id"": ""user_3a3aafc8-ea86-408a-a6c1-545497badbbb"",
  ""roles"": [
    ""viewer""
  ],
  ""entityId"": ""ent_9e02a20e-7749-47de-8d8a-f8ff2859fa90""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<EntityGroupUserEntityResponse>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
