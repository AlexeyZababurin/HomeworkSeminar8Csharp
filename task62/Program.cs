// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillSpiralMassive(int rows, int columns)
{
    int[,] spiralMassive = new int[rows, columns];
    int num = 1;
    int rowStart = 0, rowEnd = rows - 1;
    int columnStart = 0, columnEnd = columns - 1;

    while (num <= rows * columns)
    {
        for (int i = columnStart; i <= columnEnd; i++)
        {
            spiralMassive[rowStart, i] = num++;
        }
        rowStart++;

        for (int i = rowStart; i <= rowEnd; i++)
        {
            spiralMassive[i, columnEnd] = num++;
        }
        columnEnd--;

        if (rowStart <= rowEnd)
        {
            for (int i = columnEnd; i >= columnStart; i--)
            {
                spiralMassive[rowEnd, i] = num++;
            }
            rowEnd--;
        }

        if (columnStart <= columnEnd)
        {
            for (int i = rowEnd; i >= rowStart; i--)
            {
                spiralMassive[i, columnStart] = num++;
            }
            columnStart++;
        }
    }
    Console.WriteLine($"Создан массив [{rows}x{columns}] заполненный спирально");
    Print2DMassive(spiralMassive);
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
FillSpiralMassive(rows, columns);
