//===============================================================================
//                             Домашнее задание 
//         Напишите программу, которая найдёт точку пересечения двух прямых, 
//              заданных уравнениями y = k1 * x + b1, y = k2 * x + b2. 
//                  Значения b1, k1, b2 и k2 задаются пользователем.
//===============================================================================

//  Ввод значений
string[] ReadData(string msg)
{
    Console.Write(msg);

    string koord=Console.ReadLine() ?? "0";
    string[] strNum=koord.Split(',');

    return strNum;
}

//  Преобразование строки->число для математич. операций
int[] StringToIntegerArray(string[] str)
{
    int[] lineValue=new int[str.Length];
    lineValue[0] = Convert.ToInt32(str[0]);
    lineValue[1] = Convert.ToInt32(str[1]);

    return lineValue;
}

//  Расчет точки пересечения прямых
(int, int) IntersectionPoint(int[] lineFerst, int[] lineSecond)
{
    int pointX = (lineSecond[1] - lineFerst[1]) / (lineFerst[0] - lineSecond[0]);
    int pointY = lineSecond[0] * (pointX)+lineSecond[1];
    return(pointX, pointY);
}

//  Вывод результата на экран
void PrintData(int x, int y)
{
    Console.WriteLine($"Точка пересечения линий ({x}, {y})");
}



string[] enterLineFirst = ReadData("Введите координаты k и b для 1 линии: ");
string[] enterLineSecond = ReadData("Введите координаты k и b для 2 линии: ");

int[] lineFirst = StringToIntegerArray(enterLineFirst);
int[] lineSecond = StringToIntegerArray(enterLineSecond);

(int x, int y) point= IntersectionPoint(lineFirst, lineSecond);

PrintData(point.x, point.y);