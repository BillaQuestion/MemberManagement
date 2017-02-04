using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MM.Model
{
    public class Student : Visitor
    {
        private ICollection<Lecture> _lectures;

        public string ContactNumber { get; set; }

        public string Name { get; set; }

        public Gender Gender { get; set; }

        public string Address { get; set; }
    }
}