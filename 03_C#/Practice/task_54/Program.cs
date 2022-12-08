// Задача 54: Задайте двумерный массив. Напишите программу, 
//            которая упорядочит по убыванию элементы каждой 
//            строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

Random rnd = new Random();
int[,] matr = FillMatrixRnd();

PrintMatrix(matr);
Console.WriteLine();
PrintMatrix(SortMatrix(matr));


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

//Сортировка матрицы

int[,] SortMatrix(int[,] matrix)
{
    int rows = matrix.GetUpperBound(0) + 1;
    int cols = matrix.Length / rows;

    for (int i = 0; i < rows; i++)                              
        for (int j = 0; j < cols - 1; j++)
            for (int k = j + 1; k < cols; k++)
                if (matrix[i, k] > matrix[i, j])
                {
                    int s = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = s;
                }
    return matrix;
}