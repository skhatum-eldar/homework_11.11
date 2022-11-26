// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int [] array = new int [8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
}
    Console.Write("[" + string.Join(", ", array) + "]");


int[] arr = new int [5];
for(int i = 0; i < arr.Length; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(string.Join(", ", arr));