Console.Clear();
int b;
Console.Write("Введите число A:");
int a = Convert.ToInt32(Console.ReadLine());
do
{
    Console.Write("Введите число B:");
    b = Convert.ToInt32(Console.ReadLine());
    if (b < 0) Console.WriteLine("Число должно быть больше 0");
} while (b < 0);

int Degree(int a, int b)
{
    int sqr = 1;
    for (int i = 1; i <= b; i++)
    {
        sqr = sqr * a;
    }
    return sqr;
}

Console.WriteLine(Degree(a,b));
