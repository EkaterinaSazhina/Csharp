/*
Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает на вход координаты двух точек pointA и pointB в виде массива целых чисел, 
и возвращает расстояние между ними в 3D пространстве.
*/ 
Console.WriteLine("Введите координаты точки A (x,y,z): ");
int userAx = Convert.ToInt32(Console.ReadLine());
int userAy = Convert.ToInt32(Console.ReadLine());
int userAz = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B (x,y,z): ");
int userBx = Convert.ToInt32(Console.ReadLine());
int userBy = Convert.ToInt32(Console.ReadLine());
int userBz = Convert.ToInt32(Console.ReadLine());
double squareX = Math.Pow(userBx - userAx, 2);
double squareY = Math.Pow(userBy - userAy, 2);
double squareZ = Math.Pow(userBz - userAz, 2);
double rootXY = Math.Sqrt(squareX + squareY+squareZ);
System.Console.WriteLine(Math.Round(rootXY, 2));