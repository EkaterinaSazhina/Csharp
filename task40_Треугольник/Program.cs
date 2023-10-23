/*
Напишите программу, которая принимает на вход три числа и
проверяет, может ли существовать треугольник с сторонами такой длины.
*/ 
System.Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());
bool Triangle (int numberA,int numberB,int numberC)
{
    if(numberA<numberB+numberC && numberB<numberA+numberC && numberC< numberB+numberA) return true;
    else return false;
}
bool userNumber = Triangle ( numberA, numberB, numberC);
System.Console.WriteLine(userNumber);