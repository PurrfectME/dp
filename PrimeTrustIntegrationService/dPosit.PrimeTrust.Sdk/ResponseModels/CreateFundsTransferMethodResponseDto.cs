using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.ResponseModels
{
    public class CreateFundsTransferMethodResponseDto
    {
        // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
        public class Address
        {
            [JsonPropertyName("links")]
            public Links Links { get; set; }
        }

        public class AmlChecks
        {
            [JsonPropertyName("links")]
            public Links Links { get; set; }
        }

        public class Attributes
        {
            [JsonPropertyName("ach-check-type")]
            public object AchCheckType { get; set; }

            [JsonPropertyName("bank-account-name")]
            public string BankAccountName { get; set; }

            [JsonPropertyName("bank-account-type")]
            public string BankAccountType { get; set; }

            [JsonPropertyName("bank-name")]
            public object BankName { get; set; }

            [JsonPropertyName("check-payee")]
            public object CheckPayee { get; set; }

            [JsonPropertyName("contact-email")]
            public string ContactEmail { get; set; }

            [JsonPropertyName("contact-name")]
            public string ContactName { get; set; }

            [JsonPropertyName("credit-card-name")]
            public object CreditCardName { get; set; }

            [JsonPropertyName("credit-card-postal-code")]
            public object CreditCardPostalCode { get; set; }

            [JsonPropertyName("credit-card-type")]
            public object CreditCardType { get; set; }

            [JsonPropertyName("credit-card-expiration-date")]
            public object CreditCardExpirationDate { get; set; }

            [JsonPropertyName("funds-transfer-type")]
            public string FundsTransferType { get; set; }

            [JsonPropertyName("further-credit-account-name")]
            public object FurtherCreditAccountName { get; set; }

            [JsonPropertyName("further-credit-account-number")]
            public object FurtherCreditAccountNumber { get; set; }

            [JsonPropertyName("iban")]
            public object Iban { get; set; }

            [JsonPropertyName("inactive")]
            public bool Inactive { get; set; }

            [JsonPropertyName("intermediary-bank-name")]
            public object IntermediaryBankName { get; set; }

            [JsonPropertyName("intermediary-bank-reference")]
            public object IntermediaryBankReference { get; set; }

            [JsonPropertyName("ip-address")]
            public object IpAddress { get; set; }

            [JsonPropertyName("label")]
            public object Label { get; set; }

            [JsonPropertyName("last-4")]
            public string Last4 { get; set; }

            [JsonPropertyName("routing-number")]
            public string RoutingNumber { get; set; }

            [JsonPropertyName("swift-code")]
            public object SwiftCode { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("routing-number-type")]
            public string RoutingNumberType { get; set; }
        }

        public class Bank
        {
            [JsonPropertyName("data")]
            public Data Data { get; set; }
        }

        public class BankAddress
        {
            [JsonPropertyName("data")]
            public object Data { get; set; }
        }

        public class BeneficiaryAddress
        {
            [JsonPropertyName("links")]
            public Links Links { get; set; }
        }

        public class Contact
        {
            [JsonPropertyName("links")]
            public Links Links { get; set; }
        }

        public class Contributions
        {
            [JsonPropertyName("links")]
            public Links Links { get; set; }
        }

        public class CreditCardResource
        {
            [JsonPropertyName("links")]
            public Links Links { get; set; }
        }

        public class Data
        {
            [JsonPropertyName("type")]
            public string Type { get; set; }

            [JsonPropertyName("id")]
            public string Id { get; set; }

            [JsonPropertyName("attributes")]
            public Attributes Attributes { get; set; }

            [JsonPropertyName("links")]
            public Links Links { get; set; }

            [JsonPropertyName("relationships")]
            public Relationships Relationships { get; set; }
        }

        public class Disbursements
        {
            [JsonPropertyName("links")]
            public Links Links { get; set; }
        }

        public class FundsTransfers
        {
            [JsonPropertyName("links")]
            public Links Links { get; set; }
        }

        public class Included
        {
            [JsonPropertyName("type")]
            public string Type { get; set; }

            [JsonPropertyName("id")]
            public string Id { get; set; }

            [JsonPropertyName("attributes")]
            public Attributes Attributes { get; set; }

            [JsonPropertyName("links")]
            public Links Links { get; set; }

            [JsonPropertyName("relationships")]
            public Relationships Relationships { get; set; }
        }

        public class IntermediaryBankAddress
        {
            [JsonPropertyName("data")]
            public object Data { get; set; }
        }

        public class Links
        {
            [JsonPropertyName("self")]
            public string Self { get; set; }

            [JsonPropertyName("related")]
            public string Related { get; set; }
        }

        public class MailingAddress
        {
            [JsonPropertyName("data")]
            public object Data { get; set; }
        }

        public class PlaidItem
        {
            [JsonPropertyName("data")]
            public object Data { get; set; }
        }

        public class Relationships
        {
            [JsonPropertyName("aml-checks")]
            public AmlChecks AmlChecks { get; set; }

            [JsonPropertyName("contributions")]
            public Contributions Contributions { get; set; }

            [JsonPropertyName("disbursements")]
            public Disbursements Disbursements { get; set; }

            [JsonPropertyName("funds-transfers")]
            public FundsTransfers FundsTransfers { get; set; }

            [JsonPropertyName("bank")]
            public Bank Bank { get; set; }

            [JsonPropertyName("contact")]
            public Contact Contact { get; set; }

            [JsonPropertyName("credit-card-resource")]
            public CreditCardResource CreditCardResource { get; set; }

            [JsonPropertyName("plaid-item")]
            public PlaidItem PlaidItem { get; set; }

            [JsonPropertyName("bank-address")]
            public BankAddress BankAddress { get; set; }

            [JsonPropertyName("beneficiary-address")]
            public BeneficiaryAddress BeneficiaryAddress { get; set; }

            [JsonPropertyName("intermediary-bank-address")]
            public IntermediaryBankAddress IntermediaryBankAddress { get; set; }

            [JsonPropertyName("mailing-address")]
            public MailingAddress MailingAddress { get; set; }

            [JsonPropertyName("address")]
            public Address Address { get; set; }
        }

        public class Root
        {
            [JsonPropertyName("data")]
            public Data Data { get; set; }

            [JsonPropertyName("included")]
            public List<Included> Included { get; set; }
        }
    }
}
