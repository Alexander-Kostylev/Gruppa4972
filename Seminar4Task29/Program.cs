//============================================================
// Основное задание.
// Написать программу, которая задает массив из 8 элементов и выводит их на экран.
//============================================================

/*
//Создание массива на 8 элементов
int[] createArray()
{
    int[] array = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
    return array;
}

// Печать массива
void printArray(int[] ar)
{

    System.Console.WriteLine("Массив: ");
    System.Console.Write("[ ");
    for (int i = 0; i < ar.Length - 1; i++)
    {
        System.Console.Write(ar[i] + ", ");
    }
    Console.Write(ar[ar.Length - 1] + " ]");
}

int[] newArray = createArray();

printArray(newArray);

*/

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// * Дополнительное задание.
// Ввести с клавиатуры длинну массива и диапазон значений
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

int readData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

void printArray(int[] ar)
{

    System.Console.WriteLine("Созданный массив: ");
    System.Console.Write("[ ");
    for (int i = 0; i < ar.Length - 1; i++)
    {
        System.Console.Write(ar[i] + ", ");
    }
    Console.Write(ar[ar.Length - 1] + " ]");
}

int[] createRandArray(int len, int min, int max)
{
    int[] arrayRand = new int[len];
    Random num = new Random();
    for (int i = 0; i < len; i++)
    {
        arrayRand[i] = num.Next(min, max);
    }
    return arrayRand;
}

int lenAr = readData("Укажите длинну массива: ");
int minValue = readData("Укажите минимальное значение: ");
int maxValue = readData("Укажите максимальное значение: ");

int[] arrayRand = createRandArray(lenAr, minValue, maxValue);
printArray(arrayRand);