using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MM.Model
{
    public class Tutor
    {
        private ICollection<Session> _taughtSessions;

        public string Name { get; set; }

        public Gender Gender { get; set; }

        public string ContactNumber { get; set; }

        public string Address { get; set; }
    }
}