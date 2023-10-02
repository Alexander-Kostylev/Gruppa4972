// =============================================================================
//                          Задание №64
//              Задайть значение N. Написать программу, 
//      которая выведет все натуральные числа в промежутке от N до 1. 
//                  Выполнить с помощью рекурсии.
// =============================================================================

// Записываем данные из консоли в переменный
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать от заданной цифры до 1
void PrintNumberRec( int num)
{
    Console.Write(num+", ");
    if(num>2) PrintNumberRec(num-1);
    else Console.Write(num-1);
}

int enterNumber=ReadData($"Введите число N: ");
Console.WriteLine("Все натуральные числа от N до 1:");
PrintNumberRec(enterNumber);