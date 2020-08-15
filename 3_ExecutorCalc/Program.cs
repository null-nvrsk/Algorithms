// [Скоморохов Максим]
// Исполнитель Калькулятор преобразует целое число, записанное на экране. У исполнителя две команды, каждой команде присвоен номер:
// Прибавь 1
// Умножь на 2
// Первая команда увеличивает число на экране на 1, вторая увеличивает это число в 2 раза. Сколько существует программ, которые число 3 преобразуют в число 20?
// а) с использованием массива;
// б) с использованием рекурсии.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ExecutorCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод стартового числа пользователем
            Console.Write("Введите начальное число (по-умолчанию = 0): ");
            int startUserInt = 0;
            try
            {
                startUserInt = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
            }            

            // Ввод необходимого числа пользователем
            Console.Write("Введите какое число надо получить: ");
            int endUserInt = Convert.ToInt32(Console.ReadLine());

            // Подсчет возможных вариантов (введеных пользователем) с использованием рекурсии
            Console.WriteLine("вариантов преобразования (введеных пользователем): " + CalculateRecursive(startUserInt, endUserInt) + "\n");

            // Подсчет возможных вариантов преобразования из 3 в 20 (с использованием рекурсии)
            Console.WriteLine("вариантов преобразования из 3 в 20: " + CalculateRecursive(3, 20));

            Console.ReadLine();
        }

        //---------------------------------------------------------------------

        static int CalculateRecursive(int currentValue, int needValue, string path = "")
        {
            // Если это первый вход в функцию, то в path указываем начальное число
            if (path == "") path = currentValue.ToString() + " ";

            // Если текущее число меньше необходимого, то дальше выбираем 2 вариант (+1 и х2)
            if (currentValue < needValue)
            {
                int result = 0;
                result += CalculateRecursive(currentValue + 1, needValue, path + "+");
                // не надо умножать на 2 значения 0 и 1
                if (currentValue > 1)
                    result += CalculateRecursive(currentValue * 2, needValue, path + "x");

                return result;
            }
            // если число подошло, то сообщаем об удаче
            else if (currentValue == needValue)
            {
                Console.WriteLine(path + " " + currentValue);
                return 1;
            }
            // В остальных случаях - перебор
            return 0;
        }
    }
}
