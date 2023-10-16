/*
24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/
/*System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
for (int i = 1; i <= number; i++)
    {
     result = result + i;
     
    }

System.Console.WriteLine(result);*/

System.Console.Write("Введите число: ");
int userA = Convert.ToInt32(Console.ReadLine());

int Summer(int number)
{
    int summ = 0;
    for (int i = 1; i <= number; i++)
    {
        summ = summ + i;
    }
    return summ;
}

int userResult = Summer(userA);
System.Console.WriteLine(userResult);