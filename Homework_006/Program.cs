﻿/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n % 2 == 0){
    Console.WriteLine("да");
}
else Console.WriteLine("нет");