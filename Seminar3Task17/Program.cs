/*
 Напишите программу, которая принимает на вход
 координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
 номер четверти плоскости, в которой находится эта
 точка
*/

// Вводим данные
int getValue(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}



// По координатом точки определяем номер четверти 
string outOnConsol(int x, int y)
{
    if (x > 0 && y > 0) return ("I четверть");
    if (x < 0 && y > 0) return ("II четверть");
    if (x < 0 && y < 0) return ("III четверть");
    if (x > 0 && y < 0) return ("IV четверть");
    return ("такой четверти нет");
}

void printResult(string msg)
{
  Console.WriteLine(msg);
}

int pointX = getValue("Введите координату Х:");
int pointY = getValue("Введите координату Y:");

printResult("Точка находится в " + outOnConsol(pointX, pointY));