using MM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Business
{
    public interface IAdministrator
    {
        /// <summary>
        /// 获取系统中所有的教师
        /// </summary>
        /// <returns></returns>
        IEnumerable<Tutor> GetAllTutors();
    }
}
