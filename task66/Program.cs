// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Numbers (int m, int n)
{
    if (m >= n)
    {
    if (m == n) return m;
    return n + Numbers(m, n+1);
    }
    else
    {
    if (m == n) return n;
    return m + Numbers(m+1, n);
    }
}


Console.Write("Enter  the number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter  the number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Numbers(m, n));