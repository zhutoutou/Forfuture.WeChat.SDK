﻿using System.Collections.Generic;

namespace Forfuture.WeChat.Extensions
{
    public static class CollectionExtension
    {
        public static bool IsNullOrEmpty<T>(this ICollection<T> source)
        {
            return source == null || source.Count <= 0;
        }
    }
}