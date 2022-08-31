// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        { Console.Write($"{inArray[i, j]} "); }
        Console.WriteLine();
    }
}

void MaxToMinArray(int[,] array, int rows, int columns)
{

    int k = 0;
    int[] rowArray = new int[columns];
    for (k = 0; k < rows; k++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowArray[j] = array[k, j];

        }
        System.Console.WriteLine();
        Array.Sort(rowArray);
        Array.Reverse(rowArray);
        for (int i = 0; i < rowArray.Length; i++)
        {
            System.Console.Write($"{rowArray[i]} ");
        }
    }
}

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] newArray = GetArray(rows, columns, 0, 10);
PrintArray(newArray);
MaxToMinArray(newArray, rows, columns);
