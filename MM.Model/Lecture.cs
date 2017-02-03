using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MM.Model.Exceptions;

namespace MM.Model
{
    public class Lecture
    {
        private int lastSessionNumber = 0;

        private ICollection<Session> _sessions;

        public ICollection<Session> Sessions { get { return _sessions; } }

        public string Name { get; set; }

        public string Description { get; set; }

        public void AddASession()
        {
            Session session = new Session(++lastSessionNumber);
        }

        public void RemoveSession(int sessionNumber)
        {
            var result = _sessions.FirstOrDefault(x => x.Number == sessionNumber);
            if (result == null)
            {
                throw new CountNotEnoughException("Session number not exist!");
            }
        }
    }
}