using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class EntityAddPayeesRequestTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""payees"": [
    ""ent_21661ac1-a2a8-4465-a6c0-64474ba8181d""
  ],
  ""customizations"": [
    {
      ""counterpartyId"": ""ent_21661ac1-a2a8-4465-a6c0-64474ba8181d"",
      ""accounts"": [
        {
          ""accountId"": ""85866843"",
          ""postalCode"": ""94105"",
          ""nameOnAccount"": ""John Doe""
        }
      ]
    }
  ]
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<EntityAddPayeesRequest>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
