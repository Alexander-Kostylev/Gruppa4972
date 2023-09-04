// Задача №7
// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Enter the number: ");
int num=int.Parse(Console.ReadLine()??"0");

if(num>99&&num<1000)
{
    int lastNum=num%10;
    Console.WriteLine("Последнее число "+num+" это "+lastNum);
}
else
{
    Console.WriteLine("Число не трехзначное")
}