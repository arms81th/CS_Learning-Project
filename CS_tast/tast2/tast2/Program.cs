using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tast2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //การนิยามตัวแปร
            int a, b;
            a = 10;
            b = 20;

            float c, d;
            c = 3.14f;
            d = 2.71f;

            bool f, g;
            f = true;
            g = false;

            double e = 1.6180339887;

            Console.WriteLine($"a={a},b={b},c={c},d={d},f={f},g={g},e={e}");
            Console.ReadLine();
        }
    }
}
