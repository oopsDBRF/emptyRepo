// leasson 2

// Задача #1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int Div(int num)
{
    return (num/10)%10;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Div(num));
*/

// Задача #2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
/*
int Div2(int num1)
{
    if (num1 < 100)
    {
        return num1;
    }
    else
    {
        while (num1 > 1000)
        {
            num1 = num1 / 10;
        }

        return num1 % 10;
    }
}


Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 == Div2(num1))
{
    Console.WriteLine($"Ваше число {num1} не имеет третьей цифры");
}
else
{
    Console.WriteLine(Div2(num1));
}
*/

// Задача #3.  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
/*
bool Div3(int num2)
{
    if (num2 >= 1 && num2 <= 5 || num2 > 7)
    {
        return false;
    }
    else
    {
        return true;
    }
}

Console.Write("Введите день недели: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Div3(num2));
*/








// Задача 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
// выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int Div (int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    
    return -1;
}

Console.Write("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Div(x, y));
*/

// Задача 2.Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
/*
double Div (double x1, double y1, double x2, double y2)
{
    double len_x = x2 - x1;
    double len_y = y2 - y1;

    double len_xy = Math.Sqrt(len_x * len_x + len_y * len_y);

    return len_xy;
}

Console.Write("Введите координату X1: ");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату X2: ");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Round(Div(x1, y1, x2, y2), 2));
*/

// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
/*
void Div(int num)
{
    for(int i = 1; i <= num; i++) Console.WriteLine($"{i} - {i*i}");
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Div(num);
*/


double Length(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}

Console.Write("Введите x точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите у точки А: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z точки А: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.Write("Введите x точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите у точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z точки B: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine($"Расстояние между точками А и В равно {Math.Round(Length(x1, y1, z1, x2, y2, z2), 2)}");