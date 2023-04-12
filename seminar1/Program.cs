// ДЗ №1.

// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2)
{
    Console.Write("Число " + n1 + " больше числа " + n2);
}
else
{
    Console.WriteLine($"Число {n2} больше числа {n1}");
}
*/


// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int n3 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2 & n1 > n3)
{
    Console.WriteLine($"Максимальное {n1}");
}
else if (n2 > n1 & n2 > n3)
{
    Console.WriteLine($"Максимальное {n2}");
}
else
{
    Console.WriteLine($"Максимальное {n3}");
}
*/


// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число является нечетным");
}
*/

// Задача 4.  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
/*
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= n; i = i + 2)
{
    Console.WriteLine(i);
}
*/


// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int Comparison(int number)
{
    int first = number/10;
    int last = number%10;

    if (first > last)
    {
        return first;
    }
    else
    {
        return last;
    }
}

int number = new Random().Next(10, 100);

Console.WriteLine($"Наибольшая цифра числа {number} это {Comparison(number)}");
*/



// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.
/*
bool TestNum (int number, int div1, int div2)
{
    if (number%div1 == 0 && number%div2 ==0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число a: ");
int div1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
int div2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(TestNum(number, div1, div2));
*/


//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого
/*
bool TestNum(int num1, int num2)
{
    if (num1 == num2*num2 || num2 == num1*num1)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(TestNum(num1, num2));
*/