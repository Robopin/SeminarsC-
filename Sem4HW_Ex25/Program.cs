//Получение числа с консоли
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}


int numberA = GetNumber("Введите число А");
int numberB = GetNumber("Введите число B");
Console.WriteLine(Math.Pow(numberA, numberB));
