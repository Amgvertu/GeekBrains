// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//            Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


Console.Write("Введите числа через пробел:");
string? st = Console.ReadLine();
st = st + "";
int[] array = StringToInt(st);
Console.WriteLine($"--> {CountNum(array)}");


// Методы
int[] StringToInt(string str)
{
        string[] subSt = str.Split(' ');
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

int CountNum (int[] arr) {
    int count = 0;
        for (int i=0;i<arr.Length;i++) {
            if (arr[i] > 0) count++;
        }
    return count;
}