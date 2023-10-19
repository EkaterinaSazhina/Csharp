/*
Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
*/
System.Console.WriteLine("Задай размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
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
void PrintNumArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        int num = -1;
        
        System.Console.Write(arr[i] * num);
        if (i < arr.Length - 1)

            System.Console.Write(", ");
    }
    System.Console.WriteLine("]");
}
int[] userArray = GetArray(size);
int[] userNumArray = GetArray(size);
PrintArray(userArray);
PrintNumArray(userNumArray);