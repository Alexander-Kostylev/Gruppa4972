// Напишите программу, 
// которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N

Console.Write("Введите число: ");

int num = int.Parse(Console.ReadLine() ?? "0");

int startNum = 2;

if (num % 2 != 0) num--;

if (num < 2) Console.WriteLine("Четных чисел нет!!!");

while (startNum <= num)
{
    Console.Write(startNum + "  ");
    startNum += 2;
}