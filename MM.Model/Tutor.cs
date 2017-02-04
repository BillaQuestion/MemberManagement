using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MM.Model
{
    public class Tutor
    {
        private ICollection<Session> _sessionsToBeTaught;

        public string Name { get; set; }

        //public Gender Gender { get; set; }

        public string ContactNumber { get; set; }

        public string Address { get; set; }

        public ICollection<Session> TaughtSessions { get { return _sessionsToBeTaught; } }

        public void ChooseASession(string contactNumber, string lectureName, int sessionNumber)
        {

        }
    }
}