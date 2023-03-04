// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих . 

Console.Write("Введите количество чисел N: ");
int N = int.Parse(Console.ReadLine());

int Fibonacci(int N)
{
    if(N == 1 || N == 2) return 1;
    else
    return Fibonacci(N - 1) + Fibonacci(N - 2); 
}
for(int i = 1; i <= N; i++)
{
  Console.Write($" {Fibonacci(i)} ");  
}