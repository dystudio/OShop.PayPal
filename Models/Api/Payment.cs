﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace OShop.PayPal.Models.Api {
    public class Payment {
        [JsonProperty("intent", Required = Required.Always)]
        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentIntent Intent { get; set; }

        [JsonProperty("payer", Required = Required.Always)]
        public Payer Payer { get; set; }
        
        [JsonProperty("transactions", Required = Required.Always)]
        public List<Transaction> Transactions { get; set; }
        
        [JsonProperty("redirect_urls", Required = Required.Always)]
        public RedirectUrls RedirectUrls { get; set; }
        
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime CreateTime { get; set; }

        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentState State { get; set; }

        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime UpdateTime { get; set; }

        [JsonProperty("experience_profile_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExperienceProfileId { get; set; }
    }

    public enum PaymentIntent {
        [JsonProperty("sale")]
        Sale,
        [JsonProperty("authorize")]
        Authorize,
        [JsonProperty("order")]
        Order
    }

    public enum PaymentState {
        [JsonProperty("created")]
        Created,
        [JsonProperty("approved")]
        Approved,
        [JsonProperty("failed")]
        Failed,
        [JsonProperty("pending")]
        Pending,
        [JsonProperty("canceled")]
        Canceled,
        [JsonProperty("expired")]
        Expired,
        [JsonProperty("in_progress")]
        InProgress
    }
}