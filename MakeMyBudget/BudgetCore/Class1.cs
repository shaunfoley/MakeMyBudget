using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BudgetCore
{
    public class Account
    {
        [JsonProperty("@name")]
        public string Name { get; set; }

        [JsonProperty("balance")]
        public string Balance { get; set; }
    }

    public class Accounts
    {
        [JsonProperty("account")]
        public List<Account> Account { get; set; }
    }

    public class Payment
    {
        [JsonProperty("@name")]
        public string Name { get; set; }

        [JsonProperty("frequency")]
        public string Frequency { get; set; }

        [JsonProperty("day")]
        public string Day { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }
    }

    public class Payments
    {
        [JsonProperty("payment")]
        public List<Payment> Payment { get; set; }
    }

    public class Data
    {
        [JsonProperty("@xmlns:xsi")]
        public string XmlnsXsi { get; set; }

        [JsonProperty("accounts")]
        public Accounts Accounts { get; set; }

        [JsonProperty("payments")]
        public Payments Payments { get; set; }
    }

    public class Root
    {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }


}
