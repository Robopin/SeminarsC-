Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0 && number < 7)
{
    if (number >= 6) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}
else Console.WriteLine("Выберете число из диапозона 1-7");