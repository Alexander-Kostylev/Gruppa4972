/*
Задача №30
Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
*/

// Ввод числа из консоли
int readData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Вывод числа в консоль
void PrintArray(int[] arr)
{
    Console.Write($"[ ");
    for(int i=0; i<arr.Length-1;i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.Write(arr[arr.Length-1]+" ]");
}

int[] genArray(int length)
{
    int[] arr = new int[length];

    Random rad = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rad.Next(0, 2);
    }
    return arr;
}

int len=readData("Введите длинну массива ");

int [] arrResult=genArray(len);

PrintArray(arrResult);