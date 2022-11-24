Console.WriteLine("Введите число A");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA > numB)
{
    Console.WriteLine($"Максимальное число: {numA}, минимальное число: {numB}.");
}
else
{
    Console.WriteLine($"Максимальное число: {numB}, минимальное число: {numA}.");
}
