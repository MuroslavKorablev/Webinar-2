System.Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(System.Console.ReadLine());

if(firstNumber % secondNumber == 0)
    System.Console.WriteLine("кратно");
else
    System.Console.WriteLine($"{firstNumber} и {secondNumber} не кратно = {firstNumber % secondNumber}");

