using Microsoft.AspNetCore.Http;

namespace Panel.SessionManager
{
    public class SessionManager : ISessionManager
    {

        IHttpContextAccessor _httpContext;

        public SessionManager(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }

        public void DeleteObject(string key)
        {
            _httpContext.HttpContext.Session.Remove(key);
        }

        public T GetObject<T>(string key) where T : class
        {
            return _httpContext.HttpContext.Session.GetObject<T>(key);
        }

        public void SetObject(string key, object value)
        {
            _httpContext.HttpContext.Session.SetObject(key, value);
        }
    }
}
