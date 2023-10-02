// ==============================================================================
//                            Задание №66
//              Задайть значения M и N. Написать программу, 
//      которая найдёт сумму натуральных элементов в промежутке от M до N.
// ==============================================================================

// Записываем данные из консоли в переменный
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//Нахождение суммы натуральных чисел в заданном диапазоне, рекурсией
int SumOfNaturalNum(int lowNum, int higtNum)
{
    int res=0;
    if(lowNum>=higtNum) return lowNum;
    else res+=higtNum+SumOfNaturalNum(lowNum,higtNum-1);
    return res;
}


int lowNumber=ReadData("Введите начальное число: ");
int higtNumber=ReadData("Введите конечное число: ");
//int result=SumOfNaturalNum(((lowNumber<higtNumber)?(lowNumber,higtNumber):(higtNumber,lowNumber)));
Console.WriteLine($"Сумма всех натуральных чисел от {lowNumber} до {higtNumber} равна {((lowNumber<higtNumber)?(SumOfNaturalNum(lowNumber,higtNumber)):SumOfNaturalNum(higtNumber, lowNumber))}");

