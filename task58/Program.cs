// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Enter the size of matrix A - m x n and matrix B - n x l");
Console.Write("Enter  m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter  n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the size of matrix B - n x l");
Console.Write("Enter  l: "); // потому что n одинаково в обеих матрицах
int l = Convert.ToInt32(Console.ReadLine());

int[,] matrixA = FillMatrixRandom(m, n);
int[,] matrixB = FillMatrixRandom(n, l);
int[,] matrixRes = new int[m, l];

PrintMatrix(matrixA);
Console.WriteLine();
PrintMatrix(matrixB);
Console.WriteLine();

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

for (int i = 0; i < matrixA.GetLength(0); i++)
{
    for (int j = 0; j < matrixB.GetLength(1); j++)
    {
        matrixRes[i, j] = 0;
        for (int k = 0; k < matrixA.GetLength(1); k++)
        {
            matrixRes[i, j] += matrixA[i, k] * matrixB[k, j];
        }
    }
}

PrintMatrix(matrixRes);