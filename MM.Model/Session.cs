using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MM.Model
{
    public class Session
    {
        public SessionStates State { get; set; }

        public string Description { get; set; }

        public Tutor Tutor { get; set; }
    }
}