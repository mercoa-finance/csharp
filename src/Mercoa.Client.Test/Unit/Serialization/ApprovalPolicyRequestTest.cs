using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class ApprovalPolicyRequestTest
{
    [Test]
    public void TestSerialization_1()
    {
        var inputJson =
            @"
        {
  ""trigger"": [
    {
      ""type"": ""amount"",
      ""amount"": 100,
      ""currency"": ""USD""
    }
  ],
  ""rule"": {
    ""type"": ""approver"",
    ""numApprovers"": 2,
    ""identifierList"": {
      ""type"": ""rolesList"",
      ""value"": [
        ""Admin"",
        ""Controller""
      ]
    }
  },
  ""upstreamPolicyId"": ""root""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<ApprovalPolicyRequest>(
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
  ""trigger"": [],
  ""rule"": {
    ""type"": ""approver"",
    ""numApprovers"": 2,
    ""identifierList"": {
      ""type"": ""userList"",
      ""value"": [
        ""usr_8545a84e-a45f-41bf-bdf1-33b42a55812c"",
        ""usr_21661ac1-a2a8-4465-a6c0-64474ba8181d""
      ]
    }
  },
  ""upstreamPolicyId"": ""root""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<ApprovalPolicyRequest>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
