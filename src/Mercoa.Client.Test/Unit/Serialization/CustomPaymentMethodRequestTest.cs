using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class CustomPaymentMethodRequestTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""foreignId"": ""DB_FOREIGN_ID"",
  ""accountName"": ""Vendor Wire Account"",
  ""accountNumber"": ""123456789"",
  ""schemaId"": ""cpms_4794d597-70dc-4fec-b6ec-c5988e759769"",
  ""data"": {
    ""bankName"": ""Chase"",
    ""recipientName"": ""John Doe"",
    ""routingNumber"": ""123456789"",
    ""accountNumber"": ""99988767623""
  }
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<CustomPaymentMethodRequest>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
