// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// Создать массив
int[,] GetMass(int x, int y)
{
    int[,] arr = new int[x, y];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(1,6);
        }
    }
    return arr;
}
// распечатать массив
void PrintMass (int[,]massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]}, ");
        }
        Console.WriteLine();
    }
}

// вычислить среднее арефмитическое столбца
void Arithmetic(int [,] mass)
{
    int temp = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            temp += mass[j,i];
        }
        Console.WriteLine($"{temp}");
        temp = 0;
    }
}

int[,] mass = GetMass(3, 3);
PrintMass(mass);
Console.WriteLine();
Arithmetic(mass);