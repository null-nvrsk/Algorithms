// [���������� ������]
// � ���������� �������� �����, ���� �� ����� ������ 0. ���������� ������� 
// �������������� ���� ������������� ������ �����, �������������� �� 8.

#include "Main.h"

#include <locale.h>
#include <stdio.h>

int main(int argc, const char* argv[]) {
	setlocale(LC_ALL, "Russian"); // ����� ������� �����
	
	printf("������� ����� ����� (0 - �����)\n");

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

	// ������� ���������
	if (totalCount > 0)
	{
		float average = (float)totalSum / (float)totalCount;
		printf("������� �������������� ���� ������������� ������ �����, �������������� �� 8 = %f", average);
	}
	else
		printf("��� ����� ���������� ��� �������");

	getchar();
	return 0;
}
