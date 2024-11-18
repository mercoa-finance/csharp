using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class CalculateVendorCreditUsageResponseTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""remainingAmount"": 50,
  ""currency"": ""USD"",
  ""vendorCredits"": [
    {
      ""id"": ""vcr_c3f4c87d-794d-4543-9562-575cdddfc0d7"",
      ""totalAmount"": 100,
      ""remainingAmount"": 0,
      ""currency"": ""USD"",
      ""vendorId"": ""ent_21661ac1-a2a8-4465-a6c0-64474ba8181d"",
      ""payerId"": ""ent_8545a84e-a45f-41bf-bdf1-33b42a55812c"",
      ""creatorEntityId"": ""ent_21661ac1-a2a8-4465-a6c0-64474ba8181d"",
      ""note"": ""This is a note"",
      ""invoiceIds"": [
        ""in_26e7b5d3-a739-4b23-9ad9-6aaa085f47a9""
      ],
      ""createdAt"": ""2021-01-01T00:00:00Z"",
      ""updatedAt"": ""2021-01-01T00:00:00Z""
    }
  ]
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<CalculateVendorCreditUsageResponse>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
