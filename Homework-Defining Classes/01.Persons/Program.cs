using Homework_Defining_Classes;
using System;
class Program
{
    static void Main(string[] args)
    {
        Person Mariq = new Person("Mariq", 20, "Mariqgmail.com");
        Person Pesho = new Person("Pesho", 30);
        Person Ivan = new Person("Ivan",21);
        Console.WriteLine(Mariq.ToString());
        Console.WriteLine(Pesho.ToString());
        Console.WriteLine(Ivan.ToString());
    }
}
