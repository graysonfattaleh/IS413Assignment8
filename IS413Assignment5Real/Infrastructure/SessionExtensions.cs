using System;
using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace IS413Assignment5Real.Infrastructure
{
    public static class SessionExtensions
    {
        // cart to json string and back again.
        public static void SetJson(this ISession session, string key, object value)
        {
            // puts data in a text file.
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T GetJson<T>(this ISession session, string key)
        {
            var sessionData = session.GetString(key);
            return sessionData == null ? default(T) : JsonSerializer.Deserialize<T>(sessionData);
        }

     }
}
