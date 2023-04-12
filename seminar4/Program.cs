// Задача #1. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int CountNum(int num)
{
    int total = 0;
    // int trash = 0;

    while(num > 0)
    {
        total++;
        num = num / 10;
    }
    return total;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Цифр в числе {num} {CountNum(num)}");
*/

// Задача #2. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int MultNum(int num)
{
    int total = 1;
    for (int i = 1; i <= num; i++)
    {
        total = total * i;
    }
    return total;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Факториал числа {num} = {MultNum(num)}");
*/



// Домашнее задание. 
// Задача #1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int ExpNum(int num, int stepen)
{
    int num_copy = num;
    for (int i = 1; i < stepen; i++) 
        num = num * num_copy;
    return num;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("В какую степень возводить: ");
int stepen = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ExpNum(num, stepen));
*/

// Задача #3. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumNum(int num)
{
    int total = 0;

    while(num > 0)
    {
        total = total + num % 10;
        num = num / 10;
    }
    return total;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма ицфр числа {num} = {SumNum(num)}");
*/

// Задача #3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
int[] arrayCreate(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1} элемент массива: ");
        int num = Convert.ToInt32(Console.ReadLine());
        array[i] = num;
    }

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = arrayCreate(size);
ShowArray(newArray);
*/

