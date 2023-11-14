/*
Задайтедвумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7
*/
Console.Write("Укажите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Укажите количество столбцов: ");
int cols = int.Parse(Console.ReadLine());
int[,] arr = new int[rows, cols];
FillArray(arr);
int minVal = arr[0, 0];
int minRow = 0;
int minCol = 0;
FindMinValue(arr, ref minVal, ref minRow, ref minCol);
Console.WriteLine("Исходный массив:");
PrintArray(arr);
int[,] newArr = RemoveRowAndColumn(arr, minRow, minCol);
Console.WriteLine("Массив после удаления:");
PrintNewArray(newArr);
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(1, 10);
        }
    }
}
void FindMinValue(int[,] arr, ref int minVal, ref int minRow, ref int minCol)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < minVal)
            {
                minVal = arr[i, j];
                minRow = i;
                minCol = j;
            }
        }
    }
}

int[,] RemoveRowAndColumn(int[,] arr, int rowToRemove, int colToRemove)
{
    int[,] newArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    for (int i = 0, k = 0; i < arr.GetLength(0); i++)
    {
        if (i == rowToRemove) continue;
        for (int j = 0, l = 0; j < arr.GetLength(1); j++)
        {
            if (j == colToRemove) continue;
            newArr[k, l] = arr[i, j];
            l++;
        }
        k++;
    }
    return newArr;
}

void PrintNewArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
