using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using Forfuture.WeChat.Client.Message.Base;
using Forfuture.WeChat.Client.Message.Base.Attributes;

namespace Forfuture.WeChat.Client.Message.RefreshToken
{
    internal class RefreshTokenRequest:WeChatRequest
    {
        /// <summary>
        /// 授权方式 默认值为client_credential
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
            GrantType = WeChatRefreshTokenConstants.GrantType;
            Address = WeChatRefreshTokenConstants.Address;
            base.Prepare();
        }
    }
}