System.Console.WriteLine("Введите число");
int Number = Convert.ToInt32(System.Console.ReadLine());

if(Number % 7 == 0 && Number % 23 == 0) // если да
    System.Console.WriteLine("Yes"); // вот это
else // в противном случае
    System.Console.WriteLine("No"); // вот этот кусок кода
//System.Console.WriteLine(b + c);
