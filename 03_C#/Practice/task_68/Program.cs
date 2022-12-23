// Задача 68: Напишите программу вычисления функции 
//            Аккермана с помощью рекурсии. 
//            Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
string? st;
int[] func;
do
{
    Console.Write("Задайте два неотрицательных числа (m n): ");
    st = Console.ReadLine();
    st = st + "";
    func = StringToInt(st);
    if ((func.Length < 2) || (func.Length > 2)) Console.WriteLine("Нужно ввести 2 значения!!!");
    if ((func[0] < 0) || (func[1] < 0)) Console.WriteLine("Числа должны быть неотрицательными!!!");
} while ((func.Length < 2) || (func.Length > 2) || (func[0] < 0) || (func[1] < 0));

Console.WriteLine(Akkerman(func[0], func[1]));

//Методы

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

int Akkerman(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return Akkerman(m - 1, 1);
    else
      return Akkerman(m - 1, Akkerman(m, n - 1));
}