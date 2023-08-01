// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FindRowSmallestSum(int[,] massive)
{
    int minSum = 0;
    int rowMinSum = 0;
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            sum += massive[i, j];
        }
        if (i == 0) minSum = sum;
        if (sum < minSum)
        {
            minSum = sum;
            rowMinSum = i;
        }
    }
    Console.Write($"{rowMinSum + 1} строка содержит минимальную сумму элементов");
}

void Print2DMassive(int[,] massive)
{
    for(int i = 0; i < massive.GetLength(0); i++)
    {
        for(int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]}\t", -2);
        }
        Console.WriteLine();
    }
}

int[,] Create2DMassive(int rows, int columns, int startValue, int finishValue)
{
    int[,] matrix = new int[rows, columns];
    rows = columns;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(startValue, finishValue + 1);
        }
    }
    return matrix;
}

int GetInput (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = GetInput("Введите число строк: ");
int columns = GetInput("Введите число столбцов: ");
int[,] massive = Create2DMassive(rows, columns, 1, 10);
Print2DMassive(massive);
Console.WriteLine();
FindRowSmallestSum(massive);
