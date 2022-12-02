// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Enter the size of matrix m x n");
Console.Write("Enter  m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter  n: ");
int n = Convert.ToInt32(Console.ReadLine());
double average = 0;

double [,] matrix = new double [m,n];
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        matrix[i,j] = new Random().Next(0,11);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}

for(int j = 0; j < n; j++)
{
    for(int i = 0; i < m; i++)
    {
        average+=matrix[i,j];        
    }
    Console.Write(Math.Round(average/m, 1) + "; ");
    average = 0;
}