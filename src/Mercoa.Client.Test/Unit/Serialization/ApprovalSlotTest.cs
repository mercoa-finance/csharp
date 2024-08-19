using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class ApprovalSlotTest
{
    [Test]
    public void TestSerialization_1()
    {
        var inputJson =
            @"
        {
  ""approvalPolicyId"": ""apvl_5ce50275-1789-42ea-bc60-bb7e6d03635c"",
  ""approvalSlotId"": ""inap_9bb311c9-7c15-4c9e-8148-63814e0abec6"",
  ""assignedUserId"": ""user_e24fc81c-c5ee-47e8-af42-4fe29d895506"",
  ""action"": ""APPROVE"",
  ""eligibleUserIds"": [
    ""user_e24fc81c-c5ee-47e8-af42-4fe29d895506""
  ],
  ""eligibleRoles"": [
    ""admin""
  ],
  ""date"": ""2021-01-01T00:00:00Z""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<ApprovalSlot>(
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
  ""approvalPolicyId"": ""apvl_5ce50275-1789-42ea-bc60-bb7e6d03635c"",
  ""approvalSlotId"": ""inap_9bb311c9-7c15-4c9e-8148-63814e0abec6"",
  ""assignedUserId"": ""user_e24fc81c-c5ee-47e8-af42-4fe29d895506"",
  ""action"": ""REJECT"",
  ""eligibleUserIds"": [
    ""user_e24fc81c-c5ee-47e8-af42-4fe29d895506""
  ],
  ""eligibleRoles"": [
    ""admin""
  ],
  ""date"": ""2021-01-01T00:00:00Z""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<ApprovalSlot>(
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
  ""approvalPolicyId"": ""apvl_5ce50275-1789-42ea-bc60-bb7e6d03635c"",
  ""approvalSlotId"": ""inap_9bb311c9-7c15-4c9e-8148-63814e0abec6"",
  ""assignedUserId"": ""user_e24fc81c-c5ee-47e8-af42-4fe29d895506"",
  ""action"": ""NONE"",
  ""eligibleUserIds"": [
    ""user_e24fc81c-c5ee-47e8-af42-4fe29d895506""
  ],
  ""eligibleRoles"": [
    ""admin""
  ],
  ""date"": ""2021-01-01T00:00:00Z""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<ApprovalSlot>(
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
  ""approvalPolicyId"": ""apvl_5ce50275-1789-42ea-bc60-bb7e6d03635c"",
  ""approvalSlotId"": ""inap_9bb311c9-7c15-4c9e-8148-63814e0abec6"",
  ""action"": ""NONE"",
  ""eligibleUserIds"": [
    ""user_e24fc81c-c5ee-47e8-af42-4fe29d895506""
  ],
  ""eligibleRoles"": [
    ""admin""
  ],
  ""date"": ""2021-01-01T00:00:00Z""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<ApprovalSlot>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
