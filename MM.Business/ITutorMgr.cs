using MM.Model;
using MM.Model.Enums;
using System;
using System.Collections.Generic;

namespace MM.Business
{
    public interface ITutorMgr
    {
        /// <summary>
        /// 根据教师姓名，获取教师对象
        /// </summary>
        /// <returns></returns>
        Tutor GetByName(string name);

        /// <summary>
        /// 新建一个教师
        /// </summary>
        /// <returns>新建的教师对象</returns>
        Tutor Create(string name, Gender gender,
            string phoneNumber, string address, bool isManager);

        /// <summary>
        /// 获取所有的教师对象
        /// </summary>
        IEnumerable<Tutor> GetAll();

        /// <summary>
        /// 根据教师Id，获取教师对象
        /// </summary>
        Tutor GetById(Guid tutorId);

        /// <summary>
        /// 根据教师Id，删除教师对象
        /// </summary>
        void Delete(Guid tutorId);

        void Modify(Tutor tutor);

        /// <summary>
        /// 重置指定教师的密码
        /// </summary>
        /// <param name="tutorId">教师Id</param>
        void ResetTutorPassword(Guid tutorId);
    }
}
