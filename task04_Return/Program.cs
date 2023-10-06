/*
Внутри класса Answer напишите метод FindMax, который принимает на вход три числа
 и выдаёт максимальное из этих чисел.
*/
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int c = Convert.ToInt32(Console.ReadLine());
int result = a;
if(b > a)
{
    result = b;
}
if(c > b)
{
    result = c;
}
System.Console.WriteLine(result);
