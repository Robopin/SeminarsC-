Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int remains = number % 2;
if (remains == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}
