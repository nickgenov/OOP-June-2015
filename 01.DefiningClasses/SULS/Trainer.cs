﻿using System;

namespace SULS
{
    public abstract class Trainer : Person
    {
        public Trainer(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
        }

        public void CreateCourse(string courseName)
        {
            Console.WriteLine("Course {0} has been created.", courseName);
        }
    }
}