// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
string? st;
int[] size;
do
{
    Console.Write("Задайте размер матрицы (m n): ");
    st = Console.ReadLine();
    st = st + "";
    size = StringToInt(st);
    if ((size.Length < 2) || (size.Length > 2)) Console.WriteLine("Нужно ввести 2 значения!!!");
} while ((size.Length < 2) || (size.Length > 2));

Console.WriteLine();
PrintMatrix(FillMatrix(size[0], size[1]));

//Методы

//Заполнение матрицы
int[,] FillMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    int iStart = 0;
    int iFinish = 0;
    int jStart = 0;
    int jFinish = 0;
    int size = m * n;
    int i = 0;
    int j = 0;
    int k = 1;

    while (k <= size)
    {
        matrix[i, j] = k;
        if (i == iStart && j < n - jFinish - 1)
            j++;
        else if (j == n - iFinish - 1 && i < m - iFinish - 1)
            i++;
        else if (i == m - iFinish - 1 && j > iStart)
            j--;
        else if (j == jStart && i > iStart)
            i--;

        if (j == jStart && i == iStart + 1)
        {
            iStart++;
            iFinish++;
            jStart++;
            jFinish++;
        }
        k++;
    }
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