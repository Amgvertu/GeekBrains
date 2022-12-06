// Задача 52. Задайте двумерный массив из целых чисел. 
//            Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4.6  5.6  3.6  3
Console.Clear();
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

Random rnd = new Random();
int[,] matr = FillMatrixRnd();
PrintMatrix(matr);
PrintDash(matr.Length / (matr.GetUpperBound(0) + 1));
PrintArray(ArithmeticMean(matr));


//Методы

//Заполнение матрицы
int[,] FillMatrixRnd()
{
    int m = rnd.Next(2, 10);
    int n = rnd.Next(2, 10);

    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            matrix[i, j] = rnd.Next(1, 10);
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
            Console.Write("  {0:#####}  ", matrix[i, j]);
        Console.WriteLine();
    }
}

//Среднее арифметическое
double[] ArithmeticMean(int[,] matrix)
{
    int rows = matrix.GetUpperBound(0) + 1;
    int cols = matrix.Length / rows;
    double[] arrayArith = new double[cols];
    for (int j = 0; j < cols; j++)
    {
        for (int i = 0; i < rows; i++)
            arrayArith[j] = arrayArith[j] + matrix[i, j];
        arrayArith[j] = arrayArith[j] / (rows);
    }
    return arrayArith;
}

// Вывод массива
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write(" {0:0.0} ", arr[i]);
}

// Линия разделения
void PrintDash(int n)
{
    n = n * 5;
    for (int i = 0; i < n; i++)
        Console.Write("-");
    Console.WriteLine();
}