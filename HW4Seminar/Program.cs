int Up(int a, int b)
{    
    int enter = 1;
    for (int i = 1; i <= b; i++)
    {
        enter = enter * a; 
    }
    return enter;
}
//int SumChisel(int Chislo)
int[] massiv(int m)
{
    int size = m;
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(0, 100);

    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}





Console.WriteLine("Выберите цифру из данных заданий:");
Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");
int task = Convert.ToInt32(Console.ReadLine());
if (task == 25)
{
    Console.Clear();
    Console.Write("Введите число a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число b: ");
    int b = Convert.ToInt32(Console.ReadLine());

    Console.Write($"A {a} ^ B {b} = " + Up(a, b));
}
if (task == 27)
{
    Console.Write("Введите число: ");
    int c = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" Да чтоб его (￢_￢)	");
    //Console.Clear;
    //Console.Write("Введите число: ");
    //int chislo = Convert.ToInt32(Console.ReadLine());

    
}
if (task == 29) // а как с интом??
{
    Console.Clear();
    Console.Write("Введите size masiv: ");
    int m = Convert.ToInt32(Console.ReadLine());
    int[] array = massiv(m);
    ShowArray(array);


    

    
}