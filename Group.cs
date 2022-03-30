using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    class Group
    {
        static int _no=200;

        public string No { get; }
        public Group()
        {
            _no++;
            No = "AP" + _no;

        }
        public int StudentLimit;
        private Student[] _students=new Student[0];


        public void AddStudent(Student student)
        {
            if (_students.Length<StudentLimit)
            {

                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length - 1] = student;
                return;

            }
            throw new CapacityLimitException("Limit Doldu");

        }

    }
}
