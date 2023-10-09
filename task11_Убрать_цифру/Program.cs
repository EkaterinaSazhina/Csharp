/*
Напишите программу, которая выводит случайное 
трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
*/ 
int number = new Random().Next(100,1000);
System.Console.WriteLine(number);
int first = number / 100;
int three = number % 10;
int result = first * 10 + three;
Console.WriteLine(result);

