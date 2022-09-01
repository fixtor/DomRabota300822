// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] array = new int[4, 4];
int n = 0;

for (int i = 0; i < 3; i++)
    array[0, i] = n++;

for (int i = 0; i < 4; i++)
    array[i, 3] = n++;

for (int i = 2; i >= 0; i--)
    array[3, i] = n++;

for (int i = 2; i > 0; i--)
    array[i, 0] = n++;

for (int i = 1; i < 3; i++)
    array[1, i] = n++;

for (int i = 2; i > 0; i--)
    array[2, i] = n++;

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
            Console.Write($" {inArray[i, j]}, ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();
PrintArray(array);