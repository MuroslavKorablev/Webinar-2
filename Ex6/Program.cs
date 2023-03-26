int n = Convert.ToInt32(System.Console.ReadLine());
float sum = 0;

for (int i = 1; i <= n; i++)
{
    sum += (float) 1/(float)i;
    System.Console.WriteLine((float) 1/(float)i);
}
System.Console.WriteLine(sum);