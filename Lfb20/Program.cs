using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lfb20
{


    class Program
    {

         static void Main(string[] args)
        {

            Func<double, double> func;
            Console.WriteLine("Введите значение радиуса");
            double Radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Что будем вычислять? Ваш выбор:");
            Console.WriteLine("1. Длину окружности");
            Console.WriteLine("2. Площадь круга");
            Console.WriteLine("3. Объем шара");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            switch (choice)
            {
                case 1:
                    {
                        func = Calc.LengthOkr;
                        Console.WriteLine($"  = {func(Radius),3:f3}");
                        break;
                    }
                case 2:
                    {
                        func = Calc.AreaCircle;
                        Console.WriteLine($"  = {func(Radius),3:f3}");
                        break;
                    }
                case 3:
                    {
                        func = Calc.VolumeBall;
                        Console.WriteLine($"  = {func(Radius),3:f3}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Некорректный выбор");
                        break;
                    }
            }
            Console.ReadKey();

        }

          class Calc
        {

            public static double LengthOkr(double Radius)
            {
                double exp = 2 * Math.PI * Radius;
                return exp;
            }

            public static double AreaCircle(double Radius)
            {
                double exp = Math.PI * Math.Pow(Radius, 2);
                return exp;
            }

            public static double VolumeBall(double Radius)
            {
                double exp = 4 / 3 * Math.PI * Math.Pow(Radius, 3);
                return exp;
            }
        }
    }
}
