using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7T2
{
    class Program
    {
        static void Main(string[] args)
        
        {
                Console.WriteLine("Введите сторону (a) для вычисления объема и площади куба");
                double a = Convert.ToDouble(Console.ReadLine());

                double[] znachVS = CalcVS(a);
                double V = znachVS[0];
                double S = znachVS[1];

                Console.WriteLine("Объем куба равен {0}", V);
                Console.WriteLine("Площадь куба равен {0}", S);
                Console.ReadKey();

        }
        static double[] CalcVS(double a)
        {
                double V = Math.Pow(a, 3);
                double S = 6 * Math.Pow(a, 2);
                double[] znachVS = { V, S };

                return znachVS;
        }
        
    }
}
