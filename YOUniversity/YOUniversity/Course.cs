using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YOUniversity
{
    public class Course
    {
        private string _CourseName;
        private string _MeetingTimes;
        private string _Location;
        private string _Instructor;
        private int _CreditHours;

        public Course() { }

        public Course(string n, string m, string l, string i, int c)
        {
            _CourseName = n;
            _MeetingTimes = m;
            _Location = l;
            _Instructor = i;
            _CreditHours = c;

        }

        public string CourseName { get => _CourseName; set => _CourseName = value;}
        public string MeetingTimes { get => _MeetingTimes; set => _MeetingTimes = value;}
        public string Location { get => _Location; set => _Location = value;}
        public string Instructor { get => _Instructor; set => _Instructor = value;}
        public int CreditHours { get => _CreditHours; set => _CreditHours = value;}

    }
}
