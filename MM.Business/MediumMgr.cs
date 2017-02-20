using MM.Model;
using MM.Model.IRepositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MM.Business
{
    public class MediumMgr : IMediumMgr
    {
        IMediumRepository _mediumRepository;
        public MediumMgr(IMediumRepository mediumRepository)
        {
            _mediumRepository = mediumRepository;
        }

        /// <summary>
        /// 保存Medium对象
        /// </summary>
        void IMediumMgr.Save(Medium medium)
        {
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(medium,
                new ValidationContext(medium),
                results);
            if (!isValid)
                throw new ArgumentException("介质数据不合法！");

            if (medium.IsTransient())
            {
                medium.GenerateNewIdentity();
                _mediumRepository.Add(medium);
            }
            else
                _mediumRepository.Modify(medium);

            _mediumRepository.UnitOfWork.Commit();
        }

        /// <summary>
        /// 根据介质Id，删除介质对象
        /// </summary>
        void IMediumMgr.Delete(Guid mediumId)
        {
            var medium = _mediumRepository.GetByKey(mediumId);
            _mediumRepository.Remove(medium);

            _mediumRepository.UnitOfWork.Commit();
        }

        /// <summary>
        /// 获取系统中所有的介质
        /// </summary>
        IEnumerable<Medium> IMediumMgr.GetAll()
        {
            return _mediumRepository.GetAll().ToList();
        }

        /// <summary>
        /// 根据介质Id，获取介质对象
        /// </summary>
        /// <returns></returns>
        Medium IMediumMgr.GetById(Guid mediumId)
        {
            return _mediumRepository.GetByKey(mediumId);
        }
    }
}
