﻿/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Напиши порядковый номер дня недели (1-7): ");
int dayWeek = Convert.ToInt32(Console.ReadLine());

while(dayWeek < 1 | dayWeek > 7) {
    Console.WriteLine("В какой вселенной это день недели? Повторите ввод (1-7): ");
    dayWeek = Convert.ToInt32(Console.ReadLine());
}
if (dayWeek == 1) Console.WriteLine ("Понедельник - не выходной!");
else if (dayWeek == 2) Console.WriteLine ("Вторник - не выходной!");
else if (dayWeek == 3) Console.WriteLine ("Среда - не выходной!");
else if (dayWeek == 4) Console.WriteLine ("Четверг - не выходной!");
else if (dayWeek == 5) Console.WriteLine ("Пятница - не выходной!");
else if (dayWeek == 6) Console.WriteLine ("Суббота - Ура выходной!");
else if (dayWeek == 7) Console.WriteLine ("Воскресенье - Ура выходной!");