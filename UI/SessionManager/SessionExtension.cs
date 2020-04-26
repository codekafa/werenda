using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Text;

namespace UI.SessionManager
{
    public static class SessionExtension
    {
        public static void SetObject(this ISession session, string key, object value)
        {
            string JsonValue = JsonConvert.SerializeObject(value);
            session.SetObject(key, JsonValue);
        }

        public static T GetObject<T>(this ISession session, string key) where T : class
        {
            var bytes = default(byte[]);
            session.TryGetValue(key, out bytes);
            var content = Encoding.UTF8.GetString(bytes);
            var result = JsonConvert.DeserializeObject<T>(content);
            return result;
        }
    }
}
