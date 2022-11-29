// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Enter k1 number ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter b1 number ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter k2 number ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter b2 number ");
double b2 = Convert.ToInt32(Console.ReadLine());

if ((k1 == k2 & b1 == b2) || (k1 == k2))
{
    Console.WriteLine("OOPS! TRY AGAIN!");
}
else
{
    Console.WriteLine("THE COORDINATES OF INTERSECTION OF TWO LINES ARE " + 
    "(" + (b2-b1)/(k1-k2) + "; " + ((k1*(b2-b1)/(k1-k2)) + b1) + ")");
}