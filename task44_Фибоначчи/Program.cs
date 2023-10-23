/*
Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/ 
System.Console.WriteLine("Введите количество чисел Фибоначчи: ");
int numberA = Convert.ToInt32(Console.ReadLine());
void PrintFibonacci(int numberA)
{
    if(numberA<=0) return;
    int[] fibArray = new int[numberA];
    fibArray[0]=0;
    fibArray[1]=1;
       for (int i = 2; i < numberA; i++)
       {
        fibArray[i] = fibArray[i-1]+fibArray[i-2];
        System.Console.Write(fibArray[i] +" " );
       }    
}
PrintFibonacci(numberA);