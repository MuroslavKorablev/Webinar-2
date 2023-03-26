System.Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(System.Console.ReadLine());

bool isCquare = Math.Pow(firstNumber, 2) == secondNumber || Math.Pow(secondNumber, 2) == firstNumber;
if(isCquare)
    System.Console.WriteLine("Yes");
else 
    System.Console.WriteLine("No");