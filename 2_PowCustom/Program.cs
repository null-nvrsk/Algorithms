// [Скоморохов Максим]
// Реализовать функцию возведения числа a в степень b:
// a.без рекурсии;
// b.рекурсивно;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PowCustom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("возведения числа a в степень b (a ^ b)");
            Console.Write("Введите a (десятичная дробь через ,): ");
            double a = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Возводим в степень с помощью PowCustom: " + PowCustom(a, b));

            Console.WriteLine("Возводим в степень с помощью PowRecurse: " + PowRecurse(a, b));

            Console.ReadLine();
        }

        //---------------------------------------------------------------------
        //  возведения числа a в степень b (ез рекурсии)
        static double PowCustom(double a, int b)
        {
            if (a > 0 && b == 0) return 1;
            else if (b > 0)
            {
                double result = a;
                for (int i = 2; i <= b; i++)
                    result *= a;

                return result;
            }

            else if (b < 0)
            {
                double result = 1 / a;
                for (int i = -2; i >= b; i--)
                    result /= a;

                return result;
            }

            // во всех остальных случаях возращаем ноль
            return 0;
        }


        //---------------------------------------------------------------------
        //  возведения числа a в степень b (с рекурсией)
        static double PowRecurse(double a, int b)
        {
            if (a > 0 && b == 0) return 1;
            else if (b > 0)
            {
                if (b == 1)
                    return a;
                else
                    return a * PowRecurse(a, b - 1);
            }

            else if (b < 0)
            {
                if (b == -1)
                    return 1 / a;
                else
                    return (1 / a) * PowRecurse(a, b + 1);
            }

            // во всех остальных случаях возращаем ноль
            return 0;
        }
    }
}
