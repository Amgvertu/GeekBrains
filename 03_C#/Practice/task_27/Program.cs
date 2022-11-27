// Задача 27: Напишите программу, которая принимает на вход 
//            число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = -number;
Console.WriteLine(DigitSum(number));


//Методы
int DigitSum(int num)
{
    int digitCount = Convert.ToInt32(Math.Log10(num) + 1);
    int div = 1;
    int sum = 0;
    for (int i = 1; i < digitCount; i++)
    {
        sum = sum + (num / div) % 10;
        div = div * 10;
    }
    return sum;
}
