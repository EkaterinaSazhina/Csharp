/*
Задайте двумерный массив размером m×n,
заполненный случайными целыми числами.
*/ 
System.Console.Write("Укажите количество строк: ");
int userM = int.Parse(System.Console.ReadLine());
System.Console.Write("Укажите количество столбцов: ");
int userN = int.Parse(System.Console.ReadLine());
int[,] matrix = new int[userM, userN];
void PrintArray(int[,] matr)
{

    for (int i = 0; i < userM; i++)
    {
        for (int j = 0; j < userN; j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FeelArray(int[,]matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] =  new Random().Next(1,10);
        }
    }
}

PrintArray(matrix);
FeelArray(matrix);
System.Console.WriteLine();
PrintArray(matrix);