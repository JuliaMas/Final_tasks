// Написать программу вычисления функции Аккермана
Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());

int functionAkk = Akkerman(m,n);
int Akkerman(int m, int n)
{
    if(m == 0) return n + 1;
    else if (n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m -1, Akkerman(m, n -1));
}
Console.Write($"Функция Аккермана равна {functionAkk} ");
