// Задача 21: Напишите программу, которая принимает 
//            на вход координаты двух точек и находит 
//            расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Координаты первой точки");
Console.Write("Введите координату X:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z:");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Координаты второй точки");
Console.Write("Введите координату X:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z:");
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Difference(x1, x2) + Difference(y1, y2) + Difference(z1, z2));
Console.WriteLine($"A({x1},{y1},{z1}); B({x2},{y2},{z2}) --> {Math.Round(d, 2)}");

//Метод
int Difference(int first, int second)
{
    return (second - first) * (second - first);
}