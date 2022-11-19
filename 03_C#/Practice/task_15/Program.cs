// Задача 15: Напишите программу, которая принимает на вход цифру, 
//            обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
int num;
do
{
    Console.Write("Введите номер дня недели: ");
    num = Convert.ToInt32(Console.ReadLine());
    if (InRange(num) == false) Console.WriteLine("Нет такого дня недели, введите число в диапазоне [1..7]");
} while (InRange(num) == false);

if (num > 5) Console.WriteLine(" --> да");
else Console.WriteLine(" --> нет");

bool InRange(int number)
{
    return (number > 0)&(number < 8);
}
