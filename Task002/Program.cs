// Показать натуральные числа от N до 1, N задано
Console.WriteLine("Введите N: ");
int N = int.Parse(Console.ReadLine());
int count = 2;
PrintNumber(N, count);
Console.Write(1);

void PrintNumber(int N, int count)
{
  if (count > N) return;
  else
  {
    PrintNumber(N, count + 1);
    Console.Write(count + " ");
  }
  
}
