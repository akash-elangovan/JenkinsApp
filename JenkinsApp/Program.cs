using System;
using MyMaths2;

namespace JenkinsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to Jenkins");

            Calculator calc = new Calculator();
            Console.WriteLine("Enter two numbers");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Adding = {calc.Add(x, y)}");
            Console.WriteLine($"Mulitplying = {calc.Multiply(x, y)}");
            Console.ReadLine();
        }
    }
}
