﻿namespace CSClass
{
    public class Student
    {
        public string name;
        public int grade;

        public override string ToString()
        {
            return this.name + " : " + this.grade;
        }
    }
}