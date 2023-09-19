// Задача 32
// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.

// Создаем и заполняем одномерный массив случайными числами
int[] genArray(int length, int lowBorder, int highBorder)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(lowBorder, highBorder + 1);
    }
    return arr;
}

// Вывод массива
void PrintArray(int[] arr)
{
    Console.Write($"[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + " ]");
    System.Console.WriteLine();
}

// Получаем сумму всех отрицательных чисел массива, а также сумму всех положительных элементов
(int, int) NegotivPositivSum(int[] arr)
{
    int posSum = 0;
    int negSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            posSum += arr[i];
        }
        else
        {
            negSum += arr[i];
        }
    }
    return (posSum, negSum);
}

int[] array = genArray(12, -9, 9);

PrintArray(array);
(int pos, int neg) sum = NegotivPositivSum(array);
System.Console.WriteLine($"Сумма всех положительных чисел = {sum.pos}\nСумма всех отрицательных чисел = {sum.neg}");