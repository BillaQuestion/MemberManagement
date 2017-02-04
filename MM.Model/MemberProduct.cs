using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dayi.Data.Domain.Seedwork;
using System.ComponentModel.DataAnnotations;

namespace MM.Model
{
    public abstract class MemberProduct : Product
    {
        public int Count { get; set; }


    }
}