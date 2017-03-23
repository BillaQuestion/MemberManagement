using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MM.Model;

namespace MM.Business
{
    public interface IMemberCardMgr
    {
        MemberCard GetById(Guid memberCardId);

        void Save(MemberCard balance);
    }
}
