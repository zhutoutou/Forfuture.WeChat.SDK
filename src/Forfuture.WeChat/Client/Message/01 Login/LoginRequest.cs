﻿using System.Net.Http;
using Forfuture.WeChat.Client.Message.Base;
using Forfuture.WeChat.Client.Message.Base.Attributes;

namespace Forfuture.WeChat.Client.Message._01_Login
{
    internal class LoginRequest: WeChatRequest
    {
        /// <summary>
        /// 登录Code
        /// </summary>
        [Required]
        [WeChatParameterName("js_code")]
        public string LoginCode { get; set; }

        /// <summary>
        /// 授权方式 默认值为authorization_code
        /// </summary>
        [Required]
        [WeChatParameterName("grant_type")]
        public string GrantType { get; set; }

        /// <summary>
        /// AppId
        /// </summary>
        [Required]
        [WeChatParameterName("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// AppSecret
        /// </summary>
        [Required]
        [WeChatParameterName("secret")]
        public string AppSecret { get; set; }

        public override void Prepare()
        {
            Method = HttpMethod.Get;
            Address = WeChatLoginConstants.Address;
            GrantType = WeChatLoginConstants.GrantType;
            base.Prepare();
        }

    }
}