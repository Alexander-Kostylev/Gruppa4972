// Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.

int readData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

void PrintResult(string mes)
{
    Console.WriteLine(mes);
}

bool TriangleTest(int a, int b, int c)
{
    bool res = true;
    if (a + b <= c) res = false;
    if (a + c <= b) res = false;
    if (b + c <= a) res = false;
    return res;
}


int a = readData("1-я сторона треугольника = ");
int b = readData("2-я сторона треугольника = ");
int c = readData("3-я сторона треугольника = ");

bool result = TriangleTest(a, b, c);

PrintResult($"Существует треугольник со сторонами {a}, {b}, {c}, {result}");