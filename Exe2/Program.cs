// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Задача задана методом распределения двумерного массива в одномерный, где в одномерном массиве
// элементами являются суммы строк двумерного массива, затем поиск минимального элемента и определение его индекса

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
            Console.Write($"{inArray[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintOneDimArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        System.Console.Write($"{array[i]} ");
    System.Console.WriteLine();
}

int[] FindSummInRows(int[,] array, int rows, int columns) // Находим суммы в строках 
{                                                         // и заносим в одномерный массив
    int summRow = 0;
    int[] columnArray = new int[columns]; // массив столбцов
    int[] rawArray = new int[rows]; // массив строк

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            columnArray[j] = array[i, j];
            summRow = summRow + columnArray[j];
        }
        rawArray[i] = summRow;
        summRow = 0;
    }
    return rawArray;
}

void FindMinimalSumm(int[] array)
{
    int min = array[0];
    int minIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= min)
        {
            min = array[i];
            minIndex = i;
        }
    }
    System.Console.WriteLine($"Строка с минимальной суммой элементов {minIndex + 1}");
}

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] newArray = GetArray(rows, columns, 0, 10);
int[] someArray = FindSummInRows(newArray, rows, columns);

PrintArray(newArray); // Заданный массив
PrintOneDimArray(someArray); // Показываем массив сумм строк
FindMinimalSumm(someArray); // находим минимальный элемент в массиве


