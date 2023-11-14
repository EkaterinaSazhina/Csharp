/*
Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива
*/
System.Console.Write("Укажите количество строк: ");
int rows = int.Parse(System.Console.ReadLine());
System.Console.Write("Укажите количество столбцов: ");
int cols = int.Parse(System.Console.ReadLine());
int[,] array = new int[rows, cols];
void PrintArray(int[,] arr)
{

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FeelArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}
void ReplacingString(int[,] arr)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            int temp = array[0, i];
            array[0, i] = arr[rows - 1, i];
            arr[rows - 1, i] = temp;
        }
    }
}
void PrintNewArray(int[,] arr)
{
 int rows = arr.GetLength(0);
 int cols = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

FeelArray(array);
System.Console.WriteLine("Исходный массив:");
PrintArray(array);
ReplacingString(array);
System.Console.WriteLine("Массив после замены:");
PrintArray(array);
