// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Enter the number");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);

if (number > -100 & number < 100)
{
    Console.WriteLine("OOPS! There is no 3rd digit");
}
else if (number < -99)
{
    Console.WriteLine($"The third digit of {number} is {numberText[3]}");
}
else
{
        Console.WriteLine($"The third digit of {number} is {numberText[2]}");
}
