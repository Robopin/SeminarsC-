// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

//Задает массив
int[,] Getmass(int x, int y)
{
    int[,] mass = new int[x, y];
    Random rnd = new Random();
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = rnd.Next(1, 6);
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

//Создает новый массив с произведением двух матриц

int[,] MassiveNew(int row, int col, int[,] mass1, int [,] mass2)
{
    int[,] mass3 = new int[row, col];
    for (int i = 0; i < mass1.GetLength(0); i++)
    {
        for (int j = 0; j < mass1.GetLength(1); j++)
        {
            mass3[i,j] = mass1[i,j]*mass2[i,j];
        }
    }
    return mass3;
}

int[,] matr1 = Getmass(4, 4);
int[,] matr2 = Getmass(4, 4);
int[,] matr3 = MassiveNew(4, 4, matr1, matr2);
PrintMass(matr1);
 Console.WriteLine();
PrintMass(matr2);
 Console.WriteLine();
PrintMass(matr3);