﻿/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/ 
System.Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число В: ");
int numberB = Convert.ToInt32(Console.ReadLine());
double result = Math.Pow(numberA, numberB);
System.Console.WriteLine(result);