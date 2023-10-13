/*
Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число
 number и проверяет, является ли оно палиндромом.
Метод должен проверить является ли число пятизначным, в противном случае - вывести 
Число не пятизначное и False в следующей строке.
Для остальных чисел вернуть True или False.
*/
System.Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (10000 > number || number > 99999)
{
    System.Console.WriteLine("Число не пятизначное");
    return;
}
int revN = 0;
for (int i = number; i > 0; i = i / 10)
{

    revN = revN * 10 + i % 10;
}
if (number == revN)
{
    System.Console.WriteLine("Чиcло является палиндромом");

}
else
{
    System.Console.WriteLine("Не является палиндромом");
}
