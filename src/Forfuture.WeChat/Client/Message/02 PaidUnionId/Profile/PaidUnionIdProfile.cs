using Forfuture.WeChat.Configuration;

namespace Forfuture.WeChat.Client.Message._02_PaidUnionId.Profile
{
    public class PaidUnionIdProfile : AutoMapper.Profile
    {
        public PaidUnionIdProfile()
        {
            CreateMap<WeChatPaidUnionIdInput, PaidUnionIdRequest>(MemberList.None);
            CreateMap<WeChatConfig, PaidUnionIdRequest>(MemberList.None);
        }
    }
}