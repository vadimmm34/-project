using System;

class Class2
{
    static void Main2()
    {
        Console.Write("Введите трехзначное число: ");
        int a = int.Parse(Console.ReadLine());

        int b = (a / 10) % 10;
        int c = a % 10;

        string result = (b > c) ? "Вторая цифра больше последней" :
                        (c > b) ? "Последняя цифра больше второй" :
                        "Цифры равны";

        Console.WriteLine(result);
        Console.ReadKey();
    }
}