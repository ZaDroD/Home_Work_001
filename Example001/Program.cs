//Даны два числа. Показать большее и меньшее число

int numberA = new Random().Next(1, 99);
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 99);
Console.WriteLine(numberB);

if (numberA > numberB)
{
        Console.WriteLine("Число " + numberA +" больше");
        Console.WriteLine("Число " + numberB +" меньше");
}
else if (numberA < numberB)
{
        Console.WriteLine("Число " + numberB +" больше");
        Console.WriteLine("Число " + numberA +" меньше");
}
else 
{
    Console.WriteLine("Число " + "равны");
}