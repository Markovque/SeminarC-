﻿/* Задача 58: 
Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
А В
1 4 | 3 5
3 5 | 1 2

Результирующая матрица будет:
С
7 13
14 25

Произведением двух матриц А и В называется матрица С, 
элемент которой, находящийся на пересечении i-й строки и j-го столбца, 
равен сумме произведений элементов i-й строки матрицы А на 
соответствующие (по порядку) элементы j-го столбца матрицы В.

С (0,0) = А(0,0) * B(0,0) + A(0,1) * B(1,0) = 1 · 3 + 4 · 1 = 3 + 4 = 7
С (0,1) = А(0,0) * B(0,1) + A(0,1) * B(1,1) = 1 · 5 + 4 · 2 = 5 + 8 = 13
С (1,0) = А(1,0) * B(0,0) + A(1,1) * B(1,0) = 3 · 3 + 5 · 1 = 9 + 5 = 14
С (1,1) = А(1,0) * B(0,1) + A(1,1) * B(1,1) = 3 · 5 + 5 · 2 = 15 + 10 = 25

Произведение двух матриц АВ имеет смысл только в том случае, 
когда число столбцов матрицы А совпадает с числом строк матрицы В.

В произведении матриц АВ число строк равно числу строк матрицы А , 
а число столбцов равно числу столбцов матрицы В.
*/

Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] firstArray = new int[m, n];
FillArray(firstArray);
Console.WriteLine($"Первый массив:");
PrintArray(firstArray);

int[,] secondArray = new int[n, p];
FillArray(secondArray);
Console.WriteLine($"Второй массив:");
PrintArray(secondArray);

int[,] resultArray = new int[m,p];

MultiplyArray(firstArray, secondArray, resultArray);
Console.WriteLine($"Произведение первого и второго массива:");
PrintArray(resultArray);

void MultiplyArray(int[,] firstArray, int[,] secondArray, int[,] resultArray){
  for (int i = 0; i < resultArray.GetLength(0); i++)
  {
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstArray.GetLength(1); k++)
      {
        sum += firstArray[i,k] * secondArray
        [k,j];
      }
      resultArray[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}