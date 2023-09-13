/*
Задача №22
Напишите программу, 
которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N.
*/

int readData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

string BuildLine(int num, int pow)
{
    string res = "";
    for (int i = 1; i <= num; i++)
    {
        res = res + Math.Pow(i, pow) + " ";
    }
    return res;
}

void printResult(string msg)
{
    Console.WriteLine(msg);
}

int num = readData("Введите число ");
int pow = readData("Введите степень ");
printResult(BuildLine(num, pow));

// метод для вывода нескольх строк
