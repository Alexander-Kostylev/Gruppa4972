// Напишите программу, 
// которая будет преобразовывать десятичное число в двоичное.


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

string DecToBin(int value)
{
    string line=String.Empty;
    while(value>0)
    {
        line=value%2+line;
        value/=2;
    }

    return line;
}

int number=readData("Введите число: ");
string result=DecToBin(number);
PrintResult($"Число {number} в двоичной системе {result}");
