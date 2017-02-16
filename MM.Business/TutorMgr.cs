using Dayi.Data.Domain.Seedwork.Specification;
using MM.Model;
using MM.Model.Enums;
using MM.Model.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;

namespace MM.Business
{
    public class TutorMgr : IAuthenticator, ITutorMgr
    {
        private ITutorRepository _tutorRepository;

        public TutorMgr(ITutorRepository tutorRepository)
        {
            _tutorRepository = tutorRepository;
        }


        /// <summary>
        /// 根据用户名和口令对用户进行认证。
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">口令</param>
        /// <returns>用户通过认证，则返回true；否则返回false。</returns>
        bool IAuthenticator.Authenticate(string username, string password)
        {
            ISpecification<Tutor> spec = new DirectSpecification<Tutor>(o => o.Name == username);
            Tutor tutor = _tutorRepository.FindBySpecification(spec).FirstOrDefault();

            bool authenticated = false;
            if (tutor != null && tutor.Authenticate(password))
            {
                authenticated = true;
                IIdentity identity = new GenericIdentity(username);
                IPrincipal principal = new GenericPrincipal(identity, new string[] { "Administrator" });
                Thread.CurrentPrincipal = principal;
            }

            //将验证结果返回
            return authenticated;
        }

        /// <summary>
        /// 新建一个教师
        /// </summary>
        /// <returns>新建的教师对象</returns>
        Tutor ITutorMgr.CreateTutor(string name, string password, Gender gender, 
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
            tutor.SetPassword(password);

            tutor.GenerateNewIdentity();
            _tutorRepository.Add(tutor);
            _tutorRepository.UnitOfWork.Commit();

            return tutor;
        }

        /// <summary>
        /// 获取所有的教师对象
        /// </summary>
        IEnumerable<Tutor> ITutorMgr.GetAllTutor()
        {
            return _tutorRepository.GetAll();
        }

        /// <summary>
        /// 根据教师Id，获取教师对象
        /// </summary>
        Tutor ITutorMgr.GetTutor(Guid tutorId)
        {
            return _tutorRepository.GetByKey(tutorId);
        }

        /// <summary>
        /// 根据教师Id，删除教师对象
        /// </summary>
        void ITutorMgr.DeleteTutor(Guid tutorId)
        {
            Tutor tutor = _tutorRepository.GetByKey(tutorId);
            if (tutor == null)
                throw new ArgumentException(string.Format("教师【{0}】不存在！", tutorId));

            _tutorRepository.Remove(tutor);
            _tutorRepository.UnitOfWork.Commit();
        }
    }
}