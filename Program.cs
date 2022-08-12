// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Задача 19");
        Console.Write("Введите пятизначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 9999 && number < 100000)
        {
            int digitOne = number % 10;
            int digitTen = number / 10 % 10;
            int digitThousand = number / 1000 % 10;
            int digitTenThousand = number / 10000 % 10;
            if (digitOne == digitTenThousand && digitTen == digitThousand)
            {
                Console.WriteLine("Число палиндром");
            }
            else
            {
                Console.WriteLine("Число НЕ палиндром");
            }
        }
        else
        {
            {
                Console.WriteLine("Введено неверное число");
            }
          
        }
    }
}

______________________________


{// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Задача 21");
int x1 = 1;
int y1 = 1;
int z1 = 1;
int x2 = 0;
int y2 = 0;
int z2 = 0;
double distanse = Math.Sqrt( Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
Console.WriteLine(distanse);
}

_______________________________


//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

{
    Console.WriteLine("Задача 23");
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine($"{i} * {i} * {i} = {Math.Pow(i, 3)}");
    }
}
