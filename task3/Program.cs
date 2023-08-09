string[] days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.WriteLine("Введите номер дня недели и узнайте выходной ли это:");
int number = Convert.ToInt32(Console.ReadLine()) - 1;
if (number == 5 | number == 6)
{
    Console.WriteLine($"Да, {days[number]} это выходной");
}
else
{
    Console.WriteLine($"Нет, {days[number]} это не выходной");
}