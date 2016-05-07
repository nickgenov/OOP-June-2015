using System;

namespace SULS
{
    public class OnsiteStudent : CurrentStudent
    {
        private int numberOfVisits;

        public OnsiteStudent(string firstName, string lastName, int age, long studentNumber, double averageGrade, string currentCourse, int numberOfVisits) : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            this.NumberOfVisits = numberOfVisits;
        }

        public int NumberOfVisits
        {
            get
            {
                return this.numberOfVisits;
                
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("NumberOfVisits", "NumberOfVisits must be a positive integer.");
                }
                this.numberOfVisits = value;
            }
        }
    }
}