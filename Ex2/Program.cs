Random rnd = new Random();
int number = rnd.Next(100,1000);
// int firstNumber = number / 100;
// int secondNumber = (number % 100) / 10;
int firstNumber = (number / 100) * 10;
int lastnNumber = number % 10;
// int thirdNumber = number % 10;
//Как узнать 2е число в трехзначном числе?
//s = ( n % 100) / 10;
//Сложно? Ни разу.


System.Console.WriteLine(number);
System.Console.WriteLine(firstNumber + lastnNumber);

// System.Console.WriteLine(firstNumber);
// System.Console.WriteLine(secondNumber);
// System.Console.WriteLine(thirdNumber);
// System.Console.WriteLine(firstNumberthirdNumber);