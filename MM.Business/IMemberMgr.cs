using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MM.Model;

namespace MM.Business
{
    public interface IMemberMgr
    {
        Member GetMember(Guid memberId);
        IEnumerable<Member> GetAllMember();
        void CreateMember(Member member);
        void ModifyMember(Member member);
        void RemoveMember(Guid memberId);
    }
}
