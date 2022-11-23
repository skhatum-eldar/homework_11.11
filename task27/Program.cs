// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Enter the number");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

if(number > 0)
{
    while (number > 0)
{
    int digit = number % 10;
    number = number / 10;
    sum = sum + digit;
}
Console.WriteLine("The total is " + sum);
}

else
{
    number = Math.Abs(number);
    while (number > 9)
{
    int digit = number % 10;
    number = number / 10;
    sum = sum + digit;
}
Console.WriteLine($"The total is {sum - number}");
}


