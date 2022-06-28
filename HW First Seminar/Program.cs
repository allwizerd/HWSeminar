Console.WriteLine("Выберите цифру из данных заданий:");
Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
Console.WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)");
Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
int task = Convert.ToInt32(Console.ReadLine());
if ( task == 2 )
{
    // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
    Console.Write("input a first number: ");
    int n1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a second number: ");
    int n2 = Convert.ToInt32(Console.ReadLine());
    if (n1 > n2)
    {
        Console.WriteLine("max = " + n1);
    }
    else 
    {
        Console.WriteLine("max = " + n2);
    }    
}

if ( task == 4 )
{
    //Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
    Console.Write("Введите первое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третье число: ");
    int num3 = Convert.ToInt32(Console.ReadLine());
    int max = num1;
    if (num2 > max)
    {
        max = num2;
    }
    if (num3 > max) 
    {
        max = num3;
    }
    Console.WriteLine(max);
}

if ( task == 6 )
{
    //Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num % 2 == 0)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}

if ( task == 8 )
{
    //Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
    Console.WriteLine("Введите число");
    int N = Convert.ToInt32(Console.ReadLine());
    int num = 1;
    while (num < N)
    {
    if (num % 2 == 0)
    {
        Console.Write(num + " ");
    }
    num = num + 1;
    }
}
