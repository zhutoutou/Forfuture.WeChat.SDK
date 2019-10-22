using Forfuture.WeChat.Configuration;

namespace Forfuture.WeChat.Client.Message._01_Login.Profile
{
    internal class LoginProfile:AutoMapper.Profile
    {
        public LoginProfile()
        {
            CreateMap<WeChatLoginInput, LoginRequest>(MemberList.None);
            CreateMap<WeChatConfig, LoginRequest>(MemberList.None);
        }

    }
}