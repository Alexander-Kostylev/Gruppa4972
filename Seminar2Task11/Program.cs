// Сгенерировать 3-х значное число, 
// удалить второй разряд числа, 
// а оставшееся 2-х значное число вывести 

System.Random numberGenerator = new System.Random();
int num = numberGenerator.Next(100, 999);

Console.WriteLine(num);

Console.Write(num/100);
Console.Write(num%10);
