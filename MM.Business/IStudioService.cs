using MM.Model;
using MM.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Business
{
    public interface IStudioService
    {
        /// <summary>
        /// 销售产品
        /// </summary>
        /// <param name="tutorName">教师姓名</param>
        /// <param name="productId">产品Id</param>
        /// <param name="customerName">顾客姓名</param>
        /// <param name="phoneNumber">顾客手机号码</param>
        void Sell(string tutorName, Guid productId, string customerName, string phoneNumber);

        /// <summary>
        /// 销售产品
        /// </summary>
        /// <param name="tutorName">教师姓名</param>
        /// <param name="productId">产品Id</param>
        void Sell(string tutorName, Guid productId);

        /// <summary>
        /// 消费次卡产品
        /// </summary>
        /// <param name="tutorId">教师Id</param>
        /// <param name="timesCardMemberCardId">次卡产品Id</param>
        void TakeMemberProduct(Guid tutorId, Guid timesCardMemberCardId);

        /// <summary>
        /// 学习课程
        /// </summary>
        /// <param name="tutorId">教师Id</param>
        /// <param name="lectureMemberCardId">课程会员卡Id</param>
        /// <param name="lectureDescription">授课内容说明</param>
        void TakeMemberProduct(Guid tutorId, Guid lectureMemberCardId, string lectureDescription);

        /// <summary>
        /// 获取系统中的所有产品
        /// </summary>
        /// <returns></returns>
        IEnumerable<Product> GetAllProducts();
    }
}
