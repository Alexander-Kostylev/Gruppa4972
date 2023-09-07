//На входе принимаются 3 числа -> выводится на экран максимальное число

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine() ?? "0");

int numTemp = num1 > num2 ? num1 : num2;
int maxNum = numTemp > num3 ? numTemp : num3;

Console.WriteLine("Максимальное число это: " + maxNum);