/*
Задача №20
Напишите программу, 
которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве.
*/

int readData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

double distanceBetweenPoints(int x1, int x2, int y1, int y2)
{
    double res = Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1 - y2),2));
    return res;
}

void printResult(string msg)
{
    Console.WriteLine(msg);
}

int p1CordX = readData("Введите координату Х первой точки");
int p1CordY = readData("Введите координату Y первой точки");
int p2CordX = readData("Введите координату Х второй точки");
int p2CordY = readData("Введите координату Y второй точки");

double result = distanceBetweenPoints(p1CordX, p2CordX, p1CordY, p2CordY);

printResult("Расстояние между точками равна " + result);