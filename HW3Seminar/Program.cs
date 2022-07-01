Console.WriteLine("Выберите цифру из данных задач:");
Console.WriteLine("Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.WriteLine("Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");// что то мистическое
Console.WriteLine("Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
int task = Convert.ToInt32(Console.ReadLine());
if ( task == 19 )
{
    Console.Clear();
    Console.WriteLine("Задача 19");
    Console.Write("Введите пятизначное число: ");
    string? number = Console.ReadLine();

    void CheckingNumber(string number)
    {
    if (number[0]==number[4] || number[1]==number[3])
    {
        Console.WriteLine("Ваше число: палиндром.");
    }
    else Console.WriteLine("Ваше число: не палиндром.");
    }

    if (number!.Length == 5)
    {
        CheckingNumber(number);
    }
    else Console.WriteLine("Введи правильное число");

}
if (task == 21)// эт вилами пошкрябал я и зашкварился _:(´ཀ`」 ∠):_	
{
    Console.Clear();
    Console.WriteLine("Задача 21");
    int x1 = Coordinate("x", "A");
    int y1 = Coordinate("y", "A");
    int z1 = Coordinate("z", "A");
    int x2 = Coordinate("x", "B");
    int y2 = Coordinate("y", "B");
    int z2 = Coordinate("z", "B");

    int Coordinate(string coorName, string pointName)
    {
        Console.Write($"Введите координату {coorName} точки {pointName}: ");
        return Convert.ToInt16(Console.ReadLine());
    }

    double Decision(double x1, double x2, 
                    double y1, double y2, 
                    double z1, double z2)
                    {
                        return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                                        Math.Pow((y2-y1), 2) + 
                                        Math.Pow((z2-z1), 2));
                    }

    double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

    Console.WriteLine($"Длина отрезка  {segmentLength}");

}
if (task == 23)
{
    Console.Clear();
    Console.WriteLine("Задача 23");
    Console.Write("Введите число: ");
    int cube = Convert.ToInt32(Console.ReadLine());

    void Cube(int[] cube)
    {
        int counter = 0;
        int length = cube.Length;
        while (counter <  length)
        {
            cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));//эт здесь куб проходит(1^3||2^3...)для этого и нужно Math.Pow
            counter++;
        }
    }

    void PrintArry(int[] coll)
    {
        int count = coll.Length;
        int index = 1;
        while(index < count)
        {
            Console.Write(coll[index]+ "; ");
            index++;
        }
    }    

    int[] arry = new int[cube+1];
    Cube(arry);
    PrintArry(arry);
}
