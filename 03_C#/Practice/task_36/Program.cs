// Задача 36: Задайте одномерный массив, заполненный случайными 
//            числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Random len = new Random();
int[] array = FillArray(0, 1000, len.Next(1, 10));
PrintArray(array);
EvenNumbered(array);

// Методы
// Заполнение массива
int[] FillArray(int min, int max, int length)
{
    Random rnd = new Random();
    int[] arr = new int[length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}

// Вывод массива
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i != arr.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}

// Количество четных чисел массива
void EvenNumbered(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
        sum = sum + arr[i];
    Console.WriteLine($"Сумма элементов, на нечетных позициях: {sum}");
}