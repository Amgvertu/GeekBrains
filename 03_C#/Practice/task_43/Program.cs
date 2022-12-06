// Задача 43: Напишите программу, которая найдёт 
//            точку пересечения двух прямых, заданных 
//            уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//            значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Задайте уравнение первой прямой y=k1*x+b1");
Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Задайте уравнение второй прямой y=k2*x+b2");
Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());

switch (CheckException(k1, b1, k2, b2))
{
    case 1:
        Console.WriteLine("Нет точки пересечения прямых");
        break;

    case 2:
        Console.WriteLine("Прямые совпадают");
        break;

    case 0:
        double x = FindX(k1, b1, k2, b2);
        double y = FindY(x, k1, b1);
        Console.WriteLine($"Точка пересечения прямых ( {x} ; {y} )");
        break;
}

// Методы
double FindX(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double FindY(double x, double k1, double b1)
{
    double y = k1 * x + b1;
    return y;
}

int CheckException(double k1, double b1, double k2, double b2)
{
    int answer = 0;
    if ((k1 == k2) && (b1 == b2))
    {
        answer = 2;
    }
    else if (k1 == k2) answer = 1;
    return answer;
}
