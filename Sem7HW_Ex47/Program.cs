// Запросить столбцы и сроки
int GetNum(string text)
{
    Console.WriteLine(text);
    int number = 0;
    while(true)
    {
        if(int.TryParse(Console.ReadLine(),out number)) break;
        else Console.WriteLine("Ввели не число");
    }
    return number;
}
// содать массив
double[,] GetMass(int m, int n)
{
    double [,] array = new double [m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = rnd.NextDouble() * 10;
        }
        Console.WriteLine();
    }
    return array;
}
// распечатать массив
void PrintMass(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}, ");
        }
        Console.WriteLine();
    }
}

int a = GetNum("Введите кол-во строк");
int b = GetNum("Введите кол-во столбцов");
double [,] massive = GetMass(a, b);
Console.WriteLine();
PrintMass(massive);