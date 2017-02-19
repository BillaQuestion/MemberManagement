using MM.Model;
using MM.Model.Enums;
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

        /// <summary>
        /// 新建一个教师
        /// </summary>
        /// <returns>新建的教师对象</returns>
        Tutor CreateTutor(string name, Gender gender,
            string phoneNumber, string address, bool isManager);

        void ModifyTutor(Tutor tutor);

        void DeleteTutor(Guid tutorId);

        /// <summary>
        /// 重置指定教师的密码
        /// </summary>
        /// <param name="tutorId">教师Id</param>
        void ResetTutorPassword(Guid tutorId);
    }
}
