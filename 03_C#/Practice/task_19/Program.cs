// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// По заданию

int num;
Console.Clear();

do
{
    Console.Write("Введите число: ");
    num = Convert.ToInt32(Console.ReadLine());
    if (HowMuchDigit(num) != 5) Console.WriteLine("Вы ввели не пятизначное число, попробуйте еще раз!!!");
} while (HowMuchDigit(num) != 5);
if (num < 0) num = -num;
if ((num / 10000 == num % 10) & ((num / 1000) % 10 == (num / 10) % 10)) Console.WriteLine(" --> Да");
else Console.WriteLine(" --> Нет");

// Методы
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
