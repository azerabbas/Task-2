using System;
using System.Linq;


namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // 1. Write a C# program that takes three letters as input and display them in reverse order.
          // 2. Write a C# program that takes 2 inputs form user respectively name and surname, and then print it as "NAME SURNAME" (both uppercase) in console
          // 3. Write a C# program that takes the radius of a circle as input and calculate the perimeter and area of the circle and print it in console
          // 4. Make a lot of exercises with different types and try to understand important aspects
            
            Reverse();
            NameSurName();
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
