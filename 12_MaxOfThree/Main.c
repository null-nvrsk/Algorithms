// [Скоморохов Максим]
// Написать функцию нахождения максимального из трех чисел.

#include "Main.h"

#include <locale.h>
#include <stdio.h>
#include <time.h>

int main(int argc, const char* argv[]) {
	setlocale(LC_ALL, "Russian"); // задаём русский текст
	
	printf("Введите максимальное число для генерации случайных чисел: ");

	int max = 0;
	scanf_s("%d", &max);

	int arr[3];
	// генерируем 3 случайных числа
	srand(time(NULL));
	for (int i = 1; i <= 3; i++)
	{
		arr[i - 1] = rand() % (max + 1);
		printf("%d случайное число: %d\n", i, arr[i - 1]);
	}
	
	printf("Максимальное из 3 случайных чисел: %d\n", GetMaxOfThree(arr[0], arr[1], arr[2]));

	getchar();
	return 0;
}

//-----------------------------------------------------------------------------
int GetMaxOfThree(int num1, int num2, int num3)
{
	int max = num1;
	if (num2 > max) max = num2;
	if (num3 > max) max = num3;

	return max;
}
