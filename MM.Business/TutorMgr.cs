﻿using Dayi.Data.Domain.Seedwork.Specification;
using MM.Model;
using MM.Model.Enums;
using MM.Model.IRepositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;

namespace MM.Business
{
    public class TutorMgr : ITutorMgr
    {
        private ITutorRepository _tutorRepository;

        public TutorMgr(ITutorRepository tutorRepository)
        {
            _tutorRepository = tutorRepository;
        }


        /// <summary>
        /// 新建一个教师
        /// </summary>
        /// <returns>新建的教师对象</returns>
        [PrincipalPermission(SecurityAction.Demand, Role = "Administrator")]
        Tutor ITutorMgr.Create(string name, Gender gender,
            string phoneNumber, string address, bool isManager)
        {
            Tutor tutor = new Tutor()
            {
                Name = name,
                Gender = gender,
                PhoneNumber = phoneNumber,
                Address = address,
                IsManager = isManager
            };
            Validate(tutor);

            tutor.SetPassword("password");

            tutor.GenerateNewIdentity();
            _tutorRepository.Add(tutor);
            _tutorRepository.UnitOfWork.Commit();

            return tutor;
        }

        /// <summary>
        /// 验证数据合法性
        /// </summary>
        private void Validate(Tutor tutor)
        {
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(tutor,
                new ValidationContext(tutor),
                results);
            if (!isValid)
                throw new ArgumentException("教师数据不合法！");
        }

        /// <summary>
        /// 获取所有的教师对象
        /// </summary>
        IEnumerable<Tutor> ITutorMgr.GetAll()
        {
            return _tutorRepository.GetAll();
        }

        /// <summary>
        /// 根据教师Id，获取教师对象
        /// </summary>
        Tutor ITutorMgr.GetById(Guid tutorId)
        {
            return _tutorRepository.GetByKey(tutorId);
        }

        /// <summary>
        /// 根据教师姓名，获取教师对象
        /// </summary>
        /// <returns></returns>
        Tutor ITutorMgr.GetByName(string name)
        {
            ISpecification<Tutor> spec = new DirectSpecification<Tutor>(o => o.Name == name);
            return _tutorRepository.FindBySpecification(spec).FirstOrDefault();
        }

        /// <summary>
        /// 根据教师Id，删除教师对象
        /// </summary>
        [PrincipalPermission(SecurityAction.Demand, Role = "Administrator")]
        void ITutorMgr.Delete(Guid tutorId)
        {
            Tutor tutor = _tutorRepository.GetByKey(tutorId);
            if (tutor == null)
                throw new ArgumentException(string.Format("教师【{0}】不存在！", tutorId));

            _tutorRepository.Remove(tutor);
            _tutorRepository.UnitOfWork.Commit();
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "Administrator")]
        void ITutorMgr.Modify(Tutor tutor)
        {
            Validate(tutor);
            _tutorRepository.Modify(tutor);
            _tutorRepository.UnitOfWork.Commit();
        }

        /// <summary>
        /// 重置指定教师的密码
        /// </summary>
        /// <param name="tutorId">教师Id</param>
        [PrincipalPermission(SecurityAction.Demand, Role = "Administrator")]
        void ITutorMgr.ResetTutorPassword(Guid tutorId)
        {
            Tutor tutor = (this as ITutorMgr).GetById(tutorId);
            if (tutor == null)
                throw new ArgumentException(string.Format("教师【{0}】不存在！", tutorId));

            tutor.SetPassword("password");
            (this as ITutorMgr).Modify(tutor);
        }
    }
}