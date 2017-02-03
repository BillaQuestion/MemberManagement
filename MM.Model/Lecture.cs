using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MM.Model
{
    public class Lecture
    {
        public ICollection<Session> Sessions { get; set; }

        
    }
}