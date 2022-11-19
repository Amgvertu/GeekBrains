// Задача 13: Напишите программу, которая выводит третью цифру
//            заданного числа или сообщает, что третьей цифры нет. 
//            Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0) num = num * -1;
if (HowMuchDigit(num) < 3) Console.WriteLine(" --> Третьей цифры нет");
else if (HowMuchDigit(num) == 3) Console.WriteLine($"Третья цифра числа --> {num % 10}");
else
{
    while (HowMuchDigit(num) > 3)
    {
        num = num / 10;
    }
    Console.WriteLine($"Третья цифра числа --> {num % 10}");
}

int HowMuchDigit(int exp)
{
    int i = 1;
    while (exp / 10 != 0)
    {
        exp = exp / 10;
        i = i + 1;
    }
    return i;
}

