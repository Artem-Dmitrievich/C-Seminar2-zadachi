﻿// Напишите программу,которая выводит случайное число из 
//отрезка [10, 99] и показывает наибольшую цифру числа
//78 -> 8
//12 -> 2
//85 -> 8

int x = new Random().Next(10, 100);
int x1, x2;
x1 = x / 10;
x2 = x % 10;
Console.WriteLine(x);
//Console.Write(x1);
//Console.Write(" ");
//Console.Write(x2);
if (x1 >= x2)
    Console.WriteLine(x1);
else
    Console.WriteLine(x2);