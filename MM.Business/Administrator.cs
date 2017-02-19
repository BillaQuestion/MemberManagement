using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MM.Model;
using MM.Model.IRepositories;
using Dayi.Data.Domain.Seedwork.Specification;
using MM.Business.Exceptions;
using System.Security.Permissions;
using MM.Model.Enums;

namespace MM.Business
{
    public class Administrator : IAdministrator
    {
        ITutorMgr _tutorMgr;
        IProductMgr _productMgr;
        IMediumMgr _mediumMgr;

        public Administrator(ITutorMgr tutorMgr,
            IProductMgr productMgr,
            IMediumMgr mediumMgr)
        {
            _tutorMgr = tutorMgr;
            _productMgr = productMgr;
            _mediumMgr = mediumMgr;
        }

        public void AddProduct(Product product)
        {
            _productMgr.AddProduct(product);
        }

        public void SetProduct(Guid productId, Product newProduct)
        {
            var product = _productMgr.GetById(productId);
            product.Name = newProduct.Name;
            product.Price = newProduct.Price;
            if(newProduct is MemberProduct)
            {
                var np = newProduct as MemberProduct;
                var mp = product as MemberProduct;
                mp.Count = np.Count;
                if(newProduct is Lecture)
                {
                    var lnp = newProduct as Lecture;
                    var lp = product as Lecture;
                    lp.Description = lnp.Description;
                }
                else
                {
                    var tnp = newProduct as TimesCard;
                    var tp = product as TimesCard;
                    tp.Medium = tnp.Medium;
                }
            }
            _productMgr.Modify(product);
        }

        public void RemoveProduct(Guid productId)
        {
            var product = _productMgr.GetById(productId);
            _productMgr.Remove(product);
        }

        #region Tutor

        /// <summary>
        /// 获取系统中所有的教师
        /// </summary>
        /// <returns></returns>
        [PrincipalPermission(SecurityAction.Demand, Role = "Administrator")]
        IEnumerable<Tutor> IAdministrator.GetAllTutors()
        {
            return _tutorMgr.GetAll();
        }
        /// <summary>
        /// 新建一个教师
        /// </summary>
        /// <returns>新建的教师对象</returns>
        Tutor IAdministrator.CreateTutor(string name, Gender gender,
            string phoneNumber, string address, bool isManager)
        {
            return _tutorMgr.Create(name, gender, phoneNumber, address, isManager);
        }

        void IAdministrator.ModifyTutor(Tutor tutor)
        {
            _tutorMgr.Modify(tutor);
        }

        void IAdministrator.DeleteTutor(Guid tutorId)
        {
            _tutorMgr.Delete(tutorId);
        }

        /// <summary>
        /// 重置指定教师的密码
        /// </summary>
        /// <param name="tutorId">教师Id</param>
        void IAdministrator.ResetTutorPassword(Guid tutorId)
        {
            _tutorMgr.ResetTutorPassword(tutorId);
        }

        #endregion
    }
}