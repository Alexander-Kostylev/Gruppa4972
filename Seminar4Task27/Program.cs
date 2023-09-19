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

long inputNumber = readData("Введите число: ");
long resultSum = sumOfNumber(inputNumber);
outConsole($"Сумма всех чисел в числе {inputNumber} = {resultSum}");


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// * Дополнительное задание.
// Оценка времени работы алгоритма через вещественые числа и строки
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
