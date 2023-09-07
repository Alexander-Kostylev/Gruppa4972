// Принимаюся 2 числа -> определяем какое число больше,
// а какое меньше. Резльтат выводим в консоль

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine() ?? "0");

int maxNumber = num1 > num2 ? num1 : num2;
int minNumber = num1 < num2 ? num1 : num2;
Console.WriteLine("max= " + maxNumber + ", min= " + minNumber);