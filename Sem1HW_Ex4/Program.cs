Console.WriteLine("Введите число A");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C");
int numC = Convert.ToInt32(Console.ReadLine());
int result = numA;
if (numB > numA)
{
    result = numB;
}
if (numC > numB)
{
    result = numC;
}
Console.WriteLine($"Максимальное число {result}");