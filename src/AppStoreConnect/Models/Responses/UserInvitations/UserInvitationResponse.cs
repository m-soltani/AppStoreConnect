﻿using AppStoreConnect.Models.Pocos.Apps;
using AppStoreConnect.Models.Pocos.UserInvitations;
using AppStoreConnect.Models.Responses.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AppStoreConnect.Models.Responses.UserInvitations
{
    public class UserInvitationResponse : ApplicationResponse
    {
        [JsonPropertyName("data")]
        public UserInvitationInformation? UserInvitationInformation { get; set; }
        [JsonPropertyName("links")]
        public Dictionary<string, string>? Links { get; set; }
        [JsonPropertyName("included")]
        public List<App>? IncludedApps { get; set; }
    }
}
