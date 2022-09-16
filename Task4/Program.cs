Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num >= 1)
{
    if (num%2 == 0)
    {
    Console.WriteLine($"{num}");
    }
    num--;
}
