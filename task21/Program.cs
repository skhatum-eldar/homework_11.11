// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Enter X coordinate of point A");
double xa = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Y coordinate of point A");
double ya = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Z coordinate of point A");
double za = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter X coordinate of point B");
double xb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Y coordinate of point B");
double yb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Z coordinate of point B");
double zb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"The distance between A and B is {Math.Round(Math.Sqrt(Math.Pow(xa-xb, 2) + Math.Pow(ya-yb, 2) + Math.Pow(za-zb, 2)) , 2)}");