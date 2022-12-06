// Задача 47. Задайте двумерный массив размером m×n, 
//            заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5    7    -2   -0,2
//  1   -3,3    8   -9,9
//  8    7,8  -7,1    9

Console.Clear();
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

Console.WriteLine("Задайте размерность матрицы m x n");
Console.Write("Количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] mat = FillMatrix(m, n);
PrintMatrix(mat);

//Методы

//Формирование массива
double[,] FillMatrix(int m, int n)
{
    Random rnd = new Random();
    double[,] matrix = new double[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            matrix[i, j] = rnd.NextDouble() * rnd.Next(-100, 100);
    return matrix;
}

//Вывод массива
void PrintMatrix(double[,] matrix)
{
    int rows = matrix.GetUpperBound(0) + 1;
    int cols = matrix.Length / rows;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
            Console.Write("   {0:0.0}     ", matrix[i, j]);
        Console.WriteLine();
    }
}