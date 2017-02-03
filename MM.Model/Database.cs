using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MM.Model
{
    public class Database
    {
        #region Private Database
        private ICollection<Member> _members;

        private ICollection<BusinessCard> _businessCards;

        private ICollection<Student> _students;

        private ICollection<Lecture> _lectures;

        private ICollection<Tutor> _tutors;

        private ICollection<Trial> _trials;

        private ICollection<string> _mediumCollection;
        #endregion

        #region Properties
        public ICollection<Member> Members { get { return _members; } }

        public ICollection<BusinessCard> BusinessCards { get { return _businessCards; } }

        public ICollection<Student> Students { get { return _students; } }

        public ICollection<Lecture> Lectures { get { return _lectures; } }

        public ICollection<Tutor> Tutors { get { return _tutors; } }

        public ICollection<Trial> Trials { get { return _trials; } }

        public ICollection<string> MediumCollection { get { return _mediumCollection; } }
        #endregion
    }
}