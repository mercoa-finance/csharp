using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class InvoiceCreationWithEntityRequestTest
{
    [Test]
    public void TestSerialization_1()
    {
        var inputJson =
            @"
        {
  ""status"": ""NEW"",
  ""amount"": 100,
  ""currency"": ""USD"",
  ""invoiceDate"": ""2021-01-01T00:00:00Z"",
  ""dueDate"": ""2021-01-31T00:00:00Z"",
  ""invoiceNumber"": ""INV-123"",
  ""noteToSelf"": ""For the month of January"",
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

        var deserializedObject = JsonSerializer.Deserialize<InvoiceCreationWithEntityRequest>(
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
  ""status"": ""DRAFT"",
  ""payerId"": ""ent_8545a84e-a45f-41bf-bdf1-33b42a55812c"",
  ""creatorEntityId"": ""ent_8545a84e-a45f-41bf-bdf1-33b42a55812c""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<InvoiceCreationWithEntityRequest>(
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
  ""status"": ""NEW"",
  ""payerId"": ""ent_8545a84e-a45f-41bf-bdf1-33b42a55812c"",
  ""creatorEntityId"": ""ent_8545a84e-a45f-41bf-bdf1-33b42a55812c"",
  ""vendorId"": ""ent_21661ac1-a2a8-4465-a6c0-64474ba8181d"",
  ""currency"": ""USD"",
  ""amount"": 100,
  ""invoiceDate"": ""2021-01-01T00:00:00Z"",
  ""dueDate"": ""2021-01-31T00:00:00Z"",
  ""paymentSourceId"": ""pm_4794d597-70dc-4fec-b6ec-c5988e759769""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<InvoiceCreationWithEntityRequest>(
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
  ""status"": ""SCHEDULED"",
  ""payerId"": ""ent_8545a84e-a45f-41bf-bdf1-33b42a55812c"",
  ""creatorEntityId"": ""ent_8545a84e-a45f-41bf-bdf1-33b42a55812c"",
  ""vendorId"": ""ent_21661ac1-a2a8-4465-a6c0-64474ba8181d"",
  ""currency"": ""USD"",
  ""amount"": 100,
  ""invoiceDate"": ""2021-01-01T00:00:00Z"",
  ""dueDate"": ""2021-01-31T00:00:00Z"",
  ""paymentSourceId"": ""pm_4794d597-70dc-4fec-b6ec-c5988e759769"",
  ""paymentDestinationId"": ""pm_5fde2f4a-facc-48ef-8f0d-6b7d087c7b18"",
  ""deductionDate"": ""2021-01-29T00:00:00Z""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<InvoiceCreationWithEntityRequest>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
