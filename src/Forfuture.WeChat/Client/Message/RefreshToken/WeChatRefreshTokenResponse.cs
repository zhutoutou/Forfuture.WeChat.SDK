﻿using Forfuture.WeChat.Client.Message.Base;

namespace Forfuture.WeChat.Client.Message.RefreshToken
{
    public class WeChatRefreshTokenResponse:WeChatResponse
    {
        /// <summary>
        /// access_token
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
    }
}