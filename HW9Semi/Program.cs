int count(int n)
{
    if (n / 10 != 0)
        return 1 + count(n / 10);
    else
        return 1;
}


Console.WriteLine("Задача 64: Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.");
Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");

Console.Write("Введите цифру из приведенных заданий: ");

int task = Convert.ToInt32(Console.ReadLine());
if (task == 64)
{
    Console.Write("Введите число(да ПОДЛиииНЕЕ): ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write(count(n));
}
if (task == 66)
{
    Console.Write("ОТ: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("ДО: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int temp = m;

    if (m > n)
    {
        m = n;
        n = temp;
    }

    MsumN(m, n, temp = 0);

    void MsumN(int m, int n, int summ)
    {
        summ = summ + n;
        if (n <= m)
        {
            Console.Write($"Сумма элементов= {summ} ");
            return;
        }
        MsumN(m, n - 1, summ);
    }
}