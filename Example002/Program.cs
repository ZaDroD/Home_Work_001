//Найти максимальное из трех чисел

int numA = new Random().Next(1, 99);
Console.WriteLine("Первое число " + numA);

int numB = new Random().Next(1, 99);
Console.WriteLine("Второе число " + numB);

int numС = new Random().Next(1, 99);
Console.WriteLine("Третье число " + numС);

int max = numA;

if ( max < numB) max = numB;
if ( max < numС) max = numС;

Console.WriteLine("Максимальное из трёх чисел " + max);