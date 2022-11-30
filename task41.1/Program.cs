// Дополнительная задача на рекурсию (необязательная)
// Напишите программу для подсчета количества цифр в числе с помощью рекурсии.
// 12345 -> 5

int count = 0;
void DigitsAmount (int number)
{
    if (number == 0)
    {
        return;
    }
    count++;
    DigitsAmount(number/10);
}

Console.WriteLine("Enter the number");
int number = Convert.ToInt32(Console.ReadLine());
DigitsAmount(number);
Console.Write("The amount of digits is " + count);