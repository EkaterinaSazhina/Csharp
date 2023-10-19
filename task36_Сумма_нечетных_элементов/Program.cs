/*
Напишите программу, которая находит сумму элементов с нечетными индексами в одномерном массиве целых
чисел и выводит результат на экран.
Программа должна иметь метод SumOddElements, который принимает массив 
целых чисел и возвращает сумму элементов с нечетными индексами в массиве.
*/
System.Console.WriteLine("Задай размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int[] GetArray(int size)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 10);
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
int SumOddElements(int[] array)
{
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 1)
        sum = array[i] + sum;
}
return sum;
}
int[] userArray = GetArray(size);
int sumArray = SumOddElements(userArray);
PrintArray(userArray);
System.Console.WriteLine();
System.Console.WriteLine("Сумма нечетных элементов: " + sumArray);