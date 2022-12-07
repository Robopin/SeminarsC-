int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100); //Сделал ограничение по величине элементов, что бы был читабельный ответ
}

Console.Write(string.Join(" ", array));