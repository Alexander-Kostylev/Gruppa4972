/*
Задача №26
Напишите программу, которая принимает на вход число 
и выдаёт количество цифр в числе.
*/

// Ввод числа из консоли
int readData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Вывод числа в консоль
void PrintResult(string mes)
{
    Console.WriteLine(mes);
}

//функция нахождения количества цифр в числе
int NumDigits(int num)
{
    int valOfNum = 0;
    while (num > 0)
    {
        num = num / 10;
        valOfNum++;
    }

    return valOfNum;
}

int entNum=readData("Введите число: ");

int result=NumDigits(entNum);

PrintResult($"Количество цифр в числе {entNum} равно {result}");