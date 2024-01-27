using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        //Метод вычисляющий площадь треугольника по его сторонам
        static double GetSqTriangl(double a, double b, double c)
        {
            double s = 0;
            double p = a + b + c;
            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольника:");
            Console.Write("a - ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b - ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c - ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Введите стороны второго треугольника:");
            Console.Write("x - ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y - ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("z - ");
            double z = Convert.ToDouble(Console.ReadLine());

            double s1 = 0, s2 = 0;

            s1 = GetSqTriangl(a, b, c);
            s2 = GetSqTriangl(x, y, z);

            Console.WriteLine("");

            if (s1 > s2)
            {
                Console.WriteLine("Площадь первого треугольника больше");
            }
            else if (s2 > s1)
            {
                Console.WriteLine("Площадь второго треугольника больше");
            }
            else
            {
                Console.WriteLine("Площади треугольников равны");
            }

            Console.ReadKey();
        }
    }
}
