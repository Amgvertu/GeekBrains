// Задача 58: Задайте две матрицы. Напишите программу, 
//            которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4  |  3 4
// 3 2  |  3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

Random rnd = new Random();
string? st;
int[] size;
bool flag = false;
do
{
    Console.Write("Задайте размер матрицы 1 (m n): ");
    st = Console.ReadLine();
    st = st + "";
    size = StringToInt(st);
    if ((size.Length < 2) || (size.Length > 2)) Console.WriteLine("Нужно ввести 2 значения!!!");
} while ((size.Length < 2) || (size.Length > 2));

int[,] matr1 = FillMatrixRnd(size[0], size[1]);

do
{
    Console.Write("Задайте размер матрицы 2 (m n): ");
    st = Console.ReadLine();
    st = st + "";
    size = StringToInt(st);
    if ((size.Length < 2) || (size.Length > 2)) Console.WriteLine("Нужно ввести 2 значения!!!");
} while ((size.Length < 2) || (size.Length > 2));

int[,] matr2 = FillMatrixRnd(size[0], size[1]);


Console.WriteLine();
Console.WriteLine("Матрица 1:");
PrintMatrix(matr1);

Console.WriteLine();
Console.WriteLine("Матрица 2:");
PrintMatrix(matr2);

if (matr1.GetLength(1) == matr2.GetLength(0))
{
    Console.WriteLine();
    int[,] matrix = Multiplication(matr1, matr2);
    PrintMatrix(matrix);
}
else Console.WriteLine("Матрицы можно перемножить только если число строк матрицы 1 равняется числу столбцов матрицы 2!!!");


//Методы

//Заполнение матрицы
int[,] FillMatrixRnd(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            matrix[i, j] = rnd.Next(1, 10);
    return matrix;
}

//Вывод матрицы
void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
            Console.Write("{0,7}", matrix[i, j]);
        Console.WriteLine();
    }
}

//Строка в числа
int[] StringToInt(string str)
{
    string[] subSt = str.Split(' ', ',');
    int[] arr = new int[subSt.Length];
    for (int i = 0; i < subSt.Length; i++)
    {
        if (subSt[i].All(char.IsDigit) & (subSt[i] != ""))
        {
            arr[i] = Convert.ToInt32(subSt[i]);
        }
    }
    return arr;
}

// Перемножение матриц
int[,] Multiplication(int[,] matrix1, int[,] matrix2)
{
    int rows = matrix1.GetLength(0);
    int cols = matrix2.GetLength(1);
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            for (int m = 0; m < matrix1.GetLength(1); m++)
            {
                //Console.WriteLine($"m[{i},{j}] = matrix1[{i},{m}] x matrix2[{m}, {j}]");
                matrix[i, j] += matrix1[i, m] * matrix2[m, j];
            }
    return matrix;
}