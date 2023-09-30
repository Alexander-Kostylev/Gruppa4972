// ---------------------------------------------------------------------------
//                                  Задача 67
//         Программа примает на вход число N и возвращает сумму цифр в числе
// ---------------------------------------------------------------------------

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Нахождение суммы цифр в цисле 
int SumDigitRec(int num)
{

    if (num == 0)
    {
        return 0;
    }
    else
    {
        return num % 10 + SumDigitRec(num / 10);
    }

}

// задаем число
int number=ReadData($"Введите число: ");

// выводим сумму всех цифр в числе 
System.Console.WriteLine($"Сумма всех цифр в числе {number} равна {SumDigitRec(number)}.");