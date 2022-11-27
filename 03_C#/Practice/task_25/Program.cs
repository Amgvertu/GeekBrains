// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//            и возводит число A в натуральную степень B.
// 3, 5 -> 243
// 2, 4 -> 16

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
Console.WriteLine(Degree(a,b));

// Методы
int Degree(int a, int b)
{
    int sqr = 1;
    for (int i = 1; i <= b; i++)
    {
        sqr = sqr * a;
    }
    return sqr;
}


