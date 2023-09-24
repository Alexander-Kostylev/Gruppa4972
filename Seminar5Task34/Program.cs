//===============================================================================================
//                                      Домашнее задание к Семинару 6.
//                  Задать массив заполненный случайными положительныйми числами и
//                        найти количество четных элементов в данном массиве.
//===============================================================================================

int readData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

void PrintData(string mes, int result)
{
    Console.WriteLine(mes + " -> " + result);
}

void PrintArray(string mes, int[]arr)
{
    Console.Write(mes + ":\n [" );
    for(int i=0; i<arr.Length-1; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write($" {arr[arr.Length-1]}]");
}

int EventNumberOfArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)  count++; 
    }
    return count;
}

int[] GenArray(int numberOfArray, int lowBorder,  int highBorder)
{
    int[] arr = new int[numberOfArray];
    for(int i=0; i<numberOfArray; i++)
    {
        arr[i] = new Random().Next(lowBorder, highBorder + 1);
    }
    return arr;
}

int numberOfArray = readData("Введите какое количество цифр будет в массиве: ");
int lowValue = readData("Введите нижнюю границу цифр: ");
int higtValue = readData("Введите верхнюю границу цифр: ");
int[] array = GenArray(numberOfArray, lowValue, higtValue);
int evenNumberOfArray = EventNumberOfArray(array);
PrintArray("Исходный массив", array);
PrintData("Количество четных элементов", evenNumberOfArray);