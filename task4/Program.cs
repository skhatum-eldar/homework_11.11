﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Enter the 1st number ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the 2nd number ");
int numB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the 3rd number ");
int numC = Convert.ToInt32(Console.ReadLine());

if (numA > numB)
{
    if (numA < numC)
    {
        Console.WriteLine(numC);
    }
    else
    {
        Console.WriteLine(numA);
    }
}
else
{
    if (numB < numC)
    {
        Console.WriteLine(numC);
    }
    else
    {
        Console.WriteLine(numB);
    }
}