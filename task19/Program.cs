// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Enter the 5 digit number");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);

if (numberText.Length == 5 & numberText[0] == numberText[4] & numberText[1] == numberText[3])
{
    Console.WriteLine("YES! It's a palindrome!");
}
else
{
    Console.WriteLine("NOPE! It's not a palindrome!");
}