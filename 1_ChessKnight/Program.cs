// [Скоморохов Максим]
// Требуется обойти конём шахматную доску размером NxM, пройдя через все поля
// доски поодному разу.Здесь алгоритм решения такой же как и в задаче о 8 ферзях.
// Разница только в проверке положения коня.


using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ChessKnight  
{
    class Program
    {
        const int N = 8;
        const int M = 8;
        static bool found = false;

        static void Main(string[] args)
        {

            int[,] board = new int[N, M];
            // Доска для коней.
            // 0 - клетка пустая
            // число - номер коня
            Init(ref board);

            //SearchSolution(1, ref board);
            FirstKnight(ref board);

            Console.WriteLine("Finished!");
            Console.ReadLine();
        }

        //---------------------------------------------------------------------
        // Первичное заполнение доски
        static void Init(ref int[,] board)
        {
            int i, j;
            for (i = 0; i < N; i++)
                for (j = 0; j < M; j++)
                {
                    board[i, j] = 0;
                }
        }

        //---------------------------------------------------------------------
        // Первого коня пробуем поставить по ояереди на все клетки
        static void FirstKnight(ref int[,] board)
        {
            int row;
            int col;

            // т.к. ход возможные решения будут повторятся при зеркальной расстановке (и по вертикали и по горизонтали), то есть смысл проверять начальную позицию только на четверти весго поля
            for (row = 0; row < (N + 1) / 2; row++)
                for (col = 0; col < (M + 1) / 2; col++)
                {
                    if (!found) SetNextKnightAround(ref board, row, col);
                }
        }

        //---------------------------------------------------------------------
        // Пробуем поставить коня в вокруг предыщего 
        static void SetNextKnightAround(ref int[,] board, int n, int m, int step = 1)
        {
            // 8 вариантов расстановки
            int[,] variant = {
                {1, 2},
                {2, 1},
                {2, -1},
                {1, -2},
                {-1, -2},
                {-2, -1},
                {-2 , 1},
                {-1 , 2}
            };

            board[n, m] = step;

            // Если нашли последнюю клетку, то сообщаем об успехе
            if (step == M * N)
            {
                PrintTable(ref board);
                found = true;
                return;
            }

            for (int i = 0; i < 8; i++)
            {
                int newN = n + variant[i, 0];
                int newM = m + variant[i, 1];

                if (CheckKnight(newN, newM, ref board))
                {
                    if (!found) SetNextKnightAround(ref board, newN, newM, step + 1);
                }
            }

            // Не найдено вариантов
            board[n, m] = 0;
            return;
        }

        //---------------------------------------------------------------------
        static bool CheckKnight(int n, int m, ref int[,] board)
        {
            // Проверяем что клетка находится в диапазоне доски
            if (n < 0 || n >= N ||
                m < 0 || m >= M) return false;

            // Если сама клетка уже занята
            if (board[n, m] > 0) return false;

            return true;
        }

        //---------------------------------------------------------------------
        static void PrintTable(ref int[,] board)
        {
            int i, j;
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < M; j++)
                {
                    string str = String.Format("{0} ", board[i, j]);
                    Console.Write($"{str, 3} ");
                }
                Console.WriteLine();
            }
        }
    }
}
