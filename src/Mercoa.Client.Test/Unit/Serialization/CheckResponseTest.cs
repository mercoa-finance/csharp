using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class CheckResponseTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""id"": ""pm_5fde2f4a-facc-48ef-8f0d-6b7d087c7b18"",
  ""payToTheOrderOf"": ""John Doe"",
  ""addressLine1"": ""123 Main St"",
  ""addressLine2"": ""Apt 1"",
  ""city"": ""New York"",
  ""stateOrProvince"": ""NY"",
  ""postalCode"": ""10001"",
  ""country"": ""US"",
  ""isDefaultSource"": false,
  ""isDefaultDestination"": true,
  ""supportedCurrencies"": [
    ""USD""
  ],
  ""metadata"": {},
  ""frozen"": false,
  ""createdAt"": ""2021-01-01T00:00:00Z"",
  ""updatedAt"": ""2021-01-01T00:00:00Z""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<CheckResponse>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
