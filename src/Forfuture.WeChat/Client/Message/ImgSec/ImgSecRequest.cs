using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Forfuture.WeChat.Client.Extensions;
using Forfuture.WeChat.Client.Message.Base;
using Forfuture.WeChat.Client.Message.Base.Attributes;

namespace Forfuture.WeChat.Client.Message.ImgSec
{
    internal class ImgSecRequest:WeChatRequest
    {
        /// <summary>
        /// 文件名
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 文件内容
        /// </summary>
        [Required]
        public byte[] File { get; set; }

        /// <summary>
        /// access_token
        /// </summary>
        [Required]
        [WeChatParameterName("access_token")]
        public string AccessToken { get; set; }

        public override void Prepare()
        {
            Method = HttpMethod.Post;
            Address = WeChatImgSecConstants.Address;

            // 验证参数
            CheckValidation();
            // 构建参数
            ConstructParam();
            

            var boundary = Guid.NewGuid().ToString();
            var boundaryParameter = new NameValueHeaderValue("boundary", boundary);
            MultipartFormDataContent formData = new MultipartFormDataContent(boundary);

            var imageContent = new ByteArrayContent(File);
            imageContent.Headers.ContentType = MediaTypeHeaderValue.Parse(WeChatImgSecConstants.ImageMediaType);
            formData.Add(imageContent, "\"media\"", $"\"{FileName}\"");
            formData.Headers.ContentType.Parameters.Clear();
            formData.Headers.ContentType.Parameters.Add(boundaryParameter);
            Content = formData;

            Address = $"{Address}?{Parameters.ToQueryString()}";
            RequestUri = new Uri(Address);
        }
    }
}