﻿/* Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли первое число кратным второму. Если число 1 не кратно числу 2,
 то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/


Console.WriteLine("Введите первое число");
int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int second = Convert.ToInt32(Console.ReadLine());

if (first  % 2 == second % 2) 
{
   Console.WriteLine("Кратно!"); 
}

else 
{
    Console.WriteLine("Не является кратным; Остаток " + first % second);
}