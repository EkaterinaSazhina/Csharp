/*
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

/*Console.WriteLine("Введите значения b1, k1, b2 и k2, разделяя их запятой:");
string input = Console.ReadLine(); // Считываем ввод пользователя
double[] array = ParseInput(input);//Сохраняем значения в массив
double x = CrossPoint(array[0], array[1], array[2], array[3]);
double y = Cusp(x, array[0], array[1]);
double[] ParseInput(string input)
    {
        string[] numbers = input.Split(','); // Разделяем строку на числа
        double[] array = new double[4];
        for (int i = 0; i < numbers.Length; i++)
        {
            double userNumber;
            if (double.TryParse(numbers[i], out userNumber)) // Пытаемся преобразовать строку в число
            {
                array[i] = userNumber;                      //записать в массив
            }
        }
        return array;
    }

double CrossPoint(double b1, double k1, double b2, double k2)
    {
        if (k1 == k2)
        {
            Console.WriteLine("Прямые параллельны и не имеют точки пересечения.");
        }

        double x = (b2 - b1) / (k1 - k2);// вычисление точки пересечения
        return x;
    }

double Cusp(double x, double b, double k)
    {
        double y = k * x + b;// вычисление точки пересечения
        return y;
    }
Console.WriteLine("Точка пересечения: (" + x + ", " + y + ")");*/


Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

void CrossLine(double b1, double k1, double b2, double k2)
{

    if (k1 == k2)
    {
        if (b1 == b2)
            System.Console.WriteLine("Прямые совпадают");
        else
            System.Console.WriteLine("Прямые параллельны");
            return;
    }
    double x = (-b2 + b1) / (-k1 + k2);
    double y = k2 * x + b2;
    Console.WriteLine($"Две прямые пересекаются в точке с координатами X: {x}, Y: {y}");
}
CrossLine(b1, k1, b2, k2);