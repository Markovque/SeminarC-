﻿/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

на обработку ввода. 
*/

///*
Console.Write("Введите колличество чисел: ");
int arr = int.Parse(Console.ReadLine());
int count = 0;
for (int i = 0; i < arr; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    int element = int.Parse(Console.ReadLine());
    if (element > 0)
        count++;
}
Console.WriteLine($"Положительных чисел: {count}");
//*/



// когда числа вводим через пробел
/*
Console.Write("Введите числа(через пробел): ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во элементов > 0: {count}");
*/
