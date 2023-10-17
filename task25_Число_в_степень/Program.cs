/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/ 
System.Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Met(numberA, numberB);

void Met(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
    System.Console.WriteLine(result);
}