// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.Write("Enter m: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// AkkermanFunction(m,n);


// void AkkermanFunction(int m, int n)
// {
//     Console.Write(Akkerman(m, n)); 
// }

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
// }


// Pascal Triangle
// using System;

// namespace PascalTriangle
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Read the number of elements to generate
//             Console.Write("Enter the number of elements: ");
//             int n = Convert.ToInt32(Console.ReadLine());

//             // Initialize the first row of the triangle
//             int[] row = { 1 };

//             // Print the first row
//             Console.WriteLine("1");

//             // Generate the remaining rows
//             for (int i = 1; i < n; i++)
//             {
//                 // Initialize the next row with a leading 1
//                 int[] nextRow = new int[i + 1];
//                 nextRow[0] = 1;

//                 // Calculate the elements of the row
//                 for (int j = 1; j < i; j++)
//                 {
//                     nextRow[j] = row[j - 1] + row[j];
//                 }

//                 // Add a trailing 1 to the row
//                 nextRow[i] = 1;

//                 // Print the row
//                 Console.WriteLine(string.Join(" ", nextRow));

//                 // Set the current row to the next row
//                 row = nextRow;
//             }
//         }
//     }
// }


// Ping Pong
// using System;

// namespace PingPong
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Set the starting position and velocity of the ball
//             int x = 0;
//             int y = 0;
//             int vx = 1;
//             int vy = 1;

//             // Set the dimensions of the game field
//             int width = 20;
//             int height = 10;

//             // Loop until the ball goes out of bounds
//             while (x >= 0 && x < width && y >= 0 && y < height)
//             {
//                 // Update the position of the ball
//                 x += vx;
//                 y += vy;

//                 // Check if the ball has hit a wall
//                 if (x == 0 || x == width - 1)
//                 {
//                     vx *= -1;
//                 }
//                 if (y == 0 || y == height - 1)
//                 {
//                     vy *= -1;
//                 }

//                 // Print the current position of the ball
//                 Console.WriteLine($"({x}, {y})");
//             }
//         }
//     }
// }


using System;

namespace PingPong
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set the starting position and velocity of the ball
            int x = 0;
            int y = 0;
            int vx = 1;
            int vy = 1;

            // Set the dimensions of the game field
            int width = 20;
            int height = 10;

            // Set the position of the computer's paddle
            int computerY = 0;

            // Loop until the ball goes out of bounds
            while (x >= 0 && x < width && y >= 0 && y < height)
            {
                // Update the position of the ball
                x += vx;
                y += vy;

                // Check if the ball has hit a wall
                if (x == 0 || x == width - 1)
                {
                    vx *= -1;
                }
                if (y == 0 || y == height - 1)
                {
                    vy *= -1;
                }

                // Check if the ball has hit the computer's paddle
                if (x == 1 && y == computerY)
                {
                    vx *= -1;
                }

                // Prompt the user to move their paddle
                Console.WriteLine("Move your paddle (up/down):");
                string input = Console.ReadLine();

                // Update the position of the user's paddle
                if (input == "up")
                {
                    y--;
                }
                else if (input == "down")
                {
                    y++;
                }

                // Update the position of the computer's paddle
                if (y < computerY)
                {
                    computerY--;
                }
                else if (y > computerY)
                {
                    computerY++;
                }

                // Print the current position of the ball
                Console.WriteLine($"Ball: ({x}, {y})");
                Console.WriteLine($"Computer: ({1}, {computerY})");
            }
        }
    }
}