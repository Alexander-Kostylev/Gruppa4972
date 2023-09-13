/*
Задача №18
Напишите программу, 
которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/

// название метода для максимального использования в других программах
int readData()
{
    Console.WriteLine("Введите номер четверти: ");
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

string rangPoint(int numQuter)
{
    switch (numQuter)
    {
        case 1: return ("Координата Х >0 и Y>0");
        case 2: return ("Координата Х <0 и Y>0");
        case 3: return ("Координата Х <0 и Y<0");
        case 4: return ("Координата Х >0 и Y<0");
        default: return ("Неверная четверть");
    }
}

void printResult(string msg)
{
    Console.WriteLine(msg);
}

int QuterNumber = readData();

printResult(rangPoint(QuterNumber));
