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

int body = GetNumber("Введите число");
int summ = 0;
while(body > 1)
    {
        summ = summ + body % 10;
        body = body / 10;
    }
 Console.WriteLine(summ);