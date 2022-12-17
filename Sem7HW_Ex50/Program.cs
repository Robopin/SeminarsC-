// Предложить ввод строки и столбца

int InNumber(string text)
{
    int number = 0;
    Console.WriteLine(text);
    while(true)
    {
        if(int.TryParse(Console.ReadLine(), out number)) break;
        else Console.WriteLine("Ввели не число");
    }
    return number;
}

// создать массив
int [,] GetMass(int x, int y)
{
    int[,] array = new int[x, y];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1,11);
        }
    }
    return array;
}
// распечатать массив

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

// произвести поиск позиции
void FindPosition(int[,]massive, int a, int b)
{
    if(a <= massive.GetLength(0) && b <= massive.GetLength(1)) Console.WriteLine($"{massive[a - 1, b - 1]}");
    else Console.WriteLine("Такой позиции нет");
}

int numA = InNumber("Задайте кол-во строк");
int numB = InNumber("Задайте кол-во столбцов");
Console.WriteLine();
int[,] matrix = GetMass(numA, numB);
int numX = InNumber("Введите искомую сроку");
int numY = InNumber("Введите искомый столбец");
Console.WriteLine();
PrintMass(matrix);
Console.WriteLine();
FindPosition(matrix, numX, numY);