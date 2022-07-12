int[] CreatArray(int size)
{
    int[] newArray = new int[size];

    
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1} элемент: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    } 
    Console.WriteLine();
    return newArray;
}

void Big(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++ )
    {
        if (array[i] > 0) count++;

    }
    Console.Write("чисел больше 0 -> " + count);
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ",");
    Console.WriteLine();
}

void InputCoefficients()
{
    double[,] coeff = new double[2, 2];
    double[] crossPoint = new double[2];
    for (int i = 0; i < coeff.GetLength(0); i++)
    {
        Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
        for (int j = 0; j < coeff.GetLength(1); j++)
        {
            if(j == 0) Console.Write("Введите коэффициент k: ");
            else Console.Write("Введите коэффициент b: ");
            coeff[i, j] = Convert.ToInt32(Console.ReadLine());
        }       
    }
    crossPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
    crossPoint[1] = crossPoint[0] * coeff[0,0] + coeff[0,1];
    Console.Write($"({crossPoint[0]}; {crossPoint[1]})");     
}



Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь");
Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
Console.Write("Введите цифру из приведенных заданий: ");

int task = Convert.ToInt32(Console.ReadLine());
if ( task == 41 )
{
    Console.Clear();
    Console.Write("Введите размер: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = CreatArray(size);
    ShowArray(array);
    Console.WriteLine("↓↓↓↓");
    Big(array);
}
if (task == 43)
{
    Console.Clear();
    InputCoefficients();    
}


