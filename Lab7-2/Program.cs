using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2
{
    class Program
    {
        //Метод вычисляющий объем и площадь поверхности куба по длине его ребра
        static void GetCubeVandSq(double x, out double v, out double s)
        {
            v = x * x * x;
            s = 6 * x * x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба:");
            Console.Write("a - ");
            double a = Convert.ToDouble(Console.ReadLine());

            double volume, square;
            GetCubeVandSq(a, out volume, out square);

            Console.WriteLine();
            Console.WriteLine("Объем куба - {0}, площадь поверхности куба - {1}", volume, square);
            Console.ReadKey();
        }
    }
}
