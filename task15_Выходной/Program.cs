/*
15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.
*/
Console.WriteLine("Введите номер дня недели: ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA == 1) Console.WriteLine("Понедельник-рабочий день");
if (numberA == 2) Console.WriteLine("Вторник-рабочий день");
if (numberA == 3) Console.WriteLine("Среда-рабочий день");
if (numberA == 4) Console.WriteLine("Четверг-рабочий день");
if (numberA == 5) Console.WriteLine("Пятница-рабочий день");
if (numberA == 6) Console.WriteLine("Суббота!Ура выходной!");
if (numberA == 7) Console.WriteLine("Воскресенье!Ура выходной!");
else if (numberA > 7) System.Console.WriteLine("нет такого дня недели");