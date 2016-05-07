using System;

namespace HumanStudentWorker.People
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("WeekSalary", "WeekSalary cannot be a negative number.");
                }
                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("WorkHoursPerDay", "WorkHoursPerDay cannot be a negative number.");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal hourlyWage = this.WeekSalary/(decimal) (this.WorkHoursPerDay * 5);

            return hourlyWage;
        }

        public override string ToString()
        {
            return string.Format("Worker name: {0} {1}, weekly salary: {2}, work hours per day: {3}, money earned per hour: {4:F2}", this.FirstName,
                this.LastName, this.WeekSalary, this.WorkHoursPerDay, this.MoneyPerHour());
        }
    }
}