int[] CreateRandomArray(int size, int minValvue, int maxValuvue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValvue, maxValuvue + 1);

    return newArray;
}

int[] CreatArray(int size)
{
    int[] newArray = new int[size];

    Console.WriteLine("Creating array here: ");
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Inout{i+1} element:");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    } 
    Console.WriteLine();
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int chet(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;
    return count;
}

int SumNeChet(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 == 1) 
            sum = sum + array[i];
    return sum;
}


int DiffMaxMin(int[] array)
{
    int maxNumber = array[0];
    int minNumber = array[0];    
    for (int i = 0; i < array.Length; i++)
        if (maxNumber < array[i]) maxNumber = array[i];
    for (int i = 0; i < array.Length; i++)
        if (minNumber > array[i]) minNumber = array[i];
    int difference = maxNumber - minNumber;
    return difference;
}

Console.WriteLine("Выберите цифру из данных заданий:");
Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
int task = Convert.ToInt32(Console.ReadLine());
if (task == 34)
{
    Console.Clear();
    Console.Write("Input size of array: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int min = 100;
    int max = 999;

    int[] array = CreateRandomArray(size, min, max);
    ShowArray(array);//↓↓↓↓↓↓↓↓↓↓
    Console.WriteLine("↓↓↓↓");//а как объединить в одну линию
    Console.Write(chet(array));//Оператор "+" невозможно применить к операнду типа "void" и "string"
}
if (task == 36)
{
    Console.Clear();
    int size = 4;
    int min = -100;
    int max = 100;

    int[] array = CreateRandomArray(size, min, max);
    ShowArray(array);
    Console.WriteLine("↓↓↓↓");
    Console.Write(SumNeChet(array));

}
if (task == 38)
{
    Console.Clear();
    int size = 5;
    int min = 100;
    int max = 999;
    int[] array =  CreateRandomArray(size, min, max);
    ShowArray(array);
    Console.WriteLine("↓↓↓↓");
    Console.Write(DiffMaxMin(array));

}
