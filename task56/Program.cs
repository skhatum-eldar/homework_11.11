// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Enter the size of matrix m x n");
Console.Write("Enter  m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter  n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixRandom(m, n);
PrintMatrix(matrix);
Console.WriteLine();
LineFound(matrix);

int[,] FillMatrixRandom(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void LineFound(int[,] array)
{
    int sum = 0;
    int sumNewMin = 10000;
    int k = 0;
    int temp = 0;
    int[,] minSum = new int[1, matrix.GetLength(0)];
    int minEl = minSum[0, 0];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
            minSum[0, k] = sum;
        }
        if (sum < sumNewMin)
        {
            sumNewMin = sum;
            temp = i + 1;
        }
        k++;
        sum = 0;
        if (i == matrix.GetLength(0) - 1) Console.WriteLine("THE LINE WITH MINIMUM SUM IS " + temp);
    }
}