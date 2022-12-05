//функция получения числа с консоли

double GetNumber(string message)
{
    double result = 0;
    bool isCorrect = false;


    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(double.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Введите корректное число");
        }
    }

    return result;
}

double x1 = GetNumber("Введите координату Х1:");
double y1 = GetNumber("Введите координату Y1:");
double z1 = GetNumber("Введите координату Z1:");
double x2 = GetNumber("Введите координату Х2:");
double y2 = GetNumber("Введите координату Y2:");
double z2 = GetNumber("Введите координату Z2:");
Console.WriteLine(Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)) + (Math.Pow(z2 - z1, 2))));