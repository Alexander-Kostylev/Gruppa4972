//=================================================================================
//                          Задача 63
//              Задать значение N. Написать программу, 
//      которая выведет все натуральные числа в промежутке от N до 1.
//                  Выполнить с помощью рекурсии.
//=================================================================================

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void GetLineRec(int num)
{
    Console.Write(num + " ");


    if (num <= 0)
    {

    }
    else
    {
        GetLineRec(num - 1);
    }

}

int num=ReadData("Введите число N: ");
GetLineRec(num);