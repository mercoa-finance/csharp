using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class ApprovalSlotAssignmentTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""approvalSlotId"": ""inap_9bb311c9-7c15-4c9e-8148-63814e0abec6"",
  ""assignedUserId"": ""user_e24fc81c-c5ee-47e8-af42-4fe29d895506""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<ApprovalSlotAssignment>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
