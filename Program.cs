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
                    Console.WriteLine("\nВведите любую цифру, чтобы запустить программу для подсчёта количества символов x в строке (для выхода введите 0): ");
                    int N = Convert.ToInt32(Console.ReadLine());

                    if (N == 0) // если N = 0, то завершаем программу
                    {
                        Console.WriteLine("Программа завершена.\nДо свидания!");
                        break;
                    }
                    else // иначе
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
