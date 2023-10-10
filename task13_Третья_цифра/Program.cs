/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
for (int i = number; i > 100; i /= 10)
{
    result = i % 10;
}
if (number < 100)
{
    Console.WriteLine("Нет третьей цифры");
}
else
{
    Console.WriteLine($"Третья цифра = {result}");
}