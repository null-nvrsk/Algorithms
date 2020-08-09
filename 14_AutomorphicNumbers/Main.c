// [Скоморохов Максим]
// Автоморфные числа. Натуральное число называется автоморфным, если оно равно 
// последним цифрам своего квадрата.Например, 252 = 625. Напишите программу, 
// которая вводит натуральное число N и выводит на экран все автоморфные числа,
// не превосходящие N.

#include "Main.h"

#include <locale.h>
#include <stdio.h>

int main(int argc, const char* argv[]) {
	setlocale(LC_ALL, "Russian"); // задаём русский текст

	// no boolean
	int true = 1;
	int false = 0;
	
	printf("Автоморфные числа\n");
	printf("Ввоедите натуральное число: ");

	int max = 0;
	int automorphic;
	scanf_s("%d", &max);


	for (int i = 1; i <= max; i++)
	{
		int number = i;
		int squareNumber = i * i;
		while (1)
		{
			automorphic = false;
			// сравниваем последний знак
			int lastNumber = number % 10;
			int lastSquareNumber = squareNumber % 10;

			if (lastNumber != lastSquareNumber)	break;

			number /= 10;
			squareNumber /= 10;
			// если больше чисел нету, значит автоморфное
			if (number == 0)
			{
				automorphic = true;
				break;
			}
		}

		if (automorphic) printf("%d\n", i);
	}

	//getchar();
	return 0;
}