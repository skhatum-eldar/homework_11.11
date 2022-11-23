// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Enter the number:");
// int A = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter the degree:");
// int B = Convert.ToInt32(Console.ReadLine());
// int deg = 1;

// for (int i = 1; i <= B; i++)
// {
//     deg = deg * A;
// }

// Console.WriteLine("The number " + A + " in degree " + B + " is " + deg);

int Degree(int A, int B)
{
    int deg = 1;

    for (int i = 1; i <= B; i++)
    {
    deg = deg * A;
    }
return deg;
}

Console.WriteLine("Enter the number:");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the degree:");
int B = Convert.ToInt32(Console.ReadLine());

int res = Degree(A, B);
Console.WriteLine(res);
