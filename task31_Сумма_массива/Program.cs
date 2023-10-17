/*
Задача 31: Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20.
*/
System.Console.WriteLine("Задай размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int[] GetArray(int size)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 10);
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
            System.Console.Write(", ");//[5, 7, 1, 4]
    }
    System.Console.WriteLine("]");
}
int GetSumMinus(int[] arr)
{
    int sumMinus = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            sumMinus = sumMinus + arr[i]; // Прибавляем текущее отрицательное число к сумме
        }
    }
    return sumMinus;
}
int GetSumPlus(int[] arr)
{
    int sumPlus = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sumPlus = sumPlus + arr[i]; // Прибавляем текущее отрицательное число к сумме
        }
    }
    return sumPlus;
}
int[] userArray = GetArray(8);
int sumMinus = GetSumMinus(userArray);
int sumPlus = GetSumPlus(userArray);
PrintArray(userArray);
Console.WriteLine("Сумма отрицательных чисел массива:" + sumMinus);
Console.WriteLine("Сумма положительных чисел массива:" + sumPlus);




