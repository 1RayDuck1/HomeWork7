//Домашнаяя работа.
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
double[,] CreateRandom2dArray()
{
    Console.Write("Введите количество столбцов: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество строк: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальный размер элиментов: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальный размер элиментов: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];
    double empty = 0;

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
            empty = new Random().NextDouble();
            array[i, j] += empty;
            array[i, j] = Math.Round(array[i, j], 2);
        }
    }
    return array;
}

void Show2dArray(double[,] array)
{
    Console.WriteLine();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
double[,] CreateRandom2dArray()
{
    Console.Write("Введите количество столбцов: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество строк: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальный размер элиментов: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальный размер элиментов: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(double[,] array)
{
    Console.WriteLine();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindArrayNumber(double[,] array)
{
    Console.Write("Введите номер столбца: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер строки: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    rows--;
    columns--;

    if(rows >= array.GetLength(0) || columns >= array.GetLength(1))
    {
        Console.WriteLine("Такого числа нет.");
    }
    else
        Console.WriteLine($"{array[rows, columns]}");
}

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
FindArrayNumber(myArray);
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


double[,] CreateRandom2dArray()
{
    Console.Write("Введите количество столбцов: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество строк: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальный размер элиментов: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальный размер элиментов: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(double[,] array)
{
    Console.WriteLine();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] FindArithmeticMean(double[,] array) 
{
    double[] newArray = new double[array.GetLength(1)];
    int index = 0;

    for(int j = 0; j < array.GetLength(1); j++)
    {
        double empty = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            empty += array[i, j];
        }
        newArray[index] = empty / array.GetLength(0);
        newArray[index] = Math.Round(newArray[index], 2);
        index++;
    }
    return newArray;
}

void ShowArray(double[] array)
{
    int rows = 1;
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Среднее арифметическое {rows} столбца -> {array[i]}");
        rows++;
    }
}

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
double[] newArray = FindArithmeticMean(myArray);
ShowArray(newArray);
