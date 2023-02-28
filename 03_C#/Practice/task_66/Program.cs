// Задача 66: Задайте значения M и N. Напишите программу, которая 
//            найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите отрезок чисел от M до N");
Console.Write("Введите натуральное число M : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N : ");
int n = Convert.ToInt32(Console.ReadLine());
int s = 0;
if (m<n)  s = SumNat(0,m,n);
else s = SumNat(0,n,m);
Console.WriteLine($"{s});

//Методы
int SumNat(int sum, int m, int n)
{
    if (n<m) return sum;
    else 
    {
        sum = sum+n;
        return SumNat(sum, m,n - 1);
    }


}