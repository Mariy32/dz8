// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// int[,] Create2DRandomArray ( int rows, int columns)
// {
// int[,] newArray = new int[rows,columns];
 
// for(int i = 0; i < rows; i++)
// {
// for(int j = 0; j < columns; j++)
// {
// newArray[i,j] = new Random().Next(0,100);
// }
// }
// return newArray;
// }

// void Show2DArray(int[,] array)
// {
// for(int i = 0; i < array.GetLength(0); i++)
// {
// for(int j = 0; j < array.GetLength(1); j++)
// {
// Console.Write(array[i,j]+" ");
// }
// Console.WriteLine();
// }
// }

// void Rows(int[,] array)
// {
// for(int i = 0; i < array.GetLength(0); i++)
// {
// for(int j = 0; j < array.GetLength(1); j++)
// {
// for(int a = 0; a < array.GetLength(1) - 1; a++)
// {
// if (array [i,a] < array [i,a + 1])
// {
//   int temp = array [i,a + 1];
//   array [i,a + 1]=array [i,a];
//   array [i,a] = temp; 
// }
// }
// }
// }
// }

// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2DRandomArray(m,n);
// Show2DArray(myArray);
// Rows(myArray);
// Console.WriteLine();
// Show2DArray(myArray);



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] Create2DRandomArray ( int rows, int columns)
// {
// int[,] newArray = new int[rows,columns];
 
// for(int i = 0; i < rows; i++)
// {
// for(int j = 0; j < columns; j++)
// {
// newArray[i,j] = new Random().Next(0,100);
// }
// }
// return newArray;
// }

// void Show2DArray(int[,] array)
// {
// for(int i = 0; i < array.GetLength(0); i++)
// {
// for(int j = 0; j < array.GetLength(1); j++)
// {
// Console.Write(array[i,j]+" ");
// }
// Console.WriteLine();
// }
// }

// int Summin(int[,] array, int i)
// {
// // for(int i = 0; i < array.GetLength(0); i++)
// // {
// int sum = array[i,0];
// for(int j = 0; j < array.GetLength(1); j++)
// {
// sum = sum + array [i,j];
// }
// return sum;
// }
// void rows(int[,] array)
// {
// int min = 0;
// int summin = Summin(array, 0);
// for(int i = 0; i < array.GetLength(0); i++)
// {
// int temp = Summin(array, i);;
// if ( summin < temp)
// min = i;
// }
// Console.Write($"Строка с минимальной суммой - {min}");
// }
// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2DRandomArray(m,n);
// Show2DArray(myArray);
// Console.WriteLine();
// rows (myArray);





// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// int[,] Create2DRandomArray ( int m, int n)
// {
// int[,] newArray = new int[m,n];
 
// for(int i = 0; i < m; i++)
// {
// for(int j = 0; j < n; j++)
// {
// newArray[i,j] = new Random().Next(0,100);
// }
// }
// return newArray;
// }
// int[,] Create2DRandomArray2 ( int a, int b)
// {
// int[,] newArray2 = new int[a,b];
 
// for(int i = 0; i < a; i++)
// {
// for(int j = 0; j < b; j++)
// {
// newArray2[i,j] = new Random().Next(0,100);
// }
// }
// return newArray2;
// }

// void Show2DArray(int[,] array)
// {
// for(int i = 0; i < array.GetLength(0); i++)
// {
// for(int j = 0; j < array.GetLength(1); j++)
// {
// Console.Write(array[i,j]+" ");
// }
// Console.WriteLine();
// }
// }

// int matrix(int[,] array)
// {
// for(int i = 0; i < array.GetLength(0); i++)
// {
// for(int j = 0; j < array.GetLength(1); j++)
// {
//     Matrix [i,j] = 0;
//     for (int v = 0; v < array.GetLength(1); v++)
//     {
//         Matrix [i,j] = array[i,v] * array[v,j];
//     }
//     }
// }
// return Matrix [i,j];
// }

// Console.Write("Введите количество строк 1 матрицы ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов 1 матрицы ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество строк 2 матрицы ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов 2 матрицы ");
// int b = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2DRandomArray(m,n);
// int[,] myArray2 = Create2DRandomArray2(a,b);
// Show2DArray(myArray);
// Console.WriteLine();
// Show2DArray(myArray2);
// Console.WriteLine();
// matrix (myArray);



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



// int[,,] GetArray(int[] sizes, int min, int max)
// {
//     int[,,] result = new int[sizes[0], sizes[1], sizes[2]];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             int k = 0;
//             while (k < result.GetLength(2))
//             {
//                 int element = new Random().Next(min, max + 1);
//                 if (FindElement(result, element)) continue;
//                 result[i, j, k] = element;
//                 k++;
//             }
//         }
//     }
//     return result;
// }


//         bool FindElement(int[,,] array, int el)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 if (array[i, j, k] == el) return true;
//             }
//         }
//     }
//     return false;
// }
// void PrintArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
//             }
//             Console.WriteLine();

//             Console.ReadKey();
//         }
//     }
// }

// Console.WriteLine("Введите размеры массива через пробел: ");
// string[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int[,,] array = GetArray(new int[] { int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2]), }, 10, 99);
// PrintArray(array);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



    int[,] GetArray(int size)
    {
      int [,] result = new int[size, size];
      int i = 0;
      int j = 0;
      int rowE = size - 1;
      int columnE = size - 1;
      int rowS = 0;
      int columnS = 0;
      bool left = true;
      bool top = true;
      int count = 0;
      while (count < size * size)
      {
        count++;
        result[i, j] = count;
    
        if (left && top)
        {
          if (j == columnE)
          {
            rowS++;
            top = true;
            left = false;
            i++;
            continue;
          }
          else
          {
            j++;
              continue;
          }
        }
        //идем вниз
        if (!left && top)
        {
          if (i == rowE)
          {
            columnE--;
            top = false;
            left = false;
            j--;
            continue;
          }
          else
          {
            i++;
            continue;
          }
        }
        
        if (!left && !top)
        {
          if (j == columnS)
          {
            rowE--;
            top = false;
            left = true;
            i--;
            continue;
          }
          else
          {
            j--;
            continue;
      }
    }
       if (left && !top)
        {
          if (j == rowS)
          {
            columnS++;
            top = true;
            left = true;
            j++;
            continue;
          }
          else
          {
            i--;
            continue; 
          }
        }
      }
      return result;
    }
    void PrintArray(int[,] inArray)
    {
      for (int i = 0; i < inArray.GetLength(0); i++)
      {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
          Console.WriteLine($"{inArray[i, j]} ");
        }
        Console.WriteLine();
      }
    }
    Console.WriteLine($"Введите размер матрицы: ");
    int s = int.Parse(Console.ReadLine());
    int[,] arr = GetArray(s);
    PrintArray(arr);

  