using System;
using System.Linq;


namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reverse();

            //NameSurName();

            Math();
        }
        static void Reverse()

        {
            Console.WriteLine($"Enter your name :");
            string Name = Console.ReadLine();
            Console.WriteLine("Reverse Name: " + new string(Name.Reverse().ToArray()));
        }
        static void NameSurName()
        {
            Console.WriteLine("Enter FirstName : ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter LastName : ");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Name Surname: {firstName.ToUpper()} {lastName.ToUpper()}");
        }

        static void Math()
        {
            Console.WriteLine("Ener radius of a circle");
            double radius = double.Parse(Console.ReadLine());
            double area = 3.14 * (radius*radius);
            double perimetr = 2*3.14*radius;
            Console.WriteLine($"Area of a circle : {area}");
            Console.WriteLine($"Perimetr of a circle : {perimetr}");


        }
    }
}
