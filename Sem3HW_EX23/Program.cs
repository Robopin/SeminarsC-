Console.WriteLine("Введите число");
int n = Convert.ToInt16(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    int temp = i * i * i;
    Console.WriteLine(temp);
}
