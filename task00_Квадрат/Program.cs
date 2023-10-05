/*
0. Напишите программу, которая на вход принимает число и выдаёт
 его квадрат (число умноженное на само себя).
*/
System.Console.WriteLine("Введите число: "); //cw быстрый вызов Console.WriteLine
int userNamber = Convert.ToInt32(Console.ReadLine());
int result = userNamber * userNamber;
Console.WriteLine(result);
