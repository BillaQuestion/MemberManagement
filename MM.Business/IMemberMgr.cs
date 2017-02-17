using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MM.Model;
using MM.Model.Enums;

namespace MM.Business
{
    public interface IMemberMgr
    {
        Member GetMember(string phoneNumber);
        IEnumerable<Member> GetAllMembers();
        void AddMember(string name, string phoneNumber, Gender gender, string Address);
        void ModifyMember(Member member);
        void RemoveMember(Guid memberId);
    }
}
