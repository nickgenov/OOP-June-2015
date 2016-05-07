using System;

namespace SULS
{
    public abstract class Student : Person
    {
        private long studentNumber;
        private double averageGrade;

        public Student(string firstName, string lastName, int age, long studentNumber, double averageGrade) : base(firstName, lastName, age)
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }

        public long StudentNumber
        {
            get
            {
                return this.studentNumber;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("StudentNumber", "StudentNumber must be a positive integer.");
                }
                this.studentNumber = value;
            }
        }

        public double AverageGrade
        {
            get
            {
                return this.averageGrade;
                
            }
            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("AverageGrade", "AverageGrade must be in the range [2...6].");
                }
                this.averageGrade = value;
            }
        }

        public override string ToString()
        {
            return string.Format(
                "Student information: name: {0} {1}, age: {2}, student number: {3}, average grade: {4}", this.FirstName,
                this.LastName, this.Age, this.StudentNumber, this.AverageGrade);
        }
    }
}