// Задача 34: Задайте массив заполненный случайными положительными 
//            трёхзначными числами. Напишите программу, которая 
//            покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();
Random len = new Random();
int[] array = FillArray(100, 1000, len.Next(1,15));
PrintArray(array);
EvenNumberedSum(array);

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
        if (i == arr.Length - 1) Console.Write($"{arr[i]}");
        else Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine("]");
}

// Количество четных чисел массива
void EvenNumberedSum(int[] arr) {
    int count = 0;
    for (int i=0; i < arr.Length; i++) {
        if (arr[i]%2 == 0) count++;
    }
    Console.WriteLine($"Кол-во четных элементов: {count}");
}