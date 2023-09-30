
// ---------------------------------------------------------------------
//                                 Задача 65
//                  Задайте значения M и N. Напишите программу, 
//         которая найдёт все натуральные элементы в промежутке от M до N.
// ---------------------------------------------------------------------

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

string RecMN(int n, int m)
{
    string res = string.Empty;
    
    if (n >= m)
    {
        res = $"{n}";
    }
    else
    {
        res = $"{m}, {RecMN(n, m + 1)}";
    }

    return res;
}

void PrintData(string str)
{
    Console.WriteLine(str);
}

int maxNum = ReadData("Введите максимальное число: ");
int minNum = ReadData("Введите минимальное число: ");

string result=RecMN(minNum,maxNum);
PrintData(result);