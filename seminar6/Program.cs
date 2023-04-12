// Задача семинар 1. 
// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/*
bool TriangleCorrect(int side1, int side2, int side3)
{

    if(side1 + side2 > side3 && side2 + side3 > side1 && side1 + side3 > side2)
        return true;
    else return false;
}

Console.Write("Введите размер массива: ");
int side1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение массива: ");
int side2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение массива: ");
int side3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(TriangleCorrect(side1, side2, side3));
*/

// Задача семинар 2.
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
/*
int[] Fibo()
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int i = 2;
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    while (i < num)
    {
        array[i] = array[i-1] + array[i-2];
        i++;
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int k = 0; k < array.Length; k++)
        Console.Write(array[k] + " ");
    Console.WriteLine();
}

ShowArray(Fibo());
Fibo();
*/

// Задача семинар 3. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
/*
int[] CopyArr(int[] array)
{
    int[] copyArray = new int[array.Length];

    for( int i = 0; i < array.Length; i++)
        copyArray[i] = array[i];

    return copyArray;
}
*/

// Задача с ** семинар. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
/*
string ConvertToByte(int n)
{
    string s = string.Empty;
    while(n >= 2)
    {
        s = s + n % 2;
        n = n / 2;
    }
    s = s + n;
    return s;
}


string ReverseString(string text)
{
    string copyText = string.Empty;
    int num = Convert.ToInt32(text.Length);
    for(int i = 0; i < text.Length; i++)
    {
        char txt = text[num - i -1];
        copyText += txt;
    }

    return copyText;
}

Console.Write("Введите число десятичной системы исчисления, которое нужно перевести в двоичную: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ReverseString(ConvertToByte(n)));
*/

// Задача 1 ДЗ. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int SearchPositivNum(int num)
{
    int positivNum = 0;
    for(int i = 1; i < num; i++)
    {
        Console.Write($"Введите {i} число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        if (num2 > 0)
            positivNum++;
    
    }
    return positivNum;
}

Console.Write("Введите количество чисел ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SearchPositivNum(num));
*/

// Задача 2 ДЗ. Напишите программу, которая найдёт точку пересечения двух прямых.
/*
void CrossLines(double k1, double b1, double k2, double b2)
{
    double x = Math.Round(((b2 - b1) / (k1 - k2)), 2);
    double y = Math.Round((((k1 * (b2-b1)) / (k1 - k2)) + b1), 2);

    if(k1 == k2)
        Console.Write("Прямые являются параллельными (или совпадают), точки пересечения прямых нет.");
    else
        Console.Write($"Координаты точки пересечения заданных прямых ({x}; {y})");
}

Console.WriteLine("Чтобы увидеть координаты точки пересечения прямых y = k1x + b1, y = k2x + b2 введите следующие данные: ");
Console.Write("Введите k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2:");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2:");
double b2 = Convert.ToDouble(Console.ReadLine());

CrossLines(k1, b1, k2, b2);
*/


string ConvertToByte(int n)
{
    string s = string.Empty;
    while (n >= 2)
    {
        s = n % 2 + s;
        n = n / 2;
    }
    s = n + s;
    return s;
}
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(ConvertToByte(n));