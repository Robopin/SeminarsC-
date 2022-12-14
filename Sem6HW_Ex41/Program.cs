int[] GetMassive(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите {i} число массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
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

int Counter(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int[] arr = GetMassive(5);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine(Counter(arr));