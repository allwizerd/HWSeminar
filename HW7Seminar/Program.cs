double[,] CreateRandomedoubleNum(int rows, int colums)
{
    double[,] newArray = new double[rows, colums];


    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            newArray[i, j] = Convert.ToDouble(new Random().Next(-10, 10)) / 10;

    return newArray;
}
void Show2Array(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write("[" + array[i, j] + "]");

        Console.WriteLine();
    }
}
void FindId(double[,] array)
{
    Console.Write("Введите номер  строки: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер  столбца: ");
    int m = Convert.ToInt32(Console.ReadLine());
    if (n > array.GetLength(0) || m > array.GetLength(1))
    {
        Console.WriteLine("такого элемента нет");
    }
    else
    {
        Console.WriteLine($"значение элемента {n} строки и {m} столбца = {array[n - 1, m - 1]}");
    }

}
int[,] CreateRandome2Array(int rows, int colums, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, colums];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}
void mean(int[,] array, int m)
{
    int avarage = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        
        for (int i = 0; i < array.GetLength(0); i++)
            avarage = (avarage + array[i, j]);
        
    
        avarage =  avarage / m;
        Console.Write(avarage + "; ");
    }


}
void Show2dArrayInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}
Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
Console.Write("Введите цифру из приведенных заданий: ");

int task = Convert.ToInt32(Console.ReadLine());
if (task == 47)
{
    Console.Clear();
    Console.Write("Введите количество  строк: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество  столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] myArray = CreateRandomedoubleNum(m, n);
    Show2Array(myArray);

}
if (task == 50)
{
    Console.Clear();
    Console.Write("Введите количество  строк: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество  столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] myArray = CreateRandomedoubleNum(m, n);
    Show2Array(myArray);
    FindId(myArray);
}
if (task == 52)
{
    Console.Clear();
    Console.Write("Введите количество  строк: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество  колонок: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите мин: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите макс: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] myArray = CreateRandome2Array(m, n, min, max);
    Show2dArrayInt(myArray);
    Console.Write("Среднее арифметическое каждого столбца:");
    mean(myArray, m);

}