using System;
using CompanyHierarchy.Enums;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Classes
{
    public class Project : IProject
    {
        private string name;
        private DateTime startDate;
        private string details;
        private State state;

        public Project(string name, DateTime startDate, string details, State state)
        {
            this.Name = name;
            this.StartDate = startDate;
            this.Details = details;
            this.State = state;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or an empty string.", "Name");
                }
                this.name = value;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return this.startDate;
            }
            set
            {
                this.startDate = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Details cannot be null or empty.", "Details");
                }
                this.details = value;
            }
        }

        public State State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
            }
        }

        public void CloseProject()
        {
            if (this.State == State.Open)
            {
                this.State = State.Closed;
            }
        }

        public override string ToString()
        {
            string result = string.Format("Project name: {0}, start date: {1}, details: {2}, state: {3}", this.Name, this.StartDate.Date, this.Details, this.State);

            return result;
        }
    }
}