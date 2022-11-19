// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Универсальный способ для любого количества чисел
bool flag = false;

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0) num = -num;

for (int i = 1; i <= HowMuchDigit(num) / 2; i++)
    if (((num / InDegree(HowMuchDigit(num) - i)) % InDegree(i - i + 1)) == ((num % InDegree(i)) / InDegree(i - 1))) flag = true;
    else flag = false;

if (flag == true) Console.WriteLine("--> Да");
else Console.WriteLine("--> Нет");



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


int InDegree(int degree)
{
    int num = 1;
    for (int i = 1; i < degree + 1; i++)
    {
        num = num * 10;
    }
    return num;
}