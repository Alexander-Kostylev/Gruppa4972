// Задача №37
// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

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

// Создаем новый массив
int[] NewArray(int[] arr)
{
    int[] newArray= new int [arr.Length/2];
    for(int i=0; i<arr.Length/2; i++)
    {
        newArray[i]=arr[i]*arr[arr.Length-i-1];
    }
    return newArray;
}


int[] arr=genArray(11, 1, 20);
PrintArray(arr);
int[] newArr=NewArray(arr);
PrintArray(newArr);