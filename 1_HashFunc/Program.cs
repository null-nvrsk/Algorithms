// [Скоморохов Максим]
// Реализовать простейшую хэш-функцию. На вход функции подается строка,
// на выходе сумма кодов символов.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_HashFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            int hash = GetHash(input);

            Console.WriteLine($"Полученный хеш: {hash}");
            Console.ReadLine();
        }

        //---------------------------------------------------------------------
        static int GetHash(string input)
        {
            int hash = 0;
            for (int i = 0; i < input.Length; i++)
            {
                hash += (int)input[i];
            }

            return hash;
        }
    }
}
