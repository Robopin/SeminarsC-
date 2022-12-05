string numbers = Console.ReadLine();
char[] arreyNumbers = numbers.ToCharArray();
Array.Reverse(arreyNumbers);
string temp = new string(arreyNumbers);
if (temp == numbers)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
