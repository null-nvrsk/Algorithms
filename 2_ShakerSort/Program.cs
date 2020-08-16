// [Скоморохов Максим]
// *Реализовать шейкерную сортировку.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ShakerSort
{
    class Program
    {
        static int arrayLength = 30000;
        static int minValue = 1;
        static int maxValue = 10000;

        static void Main(string[] args)
        {
            int[] intArray = new int[arrayLength];


            // ..................пузырьковая сортировка..........................
            // заполняем массив случайными числами и выводим массив до сортировки
            RandomArray(intArray);
            //ShowArray(intArray);

            DateTime startTime = DateTime.Now;
            ShakerSort(intArray);
            DateTime endTime = DateTime.Now;
            Console.WriteLine("Время пузырьковой сортировки: " + (endTime - startTime) + "\n");

            // Выводим массив после сортировки
            //ShowArray(intArray);

            // ..................оптимизированная сортировка..........................
            // заполняем массив случайными числами и выводим массив до сортировки
            RandomArray(intArray);
            //ShowArray(intArray);

            startTime = DateTime.Now;
            OptimizedBubbleSort(intArray);
            endTime = DateTime.Now;
            Console.WriteLine("Время оптимизированной сортировки: " + (endTime - startTime) + "\n");

            // Выводим массив после сортировки
            //ShowArray(intArray);


            Console.Read();
        }

        //---------------------------------------------------------------------
        // Выводим массив в консоль
        static void ShowArray(int[] arr)
        {
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write("\n\n");
        }

        //---------------------------------------------------------------------
        // заполняем массив случайными числами
        static void RandomArray(int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arrayLength; i++)
            {
                arr[i] = rnd.Next(minValue, maxValue + 1);
            }
        }

        //---------------------------------------------------------------------
        // Стандартная пузырьковая сортировка
        static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
