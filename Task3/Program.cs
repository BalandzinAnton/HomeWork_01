Console.Clear();
Console.Write("Введите числа: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num%2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}
