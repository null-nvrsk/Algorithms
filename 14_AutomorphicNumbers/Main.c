// [���������� ������]
// ����������� �����. ����������� ����� ���������� �����������, ���� ��� ����� 
// ��������� ������ ������ ��������.��������, 252 = 625. �������� ���������, 
// ������� ������ ����������� ����� N � ������� �� ����� ��� ����������� �����,
// �� ������������� N.

#include "Main.h"

#include <locale.h>
#include <stdio.h>

int main(int argc, const char* argv[]) {
	setlocale(LC_ALL, "Russian"); // ����� ������� �����

	// no boolean
	int true = 1;
	int false = 0;
	
	printf("����������� �����\n");
	printf("�������� ����������� �����: ");

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
			// ���������� ��������� ����
			int lastNumber = number % 10;
			int lastSquareNumber = squareNumber % 10;

			if (lastNumber != lastSquareNumber)	break;

			number /= 10;
			squareNumber /= 10;
			// ���� ������ ����� ����, ������ �����������
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