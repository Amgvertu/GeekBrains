// Задача 23. Напишите программу, которая принимает на вход 
//            число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0) for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"{i}  --> {DegreeThird(i)}");
    }
else for (int i = -1; i >= n; i--)
    {
        Console.WriteLine($"{i}  --> {DegreeThird(i)}");
    }

int DegreeThird(int x)
{
    return x * x * x;
}

