﻿/* Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

// int ThreeDigitNumber = new Random().Next(100, 1000);  //берем случайное число трехзначное
// int secondDigit = ThreeDigitNumber / 10 % 10;                   //делим 3-зн число на 10 и делим на  остаток от деления на 10 и получаем 2 число
// Console.WriteLine(ThreeDigitNumber);                  //выводим результат : само 3-зн число
// Console.Write( secondDigit );                    //вторая цифра числа

Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);          // Здесь наше число переводится в строку
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]); //из строки мы выделяем индекс 1 - это и есть вторая цифра