using Forfuture.WeChat.Configuration;

namespace Forfuture.WeChat.Client.Message.RefreshToken.Profile
{
    internal class RefreshTokenProfile:AutoMapper.Profile
    {
        public RefreshTokenProfile()
        {
            CreateMap<WeChatRefreshTokenInput, RefreshTokenRequest>(MemberList.None);
            CreateMap<WeChatConfig, RefreshTokenRequest>(MemberList.None);
        }
    }
}