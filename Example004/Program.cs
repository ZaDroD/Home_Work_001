// Показать четные числа от 1 до N

Console.WriteLine("Введите целое число (N) ");
string num = Console.ReadLine();
int number = int.Parse(num);
int cur = 2;

while ( cur < number )
{
    if ( cur % 2 == 0 ) Console.WriteLine(" Чётные числа " + cur );
    cur ++;
}