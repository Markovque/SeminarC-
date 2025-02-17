﻿/* Задача 47. 
Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.Write("Введите число строк массива:  ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива:  ");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m, n]; 
Random random = new Random();
Console.Write("Наш двумерный массив:");
double min = -100.0;
double max = 100.0;

void FillArray(double[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i,j] = Math.Round(random.NextDouble()*(max - min) + min, 2);
        }
    }
}

void PrintArray(double[,] array){ 
    for (int i = 0; i < array.GetLength(0); i++){ 
        for (int j = 0; j < array.GetLength(1); j++){ 
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

FillArray(array);
Console.WriteLine();
PrintArray(array);