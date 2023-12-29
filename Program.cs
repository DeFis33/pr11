//***************************************************************
//* Практическая работа № 11                                    *
//* Выполнил: Пирогов Д., группа 2ИСП                           *
//* Задание: разработать программу алгоритма решения задачи     *
//***************************************************************

using System;

namespace pr11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Здравствуйте!\nПрактическая работа №11");

            while (true)
            {
                try
                {
                    Console.WriteLine("\nХотите ли вы запустить программу для подсчёта количества символов x в строке? (Да/Нет)");
                    string a = Console.ReadLine();

                    if (a == "Нет")
                    {
                        Console.WriteLine("Программа завершена.\nДо свидания!");
                        break;
                    }
                    else if (a == "Да") 
                    {
                        Console.Write("\nВведите строку: ");
                        string S = Console.ReadLine();
                        Console.Write("\nВведите символ для подсчета: ");
                        char symbol = char.Parse(Console.ReadLine());
                        int i = 0;

                        S = S.ToLower();
                        symbol = char.ToLower(symbol);

                        foreach (char c in S)
                        {
                            if (c == symbol)
                            {
                                i++;
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\nКоличество символов '{symbol}' в строке: {i}");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Введите Да или Нет! Либо Выход. (Ввод ответа требуется с большой буквы)");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                }
                catch (FormatException fe)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nОшибка ввода \n" + fe.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nОшибка ввода \n" + e.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
// Александр Пушкин начал писать свои первые произведения уже в семь лет.
