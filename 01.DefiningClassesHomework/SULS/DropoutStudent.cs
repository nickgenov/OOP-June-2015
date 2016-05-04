using System;

namespace SULS
{
    public class DropoutStudent : Student
    {
        private string dropoutReason;

        public DropoutStudent(string firstName, string lastName, int age, long studentNumber, double averageGrade, string dropoutReason) : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.DropoutReason = dropoutReason;
        }

        public string DropoutReason
        {
            get
            {
                return this.dropoutReason; 
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("DropoutReason cannot be null or an empty string.");
                }
                this.dropoutReason = value;
            }
        }

        public void Reapply()
        {
            Console.WriteLine("Name: {0} {1}, age: {2}, student number: {3}, average grade: {4}, dropout reason: {5}", this.FirstName, this.LastName, this.Age, this.StudentNumber, this.AverageGrade, this.DropoutReason);
        }
    }
}