// Домашнее задание к семинару 5
// Задать массив заполненный случайными положительными трёхзначными числами.
// Отсортировать массив методом пузырька.

//
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
}


void PrintArray(int[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

void ArrBubbleSort(int[] arr)
{
    for (int i = 0; i < arr.Length-1; i++)
    {
        for(int j = 0; j < arr.Length-1; j++)
        {
            int temp = 0;
            if (arr[j] > arr[j+1])
            {
                temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }

        }
       
    }

}

Console.WriteLine("Укажите количество цифр в массиве: ");

int leng = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[leng];

FillArray(array);
PrintArray(array);
ArrBubbleSort(array);
Console.WriteLine();
PrintArray(array);
