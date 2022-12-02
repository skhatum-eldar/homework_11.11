// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Enter the size of matrix m x n");
Console.Write("Enter  m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter  n: ");
int n = Convert.ToInt32(Console.ReadLine());

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
    Console.WriteLine();

Console.Write("Enter  index of the row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter  index of the column: ");
int column = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

if (row < m & column < n)
{   Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("The number is " + matrix[row, column]);
    Console.ForegroundColor = ConsoleColor.Gray;}
else Console.WriteLine("OOPS! IT DOESN'T EXIST");

for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        if (i == row & j == column) Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(matrix[i,j] + " ");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    Console.WriteLine();
}