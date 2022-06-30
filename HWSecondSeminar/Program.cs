int SecondNumber()
{    
    Console.Clear();
    Console.WriteLine("Задача 10 ");
    Console.Write("Введи трёхзначное число: ");
    int TDN = Convert.ToInt32(Console.ReadLine());
    int SDN = TDN / 10;
    int SN = SDN % 10;
    
    return SN;
}
void ThereNumber()
{
    Console.Clear();
    Console.WriteLine("Задача 13 ");
    Console.Write("Введи число: ");
    int anyNumber = Convert.ToInt32(Console.ReadLine());
    string anyNumberText = Convert.ToString(anyNumber);
    if (anyNumberText.Length > 2)
    {
        Console.WriteLine("третья цифра: " + anyNumberText[2]);
    }
    else 
    {
        Console.WriteLine("третьей цифры нет");
    }
}
void Weekend()
{
    Console.Clear();
    Console.WriteLine("Задача 15 ");
    Console.Write("Введи цифру, обозначающую день недели: ");
    int DN = Convert.ToInt32(Console.ReadLine());

    void CTDOTW (int dayNumber) 
    {
        if (dayNumber == 6 || dayNumber == 7) 
    {
        Console.WriteLine("этот день выходной");
    }
    else if (dayNumber < 1 || dayNumber > 7) 
    {
        Console.WriteLine("это вообще не день недели");
    }
    else Console.WriteLine("этот день не выходной");
    }

    CTDOTW(DN);
}
Console.WriteLine("Выберите цифру из данных заданий:");
Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
int task = Convert.ToInt32(Console.ReadLine());
if ( task == 10 )
{
    
    Console.WriteLine(SecondNumber());
}
if (task == 13)
{
    ThereNumber();
}
if (task == 15)
{
    Weekend();
}