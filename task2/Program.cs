// **Задача 2:** Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7a = 2 b = 10 -> max = 10a = -9 b = -3 -> max = -3

Console.WriteLine("Enter the 1st number ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the 2nd number ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA > numB)
{
    Console.Write($"max = {numA}, min = {numB}");
}

else if (numA < numB)
{
    Console.Write($"max = {numB}, min = {numA}");
}

else
{
    Console.Write($"max = min = {numA}");
}