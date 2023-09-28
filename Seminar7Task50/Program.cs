// ===========================================================================================================
//                                 Домашнее задание к семинару 7.
//      Основное: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
//              возвращает значение этого элемента или же указание, что такого элемента нет.
//      Дополнительное (со *): Заполнить числами Фиббоначи и выделить цветом найденную цифру.
// ===========================================================================================================

using System.Numerics;

int readData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}


// Заполнениеи массива числами Фибоначи
BigInteger[,] FillArrFibVal(int row, int columm)
{
    BigInteger[,] array = new BigInteger[row, columm];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < columm; j++)
        {
            if ((i == 0 && j == 0) || (i == 0 && j == 1))
            {
                array[i, j] = 1;
            }
            else
            if (j == 0)
            {
                array[i, j] = array[i - 1, array.GetLength(1) - 2] + array[i - 1, array.GetLength(1) - 1];
            }
            else if (j == 1)
            {
                array[i, j] = array[i - 1, array.GetLength(1) - 1] + array[i, 0];
            }
            else { array[i, j] = array[i, j - 1] + array[i, j - 2]; }
        }
    }
    return array;
}


// Печать массива и результата поиска
void PrintResultArray(BigInteger[,] array, int pozRow, int pozColumm)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == (pozRow-1) && j == (pozColumm-1))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{array[i, j]} \t");
                Console.ResetColor();
            }
            else { Console.Write($"{array[i, j]} \t"); }
        }
        Console.WriteLine();
    }

    if ((pozRow-1) >= array.GetLength(0) || (pozColumm-1) >= array.GetLength(1))
        Console.WriteLine($"[ {pozRow}, {pozColumm} ] -> такого элемента в массиве нет");
}

int row = readData($"Введите число строк в массиве: ");
int columm = readData($"Введите число столбцов в массиве: ");
BigInteger[,] fibArray = FillArrFibVal(row, columm);
int findRow = readData($"Укажите строку элемента для поиска: ");
int findColumm = readData($"Укажите стлбец элемента для поиска: ");
PrintResultArray(fibArray, findRow,findColumm);