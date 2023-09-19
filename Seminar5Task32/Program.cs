// Задача 32.
// Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.

//Создаем и заполняем массив
int[] GenArray(int length, int lowBorder, int highBorder)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(lowBorder, highBorder + 1);
    }
    return arr;
}

// вывод результата
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

//изменение знака числа
void InversArray(int [] arr)
{
    for(int i=0;i<arr.Length;i++)
    {
        arr[i]*=-1;
    }
}

int [] array=GenArray(12,-9,9);
PrintArray(array);
InversArray(array);
PrintArray(array);