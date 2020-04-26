using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Panel.SessionManager
{
    public interface ISessionManager
    {
        T GetObject<T>(string key) where T:class;

        void SetObject(string key, object value);

        void DeleteObject(string key);
    }
}
