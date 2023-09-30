//========================================================================
//                              Задача 70
//          Напишите прграмму, которая будет принимать 2 числа А и В
//                  возыедите А в степень В с помощью рекурсии
//=========================================================================

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

long RecRow(int a, int b)
{
    long res = 1;
    if (b <= 0)
    {
        return 1;
    }
    else
    {
        res = a * RecRow(a, b - 1);

    }

    return res;
}

long MyPow(int a,int b)

{

    if(b==2) return a*a;
    if(b==1) return a;
    if(b%2==0)
    {
        return MyPow(a,b/2)*MyPow(a,b/2);
    }
    else
    {
        return MyPow(a,b/2)*MyPow(a,b/2+1);
    }

}

int number = ReadData("Введите число: ");
int degree = ReadData("Введите степень: ");
long result1=RecRow(number,degree);
long result2=MyPow(number,degree);
Console.WriteLine($" Число {number} в степени {degree} равно {result1}");
Console.WriteLine($" Число {number} в степени {degree} равно {result2}");
