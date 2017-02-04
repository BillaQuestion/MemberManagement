using MM.Model.Enums;
using MM.Model.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MM.Model
{
    public class Student
    {
        private ICollection<Lecture> _lectures;

        #region
        public string ContactNumber { get; set; }

        public string Name { get; set; }

        public Gender Gender { get; set; }

        public string Address { get; set; }

        public ICollection<Lecture> Lectures { get { return _lectures; } }
        #endregion

        public Student()
        {
            _lectures = new List<Lecture>();
        }

        #region
        public void BuyALecture(Lecture lecture)
        {
            var result = _lectures.FirstOrDefault(x => x.Name == lecture.Name);
            if (result == null)
            {
                _lectures.Add(lecture);
            }
            else
            {
                throw new LectureExistException();
            }
        }

        public void TakeASession(string lectureName, int sessionNumber)
        {
            var lectureResult = _lectures.FirstOrDefault(x => x.Name == lectureName);
            if (lectureResult == null)
            {
                throw new CountNotEnoughException("Lecture doesn't exist!");
            }
            var sessionResult = lectureResult.Sessions.FirstOrDefault(x => x.Number == sessionNumber);
            //if(sessionResult == null)
            //{
            //    throw new CountNotEnoughException("Session doesn't exist!");
            //}
            if (sessionResult.State == SessionStates.Done)
            {
                throw new CountNotEnoughException("Session has been taken!");
            }

            sessionResult.State = SessionStates.Done;
        }

        public void RemoveALecture(string lectureName)
        {
            var result = _lectures.FirstOrDefault(x => x.Name == lectureName);
            if (result == null)
            {
                throw new CountNotEnoughException("Lecture doesn't exist!");
            }
            _lectures.Remove(result);
        }
        #endregion
    }
}