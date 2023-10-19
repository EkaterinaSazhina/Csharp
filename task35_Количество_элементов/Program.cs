/*
Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99]. 
*/

int size = 123;
int[] array = new int[size];
int[] GetArray(int size)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-99, 99);
    }
    return array;
}
void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.WriteLine("]");
}
int CountGetArray(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 10 && arr[i] <= 99)
            {
                count++;
            }
        }
        return count;
    }
int[] userArray = GetArray(size);
int countArray = CountGetArray(userArray);
PrintArray(userArray);
System.Console.WriteLine("Количество элементов лежащих в отрезке :" + countArray);