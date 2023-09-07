// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит остаток от деления.

Console.WriteLine("Введите 1-е число: ");
int firstNum = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите 2-е число: ");
int secondNum = int.Parse(Console.ReadLine() ?? "0");

if (secondNum % firstNum == 0)
{
    Console.WriteLine(secondNum + " кратно " + firstNum);
}
else
{
    Console.WriteLine("Второе не кратно первому. Остаток от деления: " + secondNum % firstNum);
}