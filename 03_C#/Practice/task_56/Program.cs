// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//            которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

Random rnd = new Random();
int[,] matr = FillMatrixRnd();

PrintMatrix(matr);


int[] arraySum = SumEachRows(matr);
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {IndexMin(arraySum)}");

//Методы

//Заполнение матрицы
int[,] FillMatrixRnd()
{
    int m = rnd.Next(2, 10);
    int n = rnd.Next(2, 10);

    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            matrix[i, j] = rnd.Next(-10, 10);
    return matrix;
}

//Вывод матрицы
void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetUpperBound(0) + 1;
    int cols = matrix.Length / rows;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
            Console.Write("{0,7}", matrix[i, j]);
        Console.WriteLine();
    }
}

//Сумма строк

int[] SumEachRows(int[,] matrix)
{
    int rows = matrix.GetUpperBound(0) + 1;
    int cols = matrix.Length / rows;
    int[] arrsum = new int[rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
            arrsum[i] = arrsum[i] + matrix[i, j];
    }
    return arrsum;
}

//Индекс минимального элемента

int IndexMin (int[] arr)
{
    int minIndex = 0;
    int min = arr[0];
    for (int i=1;i<arr.Length;i++)
        if (arr[i]<min) 
        {
            minIndex = i;
            min = arr[i];
        }
    
    return minIndex+1;
}