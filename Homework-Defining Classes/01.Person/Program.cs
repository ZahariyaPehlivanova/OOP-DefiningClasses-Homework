using Homework_Defining_Classes;
using System;
class Program
{
    static void Main(string[] args)
    {
        Person Mariq = new Person("Mariq", 20, "Mariq@gmail.com");
        Person Pesho = new Person("Pesho", 30);
        Person Ivan = new Person("Ivan", 21,"Ivan@yahoo.com");
        Console.WriteLine(Mariq.ToString());
        Console.WriteLine();
        Console.WriteLine(Pesho.ToString());
        Console.WriteLine();
        Console.WriteLine(Ivan.ToString());
    }
}
