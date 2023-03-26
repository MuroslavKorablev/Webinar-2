Random rnd = new Random();
int number = rnd.Next(10,99);

int firstNumber = number / 10;
int lastnNumber = number % 10;
int MaxNumber = Math.Max(firstNumber, lastnNumber);

System.Console.WriteLine(number);
System.Console.WriteLine(MaxNumber);
