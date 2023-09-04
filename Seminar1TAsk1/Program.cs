// Введите два числа. Проверить является ли первое число квадратом второго.
Console.WriteLine("Введите первое число: ");
int firstNum=int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите второе число: ");
int secondNum=int.Parse(Console.ReadLine()??"0");

if(firstNum==Math.Pow(secondNum,2))
{
    Console.WriteLine("Число два является квадратом первого числа");
}
else
{
    Console.WriteLine("Число два неявляется квадратом первого числа");
}
