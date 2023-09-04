// Введите два числа. Проверить является ли первое число квадратом второго.
Console.WriteLine("Введите первое число: ");
int firstNum=int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите второе число: ");
int secondNum=int.Parse(Console.ReadLine()??"0");

if(firstNum==Math.Pow(secondNum,2))
{
    Console.WriteLine("Первое чило - это квадрат второго числа");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго числа");
}
