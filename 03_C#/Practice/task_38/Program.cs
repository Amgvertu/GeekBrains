// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
//            между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

Random len = new Random();
double[] array = FillArray(100, 1000, len.Next(3, 10));
PrintArray(array);
Console.WriteLine("Разница между Max и Min = "+"{0:0.000}",DiffMaxMin(array));

// Методы
// Заполнение массива
double[] FillArray(int min, int max, int length)
{
    Random rnd = new Random();
    double[] arr = new double[length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble()*rnd.Next(1,100);
    }
    return arr;
}

// Вывод массива
void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("{0:0.000}", arr[i]);
        if (i != arr.Length - 1) Console.Write(",  ");
        
    }
    Console.WriteLine("]");
}

//Разница Max Min
double DiffMaxMin(double[] arr) {
double max = arr[0];
double min = arr[0];
 for (int i = 1; i < arr.Length; i++)
    {
      if (arr[i]>max) max=arr[i];
      if (arr[i]<min) min=arr[i];
    }
    return max-min;
}