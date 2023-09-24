//======================================================================================
//                          Домашнее задание к Семинару 6
//                         Задать массив вещественных чисел.
//          Найти разницу между максимальным и минимальным элементом массива.
//======================================================================================

int readData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

void PrintData(string mes)
{
    Console.WriteLine(mes);
}

// Печать масиива
void readArrData(double[] arr)
{
    Console.Write("Исходный массив: [");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

// Создание массива вещественных чисел 
double[] GenArray(int numberOfArray, int lowBorder, int highBorder)
{
    double[] arr = new double[numberOfArray];
    for (int i = 0; i < numberOfArray; i++)
    {
        arr[i] = Math.Round((new Random().Next(lowBorder, highBorder + 1) + new Random().NextDouble()), 2);
    }
    return arr;
}

// Поиск минимального и максимального элементов массива
(double, double) FindMinMaxValue(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        min = (arr[i] < min) ? arr[i] : min;
        max = (arr[i] > max) ? arr[i] : max;
    }
    return (min, max);
}

int numberOfArray = readData("Введите какое количество цифр будет в массиве: ");
int lowValue = readData("Введите нижнюю границу цифр: ");
int higtValue = readData("Введите верхнюю границу цифр: ");
double[] array = GenArray(numberOfArray, lowValue, higtValue);
(double min, double max) value = FindMinMaxValue(array);
readArrData(array);
PrintData($"Максимальное число = {value.max}\nминимальное число = {value.min}\nИх разница = {Math.Round(value.max-value.min, 2)}");