﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Enter the number from 1 to 7");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5)
{
    Console.WriteLine("NOPE!:(");
}
else if (number == 6 || number == 7)
{
    Console.WriteLine("YAASS!:)");
}
else
{
    Console.WriteLine("There are only 7 days in a week ;)");
}