// Задача 59. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

Console.WriteLine("Enter the size of matrix m x n");
Console.Write("Enter  m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter  n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixRandom(m, n);
PrintMatrix(matrix);
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

int indexMinI = 0;
int indexMinJ = 0;
int temp = matrix[0, 0];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] < temp)
        {
            indexMinI = i;
            indexMinJ = j;
            temp = matrix[i, j];
        }
    }
}

Console.WriteLine("The smallest element is " + temp + " with indexes " + indexMinI + " " + indexMinJ);
Console.WriteLine();

int[,] matrixNew = new int[m - 1, n - 1];
int k = 0, l = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (indexMinI != i & indexMinJ != j)
        {
            matrixNew[k, l] = matrix[i, j];
            l++;
        }
    }
    l = 0;
    if (indexMinI != i) k++;
}
PrintMatrix(matrixNew);