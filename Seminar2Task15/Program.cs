// Написать программу,
// которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

int getValue()
{
    Console.WriteLine("Введите цифру дня нендели");
    int val = int.Parse(Console.ReadLine() ?? "0");
    return val;
}

//определяем словарь и сразу инициализируем его
var dayOfWeek = new Dictionary<int, string>()
{
    {1, "Нет"},
    {2, "Нет"},
    {3, "Нет"},
    {4, "Нет"},
    {5, "Нет"},
    {6, "Да"},
    {7, "Да"}
};

int day = getValue();

Console.WriteLine("День недели под номером " + day + " выходной -> " + dayOfWeek[day]);