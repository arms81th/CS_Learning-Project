using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n=== Addition, subtraction, multiplication, division ===");
            Console.Write("Enter The first set of numbers: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter The second set of numbers: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} / {num2} = {(num1 / num2):F2}");
            Console.ReadLine();
        }
    }
}