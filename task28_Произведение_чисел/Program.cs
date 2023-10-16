/*
28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/ 
System.Console.Write("Введите число: ");
int userA = Convert.ToInt32(Console.ReadLine());

int Summer(int number)
{
    int summ = 1;
    for (int i = 1; i <= number; i++)
    {
        summ = summ * i;
    }
    return summ;
}

int userResult = Summer(userA);
System.Console.WriteLine(userResult);