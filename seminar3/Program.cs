// Задача #1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool Transfrom (int number)
{
    int copyNumber = number;
    int reversNum = 0;
    while(number > 0)
    {
        int lastDig = number%10;
        reversNum = reversNum*10 + lastDig;
        number = number/10;
    }

    if (reversNum == copyNumber) return true;
    else return false;
}

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (Transfrom(number) == true) Console.WriteLine("Число является палиндромом.");
else Console.WriteLine("Число не является палиндромом.");
*/

// Задача #2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Lenght(double x1, double y1, double z1, double x2, double y2, double z2)
{
     return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}

Console.Write("Введите координаты точки А по оси Х: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты точки А по оси Y: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты точки А по оси Z: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты точки B по оси Х: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты точки B по оси Y: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты точки B по оси Z: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Расстояние между A и B {Math.Round(Lenght(x1, y1, z1, x2, y2, z2), 2)}");
*/

// Задача #3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void numPow (int number)
{
    for (int i = 1; i <= number; i++) Console.WriteLine($"{i} - {Math.Pow(i, 3)}");
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

numPow(number);
*/