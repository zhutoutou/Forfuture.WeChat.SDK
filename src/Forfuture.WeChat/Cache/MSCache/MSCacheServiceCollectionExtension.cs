using System;
using Forfuture.WeChat.Configuration;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Forfuture.WeChat.Cache.MSCache
{
    public static class MSCacheServiceCollectionExtension
    {
        /// <summary>
        /// 定义WeChat缓存
        /// </summary>

        public static Action<IServiceCollection, IConfiguration, WeChatConfig> UseMSCache =
            (services, configuration, config) =>
            {
                services.AddSingleton(new MemoryCache(new MemoryCacheOptions()));
                services.AddTransient(typeof(IWeChatCache), typeof(DefaultWeChatCache));
            };
    }
}