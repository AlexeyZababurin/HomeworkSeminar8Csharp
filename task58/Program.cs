// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] ProducTwoMassive(int[,] massive1, int[,] massive2)
{
    int[,] result = new int[massive1.GetLength(0), massive2.GetLength(1)];
    for (int i = 0; i < massive1.GetLength(0); i++)
    {
        for (int j = 0; j < massive2.GetLength(1); j++)
        {
            for (int k = 0; k < massive1.GetLength(1); k++)
            {
                result[i, j] += massive1[i, k] * massive2[k, j];
            }
        }
    }
    return result;
}

void Print2DMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] Create2DMassive(int rows, int columns, int startValue, int finishValue)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(startValue, finishValue);
        }
    }
    return matrix;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int rows1 = GetInput("Введите количество строк 1-й матрицы: ");
int columns1 = GetInput("Введите количество столбцов 1-й матрицы: ");
int rows2 = GetInput(@"Введите количество строк 2-й матрицы.
Оно должно быть равно количеству столбцов для 1-й матрицы: ");
int columns2 = GetInput("Введите количество столбцов 2-й матрицы: ");
Console.WriteLine();

if (columns1 != rows2)
{
    Console.WriteLine(@"Количество строк 2-й матрицы должно быть равно количеству столбцов 1-й!
Повторите ввод.");
    return;
}

int[,] massive1 = Create2DMassive(rows1, columns1, 1, 10);
int[,] massive2 = Create2DMassive(rows2, columns2, 1, 10);
int[,] resultMassive = ProducTwoMassive(massive1, massive2);
Console.WriteLine("Первая матрица");
Print2DMassive(massive1);
Console.WriteLine();
Console.WriteLine("Вторая матрица");
Print2DMassive(massive2);
Console.WriteLine();
Console.WriteLine("Результирующая матрица");
Print2DMassive(resultMassive);
