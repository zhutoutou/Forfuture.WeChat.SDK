﻿using System.Linq;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;

namespace Forfuture.WeChat.Extensions
{
    public static class ConfigurationSectionExtension
    {
        public static JObject ToJObject(this IConfigurationSection section)
        {
            JObject jObject = new JObject();
            foreach (var children in section.GetChildren().ToArray())
            {
                if (children.Value != null)
                {
                    jObject.Add(children.Key, children.Value);
                }
                else
                {
                    jObject.Add(children.ToJObject());
                }
            }

            return jObject;
        }
    }
}