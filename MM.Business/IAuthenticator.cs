using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Business
{
    public interface IAuthenticator
    {
        /// <summary>
        /// 根据用户名和口令对用户进行认证。
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">口令</param>
        /// <returns>用户通过认证，则返回true；否则返回false。</returns>
        bool Authenticate(string username, string password);
    }
}
