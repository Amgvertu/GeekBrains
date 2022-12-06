// Задача 50. Напишите программу, которая на вход принимает позиции элемента
//            в двумерном массиве, и возвращает значение этого элемента или 
//            же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1,7 -> такого элемента в массиве нет

Random rnd = new Random();
int[,] matr = FillMatrixRnd();
PrintMatrix(matr);
int rows = matr.GetUpperBound(0) + 1;
int cols = matr.Length / rows;

Console.Write("Введите позицию элемента x, y (отсчет элементов с 1,1):");
string? st = Console.ReadLine();
st = st + "";
int[] index = StringToInt(st);
index[0]--;
index[1]--;

if ((index[0] >= 0) &&
    (index[0] < rows) &&
    (index[1] >= 0) &&
    (index[1] < cols))
{
    Console.WriteLine($"[{index[0] + 1},{index[1] + 1}] = {matr[index[0], index[1]]}");
}
else Console.WriteLine($"Элемента [{index[0] + 1},{index[1] + 1}] не существует");

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
            Console.Write("  {0:###}  ", matrix[i, j]);
        Console.WriteLine();
    }
}

//Строка в числа, по разделителю
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