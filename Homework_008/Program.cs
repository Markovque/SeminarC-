﻿/* Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int even = 2;                                    //even - "четный"
while (n >= even){
    Console.Write( even + ", ");
    even += 2;
}





