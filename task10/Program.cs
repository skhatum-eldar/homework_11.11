// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(100, 1000);
Console.WriteLine($"The number is {number}");
Console.WriteLine($"The 2nd digit is {(number/10)%10}");

// Console.WriteLine("Enter the number");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 99 && number < 1000)
// {
//     Console.WriteLine($"The number is {number}");
//     Console.WriteLine($"The 2nd digit is {(number/10)%10}");
// }
// else
// {
//     Console.WriteLine("It should be 3 digit number!");
// }