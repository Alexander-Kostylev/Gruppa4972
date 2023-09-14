/*
Задание со * от Антона, одногруппник
*/

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Возводим в любую степень и формируем строку для таблицы
string BuildLine(int num, int pow)
{
    string line = "+----------+------------+\n";
    line += "|   Число  | Возведено в " + pow + " |\n";
    line += "+----------+------------+\n";

    for (int i = 1; i <= num; i++)
    {
        line += "|   " + i.ToString().PadRight(4) + "   |   " + Math.Pow(i, pow).ToString().PadRight(9) + "   |\n";
    }

    line += "+----------+------------+";

    return line;
}

// Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int num = ReadData("Введите число: ");
int pow = ReadData("Введите степень: ");
string result = BuildLine(num, pow);
PrintResult(result);