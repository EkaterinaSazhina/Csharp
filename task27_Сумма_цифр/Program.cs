/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int Sum(int num)
{
    int root = 0;
    int result = 0;
    for (int i = number; i > 0; i = i / 10)
    {
        root = i % 10;
        result = result + root;
    }
    return result;
}
int userResalt = Sum(number);
System.Console.WriteLine(userResalt);