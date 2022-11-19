// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//               и на выходе показывает вторую цифру этого числа. Выполнить с помощью 
//               числовых операций (целочисленное деление, остаток от деления).

// // 456 -> 5
// // 782 -> 8
// // 918 -> 1

Console.Clear();
int num;
do
{
    Console.Write("Введите трехзначное число: ");
    num = Convert.ToInt32(Console.ReadLine());
    if (IfThreeDigit(num) == false) Console.WriteLine("Вы ввели не трехзначное число, попробуйте еще раз!!!");
} while (IfThreeDigit(num) == false);

int secondDigit = (num / 10) % 10;
Console.WriteLine($"Вторая цифра числа --> {secondDigit}");

Boolean IfThreeDigit(int number)
{
    return (number > 99) & (number < 1000);
}