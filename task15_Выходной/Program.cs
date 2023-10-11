/*
15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.
*/
Console.WriteLine("Введите номер дня недели: ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA > 0 && numberA <= 5)
{
    System.Console.WriteLine("Рабочий день!");
}
else if (numberA == 6 || numberA == 7)
{
    System.Console.WriteLine("Ура!Выходной!");
}
else 
{
    System.Console.WriteLine("Нет такого дня недели");
}