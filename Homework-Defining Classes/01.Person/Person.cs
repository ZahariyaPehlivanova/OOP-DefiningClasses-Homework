﻿using System;
namespace Homework_Defining_Classes
{

    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }
        public Person(string name, int age)
            : this(name, age, null)
        { }
       
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
                    throw new ArgumentException("Name can't be empty");
                }
                else if (value.Length < 1)
                {
                    throw new ArgumentException("Name is too short");
                }
                else if (value.Length > 100)
                {
                    throw new ArgumentException("Name is too long");
                }
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException("Age is outside of the range [1 ... 100]");
                }
                this.age = value;
            }

        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (null != value &&  !value.Contains("@"))
                {
                    throw new ArgumentException("Invalid email");
                }
                this.email = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Name : {0}\nAge : {1}\nEmail : {2}", this.Name, this.Age, this.Email ?? "[missing e-mail]");
        }
    }
}