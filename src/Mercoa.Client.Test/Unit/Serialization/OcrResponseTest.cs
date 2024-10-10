using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions.Json;
using Mercoa.Client;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Mercoa.Client.Test;

[TestFixture]
public class OcrResponseTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""invoice"": {
    ""id"": ""inv_26e7b5d3-a739-4b23-9ad9-6aaa085f47a9"",
    ""status"": ""DRAFT"",
    ""amount"": 100,
    ""currency"": ""USD"",
    ""invoiceDate"": ""2021-01-01T00:00:00Z"",
    ""dueDate"": ""2021-01-31T00:00:00Z"",
    ""invoiceNumber"": ""INV-123"",
    ""noteToSelf"": ""For the month of January"",
    ""serviceStartDate"": ""2021-01-01T00:00:00Z"",
    ""serviceEndDate"": ""2021-01-31T00:00:00Z"",
    ""payerId"": ""ent_8545a84e-a45f-41bf-bdf1-33b42a55812c"",
    ""payer"": {
      ""id"": ""ent_8545a84e-a45f-41bf-bdf1-33b42a55812c"",
      ""foreignId"": ""MY-DB-ID-12345"",
      ""name"": ""Acme Inc."",
      ""email"": ""customer@acme.com"",
      ""acceptedTos"": true,
      ""status"": ""verified"",
      ""isCustomer"": true,
      ""isPayor"": true,
      ""isPayee"": false,
      ""isNetworkPayor"": false,
      ""isNetworkPayee"": false,
      ""accountType"": ""business"",
      ""updatedAt"": ""2024-01-02T00:00:00Z"",
      ""createdAt"": ""2024-01-01T00:00:00Z"",
      ""profile"": {
        ""business"": {
          ""email"": ""customer@acme.com"",
          ""legalBusinessName"": ""Acme Inc."",
          ""businessType"": ""llc"",
          ""phone"": {
            ""countryCode"": ""1"",
            ""number"": ""4155551234""
          },
          ""address"": {
            ""addressLine1"": ""123 Main St"",
            ""addressLine2"": ""Unit 1"",
            ""city"": ""San Francisco"",
            ""stateOrProvince"": ""CA"",
            ""postalCode"": ""94105"",
            ""country"": ""US""
          },
          ""taxIDProvided"": true,
          ""taxId"": {
            ""ein"": {
              ""number"": ""12-3456789""
            }
          },
          ""ownersProvided"": true
        }
      },
      ""accounts"": [
        {
          ""accountId"": ""85866843"",
          ""postalCode"": ""94105"",
          ""nameOnAccount"": ""John Doe""
        }
      ],
      ""paymentMethods"": [
        {
          ""id"": ""pm_4794d597-70dc-4fec-b6ec-c5988e759769"",
          ""type"": ""bankAccount"",
          ""accountName"": ""My Checking Account"",
          ""bankName"": ""Chase"",
          ""routingNumber"": ""12345678"",
          ""accountNumber"": ""99988767623"",
          ""accountType"": ""CHECKING"",
          ""status"": ""VERIFIED"",
          ""isDefaultSource"": true,
          ""isDefaultDestination"": true,
          ""supportedCurrencies"": [
            ""USD""
          ],
          ""metadata"": {},
          ""frozen"": false,
          ""createdAt"": ""2021-01-01T00:00:00Z"",
          ""updatedAt"": ""2021-01-01T00:00:00Z""
        }
      ],
      ""counterpartyType"": [
        ""ENTITY""
      ]
    },
    ""vendorId"": ""ent_21661ac1-a2a8-4465-a6c0-64474ba8181d"",
    ""vendor"": {
      ""id"": ""ent_21661ac1-a2a8-4465-a6c0-64474ba8181d"",
      ""foreignId"": ""MY-DB-ID-90909"",
      ""name"": ""Big Box Store"",
      ""email"": ""vendor@bigboxstore.com"",
      ""acceptedTos"": false,
      ""status"": ""unverified"",
      ""isCustomer"": false,
      ""isPayor"": false,
      ""isPayee"": true,
      ""isNetworkPayor"": false,
      ""isNetworkPayee"": false,
      ""accountType"": ""business"",
      ""updatedAt"": ""2024-01-02T00:00:00Z"",
      ""createdAt"": ""2024-01-01T00:00:00Z"",
      ""profile"": {
        ""business"": {
          ""email"": ""vendor@bigboxstore.com"",
          ""legalBusinessName"": ""Big Box Store"",
          ""businessType"": ""publicCorporation"",
          ""taxIDProvided"": false,
          ""ownersProvided"": false
        }
      },
      ""paymentMethods"": [
        {
          ""id"": ""pm_7610541f-4619-4033-8620-cfccfb811293"",
          ""type"": ""bankAccount"",
          ""accountName"": ""Vendor Checking Account"",
          ""bankName"": ""Chase"",
          ""routingNumber"": ""66554433"",
          ""accountNumber"": ""55934059697648"",
          ""accountType"": ""CHECKING"",
          ""status"": ""NEW"",
          ""isDefaultSource"": true,
          ""isDefaultDestination"": true,
          ""supportedCurrencies"": [
            ""USD""
          ],
          ""metadata"": {},
          ""frozen"": false,
          ""createdAt"": ""2021-01-01T00:00:00Z"",
          ""updatedAt"": ""2021-01-01T00:00:00Z""
        }
      ],
      ""counterpartyType"": [
        ""ENTITY""
      ]
    },
    ""paymentDestinationConfirmed"": false,
    ""hasDocuments"": true,
    ""hasSourceEmail"": true,
    ""comments"": [],
    ""lineItems"": [
      {
        ""id"": ""inli_26672f38-eb9a-48f1-a7a0-f1b855e38cd7"",
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
        ""glAccountId"": ""600394"",
        ""createdAt"": ""2021-01-01T00:00:00Z"",
        ""updatedAt"": ""2021-01-01T00:00:00Z""
      }
    ],
    ""approvers"": [],
    ""approvalPolicy"": [],
    ""metadata"": {},
    ""createdAt"": ""2021-01-01T00:00:00Z"",
    ""updatedAt"": ""2021-01-01T00:00:00Z""
  },
  ""vendor"": {
    ""id"": ""ent_21661ac1-a2a8-4465-a6c0-64474ba8181d"",
    ""foreignId"": ""MY-DB-ID-90909"",
    ""name"": ""Big Box Store"",
    ""email"": ""vendor@bigboxstore.com"",
    ""acceptedTos"": false,
    ""status"": ""unverified"",
    ""isCustomer"": false,
    ""isPayor"": false,
    ""isPayee"": true,
    ""isNetworkPayor"": false,
    ""isNetworkPayee"": false,
    ""accountType"": ""business"",
    ""updatedAt"": ""2024-01-02T00:00:00Z"",
    ""createdAt"": ""2024-01-01T00:00:00Z"",
    ""profile"": {
      ""business"": {
        ""email"": ""vendor@bigboxstore.com"",
        ""legalBusinessName"": ""Big Box Store"",
        ""businessType"": ""publicCorporation"",
        ""taxIDProvided"": false,
        ""ownersProvided"": false
      }
    },
    ""paymentMethods"": [
      {
        ""id"": ""pm_7610541f-4619-4033-8620-cfccfb811293"",
        ""type"": ""bankAccount"",
        ""accountName"": ""Vendor Checking Account"",
        ""bankName"": ""Chase"",
        ""routingNumber"": ""66554433"",
        ""accountNumber"": ""55934059697648"",
        ""accountType"": ""CHECKING"",
        ""status"": ""NEW"",
        ""isDefaultSource"": true,
        ""isDefaultDestination"": true,
        ""supportedCurrencies"": [
          ""USD""
        ],
        ""metadata"": {},
        ""frozen"": false,
        ""createdAt"": ""2021-01-01T00:00:00Z"",
        ""updatedAt"": ""2021-01-01T00:00:00Z""
      }
    ],
    ""counterpartyType"": [
      ""ENTITY""
    ]
  },
  ""check"": {
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
  },
  ""bankAccount"": {
    ""id"": ""pm_7610541f-4619-4033-8620-cfccfb811293"",
    ""accountName"": ""Vendor Checking Account"",
    ""bankName"": ""Chase"",
    ""routingNumber"": ""66554433"",
    ""accountNumber"": ""55934059697648"",
    ""accountType"": ""CHECKING"",
    ""status"": ""NEW"",
    ""isDefaultSource"": true,
    ""isDefaultDestination"": true,
    ""supportedCurrencies"": [
      ""USD""
    ],
    ""metadata"": {},
    ""frozen"": false,
    ""createdAt"": ""2021-01-01T00:00:00Z"",
    ""updatedAt"": ""2021-01-01T00:00:00Z""
  }
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<OcrResponse>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
