int[,] CreateRandome2Array(int rows, int colums, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, colums];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}
void OrderArrayLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] > array[i, k + 1])//уточнить про сторону >
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}
int FindMinSumLine(int[,] myArray)
{
    int minSumLine = 0;
    int sumLine = SumLineElements(myArray, 0);
    for (int i = 1; i < myArray.GetLength(0); i++)
    {
        int tempSumLine = SumLineElements(myArray, i);
        if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            minSumLine = i;
        }
    }
    return minSumLine;
}
int SumLineElements(int[,] array, int i)
{

    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}
void spiral4x4()
{
    int n = 4;
    int[,] SpirMatrix = new int[n, n];
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= SpirMatrix.GetLength(0) * SpirMatrix.GetLength(1))
    {
        SpirMatrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < SpirMatrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= SpirMatrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > SpirMatrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    Show2dArray(SpirMatrix);
}

Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
Console.WriteLine("Задача 62. Заполните спирально массив 4 на 4.");
Console.Write("Введите цифру из приведенных заданий: ");

int task = Convert.ToInt32(Console.ReadLine());
if (task == 54)
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
    Show2dArray(myArray);

    Console.WriteLine($"\nОтсортированный массив: ");
    OrderArrayLines(myArray);
    Show2dArray(myArray);
}
if (task == 56)
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
    Show2dArray(myArray);

    Console.WriteLine($"\n{FindMinSumLine(myArray)} - строкa с наименьшей суммой ({SumLineElements(myArray, FindMinSumLine(myArray))}) элементов ");


}
if (task == 62)
{
    spiral4x4();

}