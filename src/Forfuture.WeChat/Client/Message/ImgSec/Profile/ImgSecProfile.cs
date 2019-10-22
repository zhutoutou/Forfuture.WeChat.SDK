using Forfuture.WeChat.Configuration;

namespace Forfuture.WeChat.Client.Message.ImgSec.Profile
{
    internal class ImgSecProfile:AutoMapper.Profile
    {
        public ImgSecProfile()
        {
            CreateMap<WeChatImgSecInput, ImgSecRequest>(MemberList.None);
            CreateMap<WeChatConfig, ImgSecRequest>(MemberList.None);
        }
    }
}