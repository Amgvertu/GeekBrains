// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//            Напишите программу, которая будет построчно выводить массив, 
//            добавляя индексы каждого элемента.

// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.Clear();
Random rnd = new Random();

string? st;
int[] size;
do
{
    Console.Write("Задайте размер трехмерного массива (m n l): ");
    st = Console.ReadLine();
    st = st + "";
    size = StringToInt(st);
    if ((size.Length < 3) || (size.Length > 3)) Console.WriteLine("Нужно задать размер трехмерного массива!!!");
    if (size[0] * size[1] * size[2] > 90) Console.WriteLine("Количество элементов массива должно быть меньше 90!!!");
} while ((size.Length < 3) || (size.Length > 3) || (size[0] * size[1] * size[2] > 90));

int[,,] matr = FillMatrixRnd(size[0], size[1], size[2]);

PrintMatrix(matr);


//Методы

//Заполнение массива
int[,,] FillMatrixRnd(int m, int n, int l)
{
    int x = 0;
    int[] arrRnd = MixArray(CreateTwoDigitArray());

    int[,,] matrix = new int[m, n, l];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            for (int k = 0; k < l; k++)
            {
                matrix[i, j, k] = arrRnd[x];
                x++;
            }
    return matrix;
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

//Вывод матрицы
void PrintMatrix(int[,,] matrix)
{
    int rows = matrix.GetLength(0); ;
    int cols = matrix.GetLength(1);
    int depth = matrix.GetLength(2);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
            for (int k = 0; k < depth; k++)
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k})  ");
        Console.WriteLine();
    }
}

//Создание массива двухзначных чисел
int[] CreateTwoDigitArray()
{
    int z = 10;
    int[] array = new int[90];
    for (int i = 0; i < 90; i++)
    {
        array[i] = z;
        z = z + 1;
    }
    return array;
}

//Перемешивание массива
int[] MixArray(int[] array)
{
    for (int i = array.Length - 1; i >= 1; i--)
    {
        int j = rnd.Next(i + 1);
        var temp = array[j];
        array[j] = array[i];
        array[i] = temp;
    }
    return array;
}