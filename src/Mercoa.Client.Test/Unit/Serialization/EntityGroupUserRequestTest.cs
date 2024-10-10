using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class EntityGroupUserRequestTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""foreignId"": ""MY-DB-ID-12345"",
  ""email"": ""john.doe@acme.com"",
  ""name"": ""John Doe"",
  ""entities"": [
    {
      ""roles"": [
        ""admin"",
        ""approver""
      ],
      ""entityId"": ""ent_21661ac1-a2a8-4465-a6c0-64474ba8181d""
    },
    {
      ""roles"": [
        ""viewer""
      ],
      ""entityId"": ""ent_9e02a20e-7749-47de-8d8a-f8ff2859fa90""
    }
  ]
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<EntityGroupUserRequest>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
