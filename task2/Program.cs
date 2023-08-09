Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int numberShadow = number; //Дублирую переменную для корректной работы строки 17
if (number / 100 == 0)
{
    Console.WriteLine($"Третьей цифры в числе {number} нет");
}
else
{
    while (numberShadow > 999)
    {
        numberShadow = numberShadow / 10;
    }

    int a = numberShadow % 100;
    int b = a % 10;
    Console.WriteLine($"Третья цифра в числе {number} это {b}");
}