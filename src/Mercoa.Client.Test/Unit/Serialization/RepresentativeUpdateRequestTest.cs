using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class RepresentativeUpdateRequestTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
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
  ""birthDate"": {
    ""day"": ""1"",
    ""month"": ""1"",
    ""year"": ""1980""
  },
  ""governmentID"": {
    ""ssn"": ""123-45-6789""
  },
  ""responsibilities"": {
    ""isOwner"": true,
    ""ownershipPercentage"": 40,
    ""isController"": true
  }
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<RepresentativeUpdateRequest>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
