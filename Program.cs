using System;
using System.ComponentModel.Design;
bool rabotaet;
rabotaet = true;
Console.WriteLine("Выберите операцию:");
Console.WriteLine("1. Сложение");
Console.WriteLine("2. Вычитание");
Console.WriteLine("3. Умножение");
Console.WriteLine("4. Деление");
Console.WriteLine("5. Степень");
Console.WriteLine("6. Квадратный корень");
Console.WriteLine("7. 1 % числа");
Console.WriteLine("8. Факториал");
Console.WriteLine("9. Выход");
do
{
    while (rabotaet == true)
    {
        int deistvie = Convert.ToInt32(Console.ReadLine());
        if (deistvie == 1)
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int summa = a + b;
            Console.WriteLine(a + "+" + b + "=" + summa);
        }
        if (deistvie == 2)
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int raznost = a - b;
            Console.WriteLine(a + "-" + b + "=" + raznost);
        }
        if (deistvie == 3)
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int proizvedenie = a * b;
            Console.WriteLine(a + "*" + b + "=" + proizvedenie);
        }
        if (deistvie == 4)
        {
            Console.Write("Введите первое число: ");
            float a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            float b = Convert.ToInt32(Console.ReadLine());
            if (b > 0)
            {
                float chastnoe = a / b;
                Console.WriteLine(a + ":" + b + "=" + chastnoe);
            }
            else if (b == 0)
            {
                Console.WriteLine("на 0 делят, но не в этом калькуляторе");
            }
        }
        if (deistvie == 5)
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите степень: ");
            int b = Convert.ToInt32(Console.ReadLine());
            double stepen = Math.Pow(a, b);
            Console.WriteLine(a + " в степени " + b + " = " + stepen);
        }
        if (deistvie == 6)
        {
            Console.Write("Введите квадратный корень: ");
            int a = Convert.ToInt32(Console.ReadLine());
            double koren = Math.Sqrt(a);
            Console.WriteLine(" Квадратный корень " + a + " = " + koren);
        }
        if (deistvie == 7)
        {
            Console.Write("Введите число: ");
            double a = (float)Convert.ToDouble(Console.ReadLine());
            double procent = a / 100;
            Console.WriteLine("1 % = " + procent);
        }
        if (deistvie == 8)
        {
            Console.Write("Введите число для высчета факториала: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 2; i <= a; i++)
            {
                factorial *= i;
                if (i == a)
                {
                    Console.WriteLine("Факториал числа " + a + " = " + factorial);
                }
            }
        }
        if (deistvie == 9)
        {
            break;
        }
    }
}
while (rabotaet == false);
