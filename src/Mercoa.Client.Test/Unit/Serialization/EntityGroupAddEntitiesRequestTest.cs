using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class EntityGroupAddEntitiesRequestTest
{
    [Test]
    public void TestSerialization_1()
    {
        var inputJson =
            @"
        {
  ""entityIds"": [
    ""ent_8545a84e-a45f-41bf-bdf1-33b42a55812c"",
    ""ent_21661ac1-a2a8-4465-a6c0-64474ba8181d""
  ]
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<EntityGroupAddEntitiesRequest>(
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
  ""entityIds"": [
    ""ent_8545a84e-a45f-41bf-bdf1-33b42a55812c"",
    ""ent_21661ac1-a2a8-4465-a6c0-64474ba8181d""
  ],
  ""copyUsersFrom"": true
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<EntityGroupAddEntitiesRequest>(
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
  ""entityIds"": [
    ""ent_8545a84e-a45f-41bf-bdf1-33b42a55812c"",
    ""ent_21661ac1-a2a8-4465-a6c0-64474ba8181d""
  ],
  ""copyUsersFrom"": false
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<EntityGroupAddEntitiesRequest>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }

    [Test]
    public void TestSerialization_4()
    {
        var inputJson =
            @"
        {
  ""entityIds"": [
    ""ent_8545a84e-a45f-41bf-bdf1-33b42a55812c"",
    ""ent_21661ac1-a2a8-4465-a6c0-64474ba8181d""
  ],
  ""copyUsersFrom"": ""ent_9e02a20e-7749-47de-8d8a-f8ff2859fa90""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<EntityGroupAddEntitiesRequest>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
