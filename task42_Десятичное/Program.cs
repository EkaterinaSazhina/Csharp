/*
Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10

System.Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
string binary = Convert.ToString(numberA, 2);
System.Console.WriteLine(binary);*/

    
        System.Console.Write("Введите число: ");
        int decimalNumber = Convert.ToInt32(Console.ReadLine());
        string binaryNumber = DecimalToBinary(decimalNumber)// перевод в строку
        
     string DecimalToBinary(int decimalNumber)
    {
        string binaryNumber = "";// начало строки

        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % 2; // Остаток от деления на 2
            binaryNumber = remainder + binaryNumber; // Добавляем остаток в начало строки
            decimalNumber /= 2; // Деление на 2
        }

        return binaryNumber;
    }
    Console.WriteLine(binaryNumber);

