Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

int a = number % 100;
int b = a / 10;
Console.WriteLine($"Вторая цифра числа это {b}");