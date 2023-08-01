// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void Print3DMassive(int[,,] massive3D)
{
    for (int k = 0; k < massive3D.GetLength(2); k++)
    {
        for (int i = 0; i < massive3D.GetLength(0); i++)
        {
            for (int j = 0; j < massive3D.GetLength(1); j++)
            {
                Console.Write($"{massive3D[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] Create3DMassive(int rowSize, int columnSize, int depthSize)
{
    int[] random1DMassive = new int[rowSize * columnSize * depthSize];
    int num;
    for (int n = 0; n < random1DMassive.Length; n++)
    {
        num = new Random().Next(10, 100);
        if (random1DMassive.Contains(num))
        {
            n--;
        }
        else
        {
            random1DMassive[n] = num;
        }
    }
    int[,,] random3DMassive = new int[rowSize, columnSize, depthSize];
    int index = 0;
    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j < columnSize; j++)
        {
            for (int k = 0; k < depthSize; k++)
            {
                random3DMassive[i, j, k] = random1DMassive[index];
                index++;
            }
        }
    }
    return random3DMassive;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Введите размеры трехмерного массива.");
int y = GetInput("Количество строк массива: ");
int x = GetInput("Количество столбцов массива: ");
int z = GetInput("Глубина массива: ");
if (y * x * z > 90)
{
    Console.WriteLine("Размер массива больше диапазона возможных чисел.");
    return;
}
int[,,] massive3D = Create3DMassive(y, x, z);
Print3DMassive(massive3D);
