// Найти сумму элементов от M до N, N и M заданы
Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());
int temp = 0;
if(m > n)
{
    temp = m;
    m = n;
    n = temp;
}

int summ = 0;
PrintSumm(m, n, summ);

void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов равна {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}


