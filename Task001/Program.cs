﻿// // Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите число  ");  // поставить условие для ввода данных
int numberA = Convert.ToInt32(Console.ReadLine());  // прием вводных данных

if (numberA > 99&numberA < 1000) // условие проверки
{
    int result = numberA % 10;  // последняя цифра
    Console.WriteLine(result);  // выводит результат
}
else  // проверка не прошла
{
    Console.WriteLine("число не трехзначное");
}