using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much does it weigh? : ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("How tall is it? : ");
            double height = Convert.ToDouble(Console.ReadLine());

            double heightInMeters = height / 100;

            double BMI = (weight /(heightInMeters * heightInMeters));

            Console.WriteLine($"The BMI is :{BMI:F2}");
            Console.ReadLine();

        }
    }
}
