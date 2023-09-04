// Задача №3
// Напишите программу, которая будет выдавать название дня недели по заданному номеру.


// запрос дня недели от системы
// string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(dayNum));


Console.WriteLine("Enter day number");

int day=int.Parse(Console.ReadLine()??"0");