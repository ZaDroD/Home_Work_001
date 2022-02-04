// Выяснить является ли число чётным

Console.WriteLine("Введите число ");

string number = Console.ReadLine();

double num = int.Parse(number);

if (num % 2 == 0) Console.WriteLine("Число чётноё " + num);
if (num % 2 > 0) Console.WriteLine("Число не чётноё " + num);