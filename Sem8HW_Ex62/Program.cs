// Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7


//Создаем массив
int[,] massive = new int[4, 4];

//Заполняет массив 
void Fillarray(int[,] mass)
{
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= massive.GetLength(0) * massive.GetLength(1))
    {
        massive[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < massive.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= massive.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > massive.GetLength(1) - 1)
            j--;
        else
            i--;
    }
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
Fillarray(massive);
PrintMass(massive);
