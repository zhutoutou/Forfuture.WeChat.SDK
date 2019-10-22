using System.Threading;
using System.Threading.Tasks;
using Forfuture.WeChat.Client.Message._01_Login;
using Forfuture.WeChat.Client.Message.Base;
using Forfuture.WeChat.Client.Message.ImgSec;
using Forfuture.WeChat.Client.Message.RefreshToken;

namespace Forfuture.WeChat.Client
{
    public interface IWeChatClient
    {
        /// <summary>
        ///  小程序Token获取
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<ProtocolResponse<WeChatRefreshTokenResponse>> RequestRefreshTokenAsync(WeChatRefreshTokenInput input,
            CancellationToken cancellationToken = default);


        /// <summary>
        /// 小程序登录
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<ProtocolResponse<WeChatLoginResponse>> RequestLoginAsync(WeChatLoginInput input,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// 图片鉴定
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<ProtocolResponse<WeChatImgSecResponse>> RequestImgSecAsync(WeChatImgSecInput input,
            CancellationToken cancellationToken = default);


    }
}