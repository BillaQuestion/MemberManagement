using MM.Model;
using MM.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Business
{
    public interface IMemberMgr
    {
        /// <summary>
        /// 保存Member对象
        /// </summary>
        void Save(Member member);

        /// <summary>
        /// 根据手机号码查找会员
        /// </summary>
        /// <param name="phoneNumber">手机号码</param>
        /// <returns>会员对象</returns>
        Member FindByPhoneNumber(string phoneNumber);

        Member Get(string phoneNumber);
        IEnumerable<Member> GetAll();
        void Modify(Member member);
        void Remove(Guid memberId);
    }
}
