﻿using AppStoreConnect.Models.Enums;
using AppStoreConnect.Models.Pocos.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AppStoreConnect.Models.Pocos.Profiles
{
    public class ProfileInformation
    {
        [JsonPropertyName("attributes")]
        public Profile? Profile { get; set; }
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        [JsonPropertyName("relationships")]
        public ProfileRelationships? Relationships { get; set; }
        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumMemberConverter))]
        public ResourceTypes? Type { get; set; }
        [JsonPropertyName("links")]
        public Dictionary<string, string>? Links { get; set; }
    }
}
