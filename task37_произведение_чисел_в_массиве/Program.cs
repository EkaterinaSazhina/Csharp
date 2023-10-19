/*
Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 12 10
*/
int[] array = { 1, 2, 3, 4, 5 };
int[] newArray = GetNewArray(array);
PrintArray(newArray);
int[] GetNewArray(int[] arr)
{
    int[] newArray = new int[arr.Length / 2];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        if (arr.Length % 2 == 0)
        {
            newArray[i] = arr[i] * arr[arr.Length - 1 - i];
        }
        else if (arr.Length % 2 == 1)
        {
            int number = arr.Length / 2 + 1;
            newArray[i] = arr[i] * arr[arr.Length - 1 - i];
        }
    }
    return newArray;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine("]");
}

