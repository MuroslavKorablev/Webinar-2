System.Console.WriteLine("Введите число");
int Number = Convert.ToInt32(System.Console.ReadLine());
int b = Number % 7;
int c = Number % 23;

if(b == 0 && c == 0)
    System.Console.WriteLine("кратно");
else
    System.Console.WriteLine("Не кратно");
System.Console.WriteLine(b + c);
