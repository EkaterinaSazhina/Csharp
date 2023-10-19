/*
Напишите программу, которая подсчитывает количество четных элементов в массиве 
целых положительных трехзначных чисел и выводит результат на экран.
Программа должна иметь метод CountEvenElements, который принимает массив целых 
положительных трехзначных чисел и возвращает количество четных элементов в массиве.
Программа должна иметь метод PrintArray, который выводит элементы массива на экран.
При выводе элементы массива должны быть разделены символом табуляции "\t".
*/ 
System.Console.WriteLine("Задай размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int[] GetArray(int size)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
void PrintArray(int[] arr)
{
    
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write("\t");//[5, 7, 1, 4]
    }
   
}
int CountEvenElements(int[]arr)
{
    int count = 0;
    for (int i = 0; i <arr.Length; i++)
    {
        if(arr[i]%2==0)
        count++;
    }
    return count;
}
int[] userArray = GetArray(size);
int countArray = CountEvenElements(userArray);
PrintArray(userArray);
System.Console.WriteLine();
System.Console.WriteLine("Количество четных элементов: " + countArray);