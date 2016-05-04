using System;

namespace SULS
{
    public class CurrentStudent : Student
    {
        private string currentCourse;

        public CurrentStudent(string firstName, string lastName, int age, long studentNumber, double averageGrade, string currentCourse) : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.CurrentCourse = currentCourse;
        }

        public string CurrentCourse
        {
            get
            {
                return this.currentCourse; 
                
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("CurrentCourse cannot be null or an empty string.");
                }
                this.currentCourse = value;
            }
        }
    }
}