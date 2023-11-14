/*Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя*/

Console.Write("Укажите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Укажите количество столбцов: ");
int cols = int.Parse(Console.ReadLine());
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

void TransposeArray( ref int[,] arr)// ref -модификатор передачи назначения 
{
    int rows = arr.GetLength(0);
    int cols = arr.GetLength(1);
    int[,] PrintNewArray = new int[cols, rows];
    if (rows == cols)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                PrintNewArray[j, i] = arr[i, j];
            }
        }
        arr = PrintNewArray; // присваиваем PrintNewArray массиву array
    }
    else
    {
        Console.WriteLine("Невозможно заменить строки на столбцы, так как количество строк не равно количеству столбцов.");
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
Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine("Массив после замены строк на столбцы:");
TransposeArray(ref array);
PrintNewArray(array);
