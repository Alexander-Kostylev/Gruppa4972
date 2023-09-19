//============================================================
// Основное задание.
// Написать цикл, который 
// принимает на вход два числа (А и В) 
// и возводит число А в натуральную степень В.
//============================================================

/*
// Получение данных от пользователя 
int readData(string message)
{
    Console.Write(message);
    int inputData = int.Parse(Console.ReadLine() ?? "0");
    return inputData;
}

// Возведение в степень
long raiseToADegree(int num, int degree)
{
    int tempDegree = 1;
    int result = 1;
    while (tempDegree <= degree)
    {
        result *= num;
        tempDegree++;
    }
    return result;
}

// Вывод результата
void outConsole(string mes)
{
    Console.WriteLine(mes);
}

int number = readData("Введите число: ");
int valueOfDegree = readData("Введите степень: ");

long result = raiseToADegree(number, valueOfDegree);

outConsole($"{number}^{valueOfDegree}={result}");

*/

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// * Дополнительное задание.
// Программа калькулятор с операциями 
// +,-,/,*, возведение в степень
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

// Получение данных от пользователя
using System.Collections;

int readData(string message)
{
    Console.Write(message);
    int inputData = int.Parse(Console.ReadLine() ?? "0");
    return inputData;
}

// Вывод результата
void outConsole(string mes)
{
    Console.WriteLine(mes);
}

// выбор операции над числами
char outSimvol()
{

    while (true)
    {
        Console.WriteLine("Выберите одно из следующих действий: +, -, *, /, ^");
        char operation = char.Parse(Console.ReadLine() ?? "0");
        if (operation == '+' || operation == '-' || operation == '*' || operation == '/' || operation == '^')
            return operation;
        Console.WriteLine($"{operation} - данного действия не предусмотренно.");
    }

}

double calculator(int num1, int num2, char oper)
{
    double res = 1;
    switch (oper)
    {
        case ('+'):
            res = num1 + num2;
            break;
        case ('-'):
            res = num1 - num2;
            break;
        case ('*'):
            res = num1 * num2;
            break;
        case ('/'):
            res = (double)num1 / num2;
            break;
        case ('^'):
            res = Math.Pow(num1, num2);
            break;

    }
    return res;

}

int number1 = readData("Введите 1-е число: ");
char op = outSimvol();
int number2 = readData("Введите 2-е число: ");


double result = calculator(number1, number2, op);

outConsole($"{number1} {op} {number2} = {result}");