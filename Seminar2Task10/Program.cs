// Домашнее задание!
// Написать программу, 
// которая на вход принимает трехзначеное число 
// и на выходе показывает вторую цифру этого числа. 

int getValue()
{
    Console.WriteLine("Введите трехзначное число");
    int val = int.Parse(Console.ReadLine() ?? "0");
    return val;
}

while (true)
{
    int num = getValue();
    char[] numInArray = num.ToString().ToCharArray();
    if (numInArray.Length == 3)
    {
        Console.WriteLine(numInArray[1]);
        break;
    }
    else
    {
        Console.WriteLine("Введенное число не трехзначное!");
    }
}


