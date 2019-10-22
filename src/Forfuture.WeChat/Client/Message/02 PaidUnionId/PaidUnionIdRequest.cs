using System.Net.Http;
using Forfuture.WeChat.Client.Message.Base;
using Forfuture.WeChat.Client.Message.Base.Attributes;

namespace Forfuture.WeChat.Client.Message._02_PaidUnionId
{
    public class PaidUnionIdRequest:WeChatRequest
    {
        /// <summary>
        /// access_token
        /// </summary>
        [Required]
        [WeChatParameterName("access_token")]
        public string AccessToken { get; set; }

        public override void Prepare()
        {
            Method = HttpMethod.Get;
            base.Prepare();
        }
    }
}