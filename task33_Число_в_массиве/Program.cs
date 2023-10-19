/*
Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве
*/
System.Console.WriteLine("Задай размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Какое число нужно найти в массиве:");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int[] GetArray(int size)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 9);
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
bool CheckNumber(int[] arr,int number)
{
for (int i = 0; i < array.Length; i++)
{
    if (arr[i] == number)
    {
        return true;
    }
}
     return false;
}
int[] userArray = GetArray(size);
bool userNumber = CheckNumber(array, number);
PrintArray(userArray);
System.Console.WriteLine(userNumber);