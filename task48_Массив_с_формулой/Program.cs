/*
Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
Выведите полученный массив на экран.
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
            matr[i,j] =  i+j;
        }
    }
}

PrintArray(matrix);
FeelArray(matrix);
System.Console.WriteLine();
PrintArray(matrix);