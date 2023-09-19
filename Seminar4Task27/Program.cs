//============================================================
// Основное задание.
// Написать программу, которая на вход принимает число 
// и выдает сумму всех чисел в числе.
//============================================================


// Получение данных от пользователя 
long readData(string message)
{
    Console.Write(message);
    long inputData = long.Parse(Console.ReadLine() ?? "0");
    return inputData;
}

// Вывод результата
void outConsole(string mes)
{
    Console.WriteLine(mes);
}

long sumOfNumber(long num)
{
    long sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

// long inputNumber = readData("Введите число: ");
// long resultSum = sumOfNumber(inputNumber);
// outConsole($"Сумма всех чисел в числе {inputNumber} = {resultSum}");


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// * Дополнительное задание.
// Оценка времени работы алгоритма через вещественые числа и строки
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

char[] inputOnChar(string str)
{
    Console.WriteLine(str);
    char[] chars = (Console.ReadLine() ?? "0").ToCharArray();
    return chars;
   
}
double sumOnChar(char []chars)
{
 double sum = 0;
    foreach (char op in chars)
    {
        sum += Char.GetNumericValue(op);
    }
    return sum;
}

long inputNumber = readData("Введите число: ");
System.Console.WriteLine("время выполнения через вещественные");
long resultSum = sumOfNumber(inputNumber);

System.Console.WriteLine("время выаполнения через строки");
sumOnChar
outConsole($"Сумма всех чисел в числе {inputNumber} = {resultSum}");