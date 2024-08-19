using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class RepresentativeResponseTest
{
    [Test]
    public void TestSerialization_1()
    {
        var inputJson =
            @"
        {
  ""id"": ""rep_7df2974a-4069-454c-912f-7e58ebe030fb"",
  ""name"": {
    ""firstName"": ""John"",
    ""middleName"": ""Quincy"",
    ""lastName"": ""Adams"",
    ""suffix"": ""Jr.""
  },
  ""phone"": {
    ""countryCode"": ""1"",
    ""number"": ""4155551234""
  },
  ""email"": ""john.doe@acme.com"",
  ""address"": {
    ""addressLine1"": ""123 Main St"",
    ""addressLine2"": ""Unit 1"",
    ""city"": ""San Francisco"",
    ""stateOrProvince"": ""CA"",
    ""postalCode"": ""94105"",
    ""country"": ""US""
  },
  ""birthDateProvided"": true,
  ""governmentIDProvided"": true,
  ""responsibilities"": {
    ""isOwner"": true,
    ""ownershipPercentage"": 40,
    ""isController"": true
  },
  ""createdOn"": ""2024-01-01T00:00:00Z"",
  ""updatedOn"": ""2024-01-01T00:00:00Z"",
  ""disabledOn"": null
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<RepresentativeResponse>(
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
  ""id"": ""rep_958c4ffb-dc06-494c-a0e0-1b4946c6bb0f"",
  ""name"": {
    ""firstName"": ""Jane"",
    ""lastName"": ""Smith""
  },
  ""phone"": {
    ""countryCode"": ""1"",
    ""number"": ""2075551234""
  },
  ""email"": ""jane.smith@acme.com"",
  ""address"": {
    ""addressLine1"": ""456 Main St"",
    ""city"": ""New York"",
    ""stateOrProvince"": ""NY"",
    ""postalCode"": ""10001"",
    ""country"": ""US""
  },
  ""birthDateProvided"": true,
  ""governmentIDProvided"": true,
  ""responsibilities"": {
    ""isOwner"": true,
    ""ownershipPercentage"": 40
  },
  ""createdOn"": ""2024-01-01T00:00:00Z"",
  ""updatedOn"": ""2024-01-01T00:00:00Z"",
  ""disabledOn"": null
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<RepresentativeResponse>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
