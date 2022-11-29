// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int [] FillArray(int size)
{
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

Console.Write("Enter the length of the array ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Enter {num} numbers and after each put ENTER");
int[] array = FillArray(num);
Console.WriteLine("Your numbers are " + string.Join(", ", array)); 

for (int i = 0, count = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
    if (i == array.Length - 1)
    {
        Console.WriteLine("The amount of positive numbers is " + count);
    }
}
