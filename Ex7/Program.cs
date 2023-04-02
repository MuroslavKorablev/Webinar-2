// Вычислите сумму от 2^0 до 2^10
int number = 2;
int sum = 0;
for (int i = 0; i <=10; i++)
{
    System.Console.WriteLine($"{"индекс ="} {i}");
    sum += (int)Math.Pow(number , i);
    System.Console.WriteLine($"{"сумма ="} {sum}");  
}
