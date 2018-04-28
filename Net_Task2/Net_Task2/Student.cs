using System;

namespace Net_Task2
{
    public class Student : Man
    {

        private int year;
        private int course;
        private string group;

        public Student(string name, int age, double weight, int height, int year, int course, string group) : base(name, age, weight, height)
        {
            this.Year = year;
            this.Course = course;
            this.Group = group;
        }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if ((value > 1970) && (value <= DateTime.Today.Year))
                {
                    year = value;
                }
            }
        }

        public int Course
        {
            get
            {
                return course;
            }
            set
            {
                if ((value >= 1) && (value <= 6))
                {
                    course = value;
                }
            }
        }

        public string Group
        {
            get
            {
                return group;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    group = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"Year: {Year} Course: {Course} Group: {Group} ";
        }
    }
}
