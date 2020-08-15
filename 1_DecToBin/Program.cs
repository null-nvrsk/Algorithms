// [Скоморохов Максим]
// Реализовать функцию перевода из десятичной системы в двоичную, используя рекурсию.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DecToBin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число (в десятичной системе): ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            string bin = "";
            DecToBin(ref bin, userInput);
            Console.WriteLine($"Число в двоичной системе: {bin}");


            Console.ReadLine();
        }

        //---------------------------------------------------------------------
        static void DecToBin(ref string bin, int dec)
        {

            bin = Convert.ToString(dec % 2) + bin;

            if (dec / 2 > 0)
                DecToBin(ref bin, dec / 2);
        }
    }
}
