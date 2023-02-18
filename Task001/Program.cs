// Показать натуральные числа от 1 до N, N задано
Console.WriteLine("Введите N: ");
int N = int.Parse(Console.ReadLine());
PrintNum(N);

void PrintNum(int N) 
{
  if (N <= 0) 
  return;
  else
  {
    PrintNum(N - 1);
    Console.Write(N + " ");
  }
  
}
