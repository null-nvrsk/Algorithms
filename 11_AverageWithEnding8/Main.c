// [Скоморохов Максим]
// С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать среднее 
// арифметическое всех положительных четных чисел, оканчивающихся на 8.

#include "Main.h"

#include <locale.h>
#include <stdio.h>

int main(int argc, const char* argv[]) {
	setlocale(LC_ALL, "Russian"); // задаём русский текст
	
	printf("Введите целые числа (0 - выход)\n");

	int num;
	int totalCount = 0;
	int totalSum = 0;
	do
	{
		scanf_s("%d", &num);
		if (num == 0) break;
		
		if (num > 0 && num % 10 == 8)
		{
			totalCount++;
			totalSum += num;
		}
	} while (num != 0);

	// Выводим результат
	if (totalCount > 0)
	{
		float average = (float)totalSum / (float)totalCount;
		printf("среднее арифметическое всех положительных четных чисел, оканчивающихся на 8 = %f", average);
	}
	else
		printf("Нет чисел подходящих для подчета");

	getchar();
	return 0;
}
