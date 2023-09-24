//===============================================================================================
//                                 Домашнее задание к Семинару 6
//                   Задать одномерный массив, заполненный случайными числами.
//                      Найти сумму элементов, стоящих на не четных позициях.
//===============================================================================================

int readData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

void PrintData(string mes, int result)
{
    Console.WriteLine(mes + " = " + result);
}

void readArrData(int[] arr)
{
    Console.Write("Исходный массив: [");
    for(int i=0; i<arr.Length-1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length-1]}]");
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

int CountNonEvenElements(int[] arr)
{
    int count = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        count+=arr[i]; 
    }
    return count;
}

int numberOfArray = readData("Введите какое количество цифр будет в массиве: ");
int lowValue = readData("Введите нижнюю границу цифр: ");
int higtValue = readData("Введите верхнюю границу цифр: ");
int[] array = GenArray(numberOfArray, lowValue, higtValue);
int result = CountNonEvenElements(array);
readArrData(array);
PrintData("Сумма нечетных элементов равна",result);