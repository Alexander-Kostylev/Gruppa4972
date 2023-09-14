/*
Написать программу которая принимает число N 
и выводит сумму всех чисел от 1 до N
*/

//Ввод числа из консоли
int readData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

//Получение суммы числа от 1 до N
int sumNumber(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

int GausseSum(int num)
{
    int sumNumber=0;
    sumNumber=num*(num+1)/2;
    return sumNumber;
}

//Вывод результата в консоль
void outConsole(string mes)
{
    Console.WriteLine(mes);
}

int enterNumber = readData("Введите число: ");

DateTime d1=DateTime.Now;       //метод получения текущей даты

int result1 = sumNumber(enterNumber);
Console.WriteLine(DateTime.Now-d1);

DateTime d2=DateTime.Now;
int result2=GausseSum(enterNumber);
Console.WriteLine(DateTime.Now-d2);

outConsole($"Сумма чисел от 1 до {enterNumber} = {result1}");
outConsole($"Сумма чисел от 1 до {enterNumber} = {result2}");