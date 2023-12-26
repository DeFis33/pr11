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
                    Console.WriteLine("\nХотите ли бы вы запустить программу для подсчёта количества символов x в строке? (Да/Нет)");
                    string a = Console.ReadLine();

                    if (a == "Нет") // если a = "нет", то завершаем программу
                    {
                        Console.WriteLine("Программа завершена.\nДо свидания!");
                        break;
                    }
                    else if (a == "Да") // иначе, если
                    {
                        Console.Write("\nВведите строку: ");
                        string S = Console.ReadLine();
                        Console.Write("\nВведите символ для подсчета: ");
                        char symbol = char.Parse(Console.ReadLine());
                        int i = 0;

                        foreach (char c in S) // выполнение операторов для каждого элемента в экземпляре типа
                        {
                            if (c == symbol) // если c равен symbol, то
                            {
                                i++;
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\nКоличество символов '{symbol}' в строке: {i}");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else // иначе
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Введите Да или Нет! Либо Выход. (Ввод ответа требуется с большой буквы)");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                }
                catch (FormatException e) // частное исключение
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nОшибка ввода \n" + e.Message); // вывод ошибки на экран
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (Exception e) // общее исключение
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nОшибка ввода \n" + e.Message); // вывод ошибки на экран
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
