using MM.Model;
using MM.Model.Enums;
using System;
using System.Collections.Generic;

namespace MM.Business
{
    public interface ITutorMgr
    {
        /// <summary>
        /// 新建一个教师
        /// </summary>
        /// <returns>新建的教师对象</returns>
        Tutor CreateTutor(string name, string password, Gender gender,
            string phoneNumber, string address, bool isManager);

        /// <summary>
        /// 获取所有的教师对象
        /// </summary>
        IEnumerable<Tutor> GetAllTutor();

        /// <summary>
        /// 根据教师Id，获取教师对象
        /// </summary>
        Tutor GetTutor(Guid tutorId);

        /// <summary>
        /// 根据教师Id，删除教师对象
        /// </summary>
        void DeleteTutor(Guid tutorId);

        void ModifyTutor(Tutor tutor);
    }
}
