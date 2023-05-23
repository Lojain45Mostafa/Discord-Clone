using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;

namespace Messaging_System_WPF.Aspects
{
    public static class CachingAspect
    {
        private static readonly ObjectCache cache = MemoryCache.Default;

        public static T GetOrSet<T>(string cacheKey, Func<T> getItemCallback, TimeSpan expirationTime)
        {
            if (cache[cacheKey] is T cachedItem)
            {
                return cachedItem;
            }

            T item = getItemCallback();
            if (item != null)
            {
                cache.Set(cacheKey, item, DateTime.Now.Add(expirationTime));
            }

            return item;
        }
    }
}

