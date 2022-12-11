int[] GetArray(int length)
{
    Random rnd = new Random();
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-10, 50);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

int FindCout(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            count = count + array[i];
        }
    }
    return count;
}

int[] array = GetArray(4);
PrintArray(array);
Console.WriteLine();
int otvet = FindCout(array);
Console.WriteLine($"{otvet}");