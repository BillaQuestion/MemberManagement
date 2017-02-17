using MM.Model;
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

        Member GetMember(string phoneNumber);
        IEnumerable<Member> GetAllMembers();
        void AddMember(string name, string phoneNumber, Gender gender, string Address);
        void ModifyMember(Member member);
        void RemoveMember(Guid memberId);
    }
}
