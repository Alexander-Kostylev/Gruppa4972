﻿// Задача №35
// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].


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

int CountElement(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] >= 10) && (array[i]) <= 99)
        {
            count++;
        }
    }
    return count;
}

void PrintData(string message)
{
    System.Console.WriteLine(message);
}

int[] arr=genArray(123, 0, 1000);
int count=CountElement(arr);
PrintArray(arr);
PrintData($"Количество элементов в массиве от 10 до 99 = {count}");