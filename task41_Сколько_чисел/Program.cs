/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/ 
Console.WriteLine("Введите числа, разделяя их запятой:");
        string num = Console.ReadLine(); // Считываем ввод пользователя
       
    static int CountNumbers(string num)
    {
        string[] numbers = num.Split(','); // Разделяем строку на числа через метод Split

        int count = 0;
        foreach (string i in numbers)
        {
            int parsedNumber;
            if (int.TryParse(i, out parsedNumber)) // Пытаемся преобразовать строку в число через int.TryParse
            {
                if (parsedNumber > 0) // Проверяем, является ли число больше 0
                {
                    count++;
                }
            }
        }

        return count;
    }
     int count = CountNumbers(num);
    Console.WriteLine("Количество чисел больше 0: " + count);