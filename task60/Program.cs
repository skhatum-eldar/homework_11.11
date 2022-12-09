// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Enter the size of array a x b x c");
Console.Write("Enter  a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter  b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter  c: ");
int c = Convert.ToInt32(Console.ReadLine());

int[,,] array3DNew = new int[a, b, c];
CheckNumbers(array3DNew);
WriteArray(array3DNew);

// void CreateArray3D(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 array[i, j, k] = new Random().Next(10, 100);
//             }
//         }
//     }
// }

void CheckNumbers(int[,,] array)
{
    int count = 1;
    while (count != 0)
    {
        count = 0;
        int temp = array[0,0,0];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    array[i, j, k] = new Random().Next(10, 100);
                    if (array[i,j,k] == temp)
                    {
                        temp = new Random().Next(10, 100);
                        array[i,j,k] = temp;
                        count++;
                        i = 0;
                        j = 0;
                        k = 0;
                    }
                }
            }
        }
    }
}

void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}