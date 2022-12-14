int[] GetArray(int len)
{
    int [] arr = new int [len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(-10, 11);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] CopyArray(int[] array)
{
    int[] sArray = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        sArray[i] = array[i];
    }
    return sArray;
}
int[] firstArr = GetArray(5);
PrintArray(firstArr);
Console.WriteLine();
int[] secArray = CopyArray(firstArr);
PrintArray(secArray);
