/*
16.Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/
System.Console.WriteLine("Введите число: ");
int namberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число: ");
int namberB = Convert.ToInt32(Console.ReadLine());
if (namberA * namberA == namberB || namberB * namberB == namberA)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}