using System;
using Forfuture.WeChat.Cache;
using Forfuture.WeChat.Configuration;
using Forfuture.WeChat.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using StackExchange.Redis.Extensions.Core.Configuration;
using StackExchange.Redis.Extensions.Newtonsoft;

namespace Forfuture.WeChat.RedisCache
{
    public static class RedisCacheServiceCollectionExtension
    {
        /// <summary>
        /// 定义Redis缓存
        /// </summary>
        public static Action<IServiceCollection, IConfiguration, WeChatConfig> UseRedisCache =
            (services, configuration, config) =>
            {
                var redisSection = string.IsNullOrWhiteSpace(config.CacheConnectionStringSchemaSection)
                    ? throw new ArgumentNullException(nameof(config.CacheConnectionStringSchemaSection))
                    : string.Join(":", config.SchemaSection, config.CacheConnectionStringSchemaSection);
                string redisConfigJsonString = configuration.GetSection(redisSection).ToJObject().ToString();
                if (string.IsNullOrWhiteSpace(redisConfigJsonString))
                    throw new ArgumentNullException(nameof(redisConfigJsonString));
                var redisConfig = JsonConvert.DeserializeObject<RedisConfiguration>(redisConfigJsonString);
                services.AddStackExchangeRedisExtensions<NewtonsoftSerializer>(redisConfig);
                services.AddTransient(typeof(IWeChatCache), typeof(WeChatRedisCache));
            };
    }
}