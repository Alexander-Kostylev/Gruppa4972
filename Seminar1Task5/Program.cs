// Задача №5
// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Enter number");
int numN = int.Parse(Console.ReadLine() ?? "0");

for (int i = -1 * numN; i <= numN; i++)
{
    Console.Write(i);
    Console.Write(", ");
}