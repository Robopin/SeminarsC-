Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = -1;
if ( number > 99 && number < 1000)
{
    result = (number / 10) % 10;
    Console.WriteLine (result);
}
else Console.WriteLine ("Введите трехзначное положительное число");
