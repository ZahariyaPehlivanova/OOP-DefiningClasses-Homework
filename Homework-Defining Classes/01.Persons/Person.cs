using System;
namespace Homework_Defining_Classes
{

    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {

            this.name = name;
            this.age = age;
            this.email = email;
        }
        public Person(string name, int age)
            : this(name, age, null)
        {
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
                    throw new ArgumentException("Name can't be empty");
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
                if (String.IsNullOrEmpty(value))
                    this.email = "[unknown]";
                else if (!value.Contains("@"))
                    throw new ArgumentException("Error: The email must contain @");
                else
                    this.email = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Name : {0}\nAge : {1}\nEmail : {2}",this.Name,this.Age,this.Email);
        }
    }
}