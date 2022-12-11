

double[] GetArray(int length)
{
    double[] aMassiv;
    aMassiv = new double[length];
    Random rnd = new Random();
    for (int i = 0; i < aMassiv.Length; i++)
    {
        aMassiv[i] = rnd.Next(-9, 10);
    }
    return aMassiv;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

double FindMinMax(double[] array)
{

    double numMin = array[0];
    double numMax = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > numMax)
        {
            numMax = array[i];
        }
        if (array[i] < numMin)
        {
            numMin = array[i];
        }

    }
    return numMax - numMin;
}

double[] array = GetArray(4);
Console.WriteLine();
PrintArray(array);
//double max = FindMinMax(array);
Console.WriteLine($" разница между макс и мин массива равна {FindMinMax(array)} ");
