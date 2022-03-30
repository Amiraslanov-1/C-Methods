using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    class Student
    {
        public string Name { get;set; }
        public string Surname { get; set; }
        private int _age;
        public int Age
        {
            get => _age;
            set
            {
                if (value>0)
                {
                    this._age = value;
                }
            }
        }
        int _point;
        public int Point {
            get => _point;
            set
            {
                if (value>0&&value<100)
                {
                    this._point = value;
                }
            }
            }

        public Student(string name,string surname,int point)
        {
            Name = name;
            Surname = surname;
            Point = point;

        }
    }

}
