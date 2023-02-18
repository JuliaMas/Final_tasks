// Показать натуральные числа от M до N, N и M заданы
Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine());
int temp = 0;
if(m > n)
{
    temp = m;
    m = n;
    n = temp;
}
PrintNum(m, n);
void PrintNum(int m, int n) 
{
  if (n < m) return;
  else
  {
    PrintNum(m, n - 1);
    Console.Write(n + " ");
  }
}


