using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class CommentResponseTest
{
    [Test]
    public void TestSerialization_1()
    {
        var inputJson =
            @"
        {
  ""id"": ""ic_b3525b66-da94-4525-9f31-426bcf657128"",
  ""text"": ""This is a comment"",
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
  },
  ""createdAt"": ""2021-01-01T00:00:00Z"",
  ""updatedAt"": ""2021-01-01T00:00:00Z""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<CommentResponse>(
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
  ""id"": ""ic_b3525b66-da94-4525-9f31-426bcf657128"",
  ""text"": ""This is an approval comment"",
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
  },
  ""associatedApprovalAction"": {
    ""userId"": ""user_e24fc81c-c5ee-47e8-af42-4fe29d895506"",
    ""action"": ""APPROVE""
  },
  ""createdAt"": ""2021-01-01T00:00:00Z"",
  ""updatedAt"": ""2021-01-01T00:00:00Z""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<CommentResponse>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
