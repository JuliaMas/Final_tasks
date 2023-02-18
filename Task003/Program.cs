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


/*while (true)
{
int m = InputNumbers("Введите m: ");
int n1 = InputNumbers("Введите n: ");
int temp = 0;
if (m > n1) 
{
    temp = m;
    m = n1;
    n1 = temp; 
  // n = m;
  // m = n1;
  // n1 = n;
}
else{ 
PrintNumber1(m, n1);
break;
}
}

void PrintNumber1(int m, int n1) 
{
  if (n1 < m) return;
  PrintNumber1(m, n1 - 1);
  Console.Write(n1 + " ");
}
int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}*/