// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
//Создает массив
int[,] Getmass(int x, int y)
{
    int[,] mass = new int[x, y];
    Random rnd = new Random();
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = rnd.Next(1, 9);
        }
    }
    return mass;
}
//Печатает массив
void PrintMass(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}, ");
        }
        Console.WriteLine();
    }
}
//Сортироует строки массива от большего к меньшему
void Change(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            for (int a = 0; a < massive.GetLength(1) - 1; a++)
            {
                if (massive[i, a] < massive[i, a + 1])
                {
                    int temp = massive[i, a + 1];
                    massive[i, a + 1] = massive[i, a];
                    massive[i, a] = temp;
                }
            }
        }
    }
}
int[,] matr = Getmass(4, 4);
PrintMass(matr);
Console.WriteLine();
Change(matr);
PrintMass(matr);