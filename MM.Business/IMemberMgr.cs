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
        Member Get(string phoneNumber);
        IEnumerable<Member> GetAll();
        void Create(string name, string phoneNumber, Gender gender, string Address, Balance balance);
        void Modify(Member member);
        void Remove(Guid memberId);
    }
}
