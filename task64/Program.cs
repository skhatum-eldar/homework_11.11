﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void Numbers (int n)
{
    if (n == 0) return;
    Numbers(n - 1);
    Console.Write(n + " ");
}

Console.Write("Enter  the number: ");
int n = Convert.ToInt32(Console.ReadLine());
Numbers(n);