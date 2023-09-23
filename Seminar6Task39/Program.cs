// Напишите программу, которая перевернёт одномерный
// массив (последний элемент будет на первом месте, а первый - на
// последнем и т.д.)

int[] genArray(int length, int lowBorder, int highBorder)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(lowBorder, highBorder + 1);
    }
    return arr;
}

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

int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        outArr[arr.Length - 1 - i] = arr[i];
    }
    return outArr;
}

void SwapArray(int[] arr)
{
    int buferElement = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        buferElement = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = arr[i];
        arr[i] = buferElement;
        //(arr[arr.Length-1-i],arr[i])=(arr[i],arr[arr.Length-1-i]);  //аналогичный указанному выше коду через промежуточную переменную.
        // синтаксический сахар 
    }
}

int[] arr = genArray(15, 1, 100);
PrintArray(arr);
int[] swapArray = SwapNewArray(arr);
System.Console.WriteLine("Исходный массив");
PrintArray(arr);
System.Console.WriteLine("Перевернутый массив через промежуточный массив");
PrintArray(swapArray);
System.Console.WriteLine("Перевернутый массив с исп. промежуточной переменной");
SwapArray(arr);
PrintArray(arr);