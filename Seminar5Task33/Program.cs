// Задача 33
// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.

// Создаем и заполняем одномерный массив случайными числами
int[] GenArray(int length, int lowBorder, int highBorder)
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

int ReadData()
{
    System.Console.WriteLine("Введите число для поиска: ");
    return (int num = int.Parce(Console.Read() ?? "0"));
}

(bool, int) FindElement(int[] arr, int elem)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == elem)
        {
            return ("Присутствует", i);
        }
        else
        {
            return ("Отсуутствует", -1);
        }
    }
}

int[] array = GenArray[10, 0, 10];
int element = ReadData();
PrintArray(array);
(bool fineElem, int elem) check = FindElement(array, element);

System.Console.WriteLine($"Значение {element} {check.fineElem} в массиве под индексом {check.elem}");

