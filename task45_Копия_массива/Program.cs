/*
Напишите программу, которая будет создавать копию
заданного массива с помощью поэлементного копирования.
*/ 
int Prompt(string massage)
{
    System.Console.Write(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int[] Reverse(int[] array)
{
    for (int i = 0; i < array.Length ; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;
}

void PrintArray(int[] arrayOne)
{
    System.Console.WriteLine("Массив:");
    for (int i = 0; i < arrayOne.Length; i++)
    {
        System.Console.Write(arrayOne[i]);
        if (i < arrayOne.Length - 1)
            System.Console.Write("\t");
    }
    System.Console.WriteLine();
}

int length = Prompt("Длина массива: ");
int min = Prompt("Минимальное значение: ");
int max = Prompt("Максимальное значене: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);
PrintArray(Reverse(array));