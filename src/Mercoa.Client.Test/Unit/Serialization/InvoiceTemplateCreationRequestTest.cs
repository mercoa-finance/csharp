using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class InvoiceTemplateCreationRequestTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""status"": ""NEW"",
  ""amount"": 100,
  ""currency"": ""USD"",
  ""invoiceDate"": ""2021-01-01T00:00:00Z"",
  ""dueDate"": ""2021-01-13T00:00:00Z"",
  ""deductionDate"": ""2021-01-10T00:00:00Z"",
  ""paymentSchedule"": {
    ""type"": ""monthly"",
    ""repeatOnDay"": 10,
    ""ends"": ""2021-01-01T00:00:00Z""
  },
  ""invoiceNumber"": ""INV-123"",
  ""noteToSelf"": ""Monthly recurring payment"",
  ""payerId"": ""ent_8545a84e-a45f-41bf-bdf1-33b42a55812c"",
  ""paymentSourceId"": ""pm_4794d597-70dc-4fec-b6ec-c5988e759769"",
  ""vendorId"": ""ent_21661ac1-a2a8-4465-a6c0-64474ba8181d"",
  ""paymentDestinationId"": ""pm_5fde2f4a-facc-48ef-8f0d-6b7d087c7b18"",
  ""paymentDestinationOptions"": {
    ""type"": ""check"",
    ""delivery"": ""MAIL"",
    ""printDescription"": true
  },
  ""lineItems"": [
    {
      ""amount"": 100,
      ""currency"": ""USD"",
      ""description"": ""Product A"",
      ""name"": ""Product A"",
      ""quantity"": 1,
      ""unitPrice"": 100,
      ""category"": ""EXPENSE"",
      ""serviceStartDate"": ""2021-01-01T00:00:00Z"",
      ""serviceEndDate"": ""2021-01-31T00:00:00Z"",
      ""metadata"": {
        ""key1"": ""value1"",
        ""key2"": ""value2""
      },
      ""glAccountId"": ""600394""
    }
  ],
  ""creatorEntityId"": ""ent_8545a84e-a45f-41bf-bdf1-33b42a55812c"",
  ""creatorUserId"": ""user_e24fc81c-c5ee-47e8-af42-4fe29d895506""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<InvoiceTemplateCreationRequest>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
