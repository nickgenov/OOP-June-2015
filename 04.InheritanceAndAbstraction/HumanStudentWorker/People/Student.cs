using System;
using System.Text.RegularExpressions;

namespace HumanStudentWorker.People
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                Regex regex = new Regex(@"[A-Za-z0-9]{5,10}");
                Match match = regex.Match(value);

                if (match.Success == false)
                {
                    throw new ArgumentException("Faculty number must be 5-10 digits / letters.", "FacultyNumber");
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Student name: {0} {1}, faculty number: {2}", this.FirstName, this.LastName,
                this.FacultyNumber);
        }
    }
}