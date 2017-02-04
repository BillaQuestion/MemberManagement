using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MM.Model
{
    public abstract class MemberProduct : Product
    {
        public int Count { get; set; }
    }
}