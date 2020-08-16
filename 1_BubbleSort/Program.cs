// [Скоморохов Максим]
// Попробовать оптимизировать пузырьковую сортировку. Сравнить количество
// операций сравнения оптимизированной и не оптимизированной программы.
// Написать функции сортировки, которые возвращают количество операций.
// 
// *Реализовать шейкерную сортировку.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_BubbleSort
{
    class Program
    {    
        static int arrayLength = 20000;
        static int minValue = 1;
        static int maxValue = 10000;

        static void Main(string[] args)
        {
            
            int[] intArray = new int[arrayLength];

            
            // ..................пузырьковая сортировка........................
            // заполняем массив случайными числами и выводим массив до сортировки
            RandomArray(intArray);
            //ShowArray(intArray);

            DateTime startTime = DateTime.Now;
            BubbleSort(intArray);
            DateTime endTime = DateTime.Now;
            Console.WriteLine("Время пузырьковой сортировки: " + (endTime - startTime) + "\n");

            // Выводим массив после сортировки
            //ShowArray(intArray);

            // ..................оптимизированная сортировка...................
            // заполняем массив случайными числами и выводим массив до сортировки
            RandomArray(intArray);
            //ShowArray(intArray);

            startTime = DateTime.Now;
            OptimizedBubbleSort(intArray);
            endTime = DateTime.Now;
            Console.WriteLine("Время оптимизированной сортировки: " + (endTime - startTime) + "\n");

            // Выводим массив после сортировки
            //ShowArray(intArray);

            // ......................Шейкерная сортировка......................
            // заполняем массив случайными числами и выводим массив до сортировки
            RandomArray(intArray);
            //ShowArray(intArray);

            startTime = DateTime.Now;
            ShakerSort(intArray);
            endTime = DateTime.Now;
            Console.WriteLine("Время шейкерной сортировки: " + (endTime - startTime) + "\n");

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
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        //---------------------------------------------------------------------
        // Оптимизированная пузырьковая сортировка
        // количество шагов в среднем в 2 раза меньше стандартной пузырьковой сортировки
        static void OptimizedBubbleSort(int[] arr)
        {
            // на 1ой итерации проходим n-1 шагов. Но т.к. при первом проходе
            // на последнем месте уже самый большой элемент, то на 2ой итерации
            // проходим только n-2 шагов и т.д.
            
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength - 1 - i; j++)
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

        //---------------------------------------------------------------------
        // Шейкерная сортировка
        static void ShakerSort(int[] arr)
        {
            int localMin = 0;
            int localMax = arrayLength - 1;

            for (int i = 0; i < arrayLength; i++)
            {
                // нечетные итерации (i=0,2,4,..) сортируют максмальный элемент в конец
                if (i % 2 == 0)
                {
                    for (int j = localMin; j < localMax; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }

                    localMax--;
                }

                // четные итерации (i=1,3,5,..) сортируют минимальный элемент в начало
                if (i % 2 == 1)
                {
                    for (int j = localMax; j > localMin; j--)
                    {
                        if (arr[j - 1] > arr[j])
                        {
                            int temp = arr[j - 1];
                            arr[j - 1] = arr[j];
                            arr[j] = temp;
                        }
                    }

                    localMin++;
                }
            }
        }
    }
}
