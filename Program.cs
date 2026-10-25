using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Приглашение и ввод текста
        Console.Write("Введите текст: ");
        string tekst = Console.ReadLine();

        // Шаблон регулярного выражения для поиска целых чисел.
        Regex regularka = new Regex(@"[-+]?\d+");

        // Ищем все совпадения шаблона в тексте
        MatchCollection chisla = regularka.Matches(tekst);

        // Проверяем, были ли вообще найдены числа
        if (chisla.Count == 0)
        {
            Console.WriteLine("Числа в тексте не найдены.");
            return;
        }

        // Первоначально максимальным считаем первое найденное число
        int maxChislo = int.Parse(chisla[0].Value);

        // Перебираем все найденные числа и ищем максимум
        foreach (Match element in chisla)
        {
            int tekushcheeChislo = int.Parse(element.Value);

            if (tekushcheeChislo > maxChislo)
            {
                maxChislo = tekushcheeChislo;
            }
        }

        Console.WriteLine("Максимальное целое число: " + maxChislo);
 Console.Write("Проверка изменения файла ");

    }
}

