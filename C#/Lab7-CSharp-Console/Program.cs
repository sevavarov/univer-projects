using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Varov.Lab7;

namespace Varov.Lab7
{
    
    
    
        class Program
        {
            /// <summary>
            /// Метод - точка входа программы.
            /// </summary>
            /// <param name="args"> Параметры запуска программы. </param>
            static void Main(string[] args)

            {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
                bool Going = true;
                do
                {
                    Console.WriteLine(" 1 - Отгадайте ответ: ");
                    Console.WriteLine(" 2 - Об авторе(Фамилия И.О.,группа ): ");
                    Console.WriteLine(" 3 - Сортировка: ");
                    Console.WriteLine(" 4 - Игра: ");
                    Console.WriteLine(" 5 - Работа со строками: ");
                    Console.WriteLine(" 6 - Выход : ");
                    Console.WriteLine(" Введите порядковый номер: ");
                    int number = InputControl.InputInteger();
                    switch (number)
                    {
                        case 1:
                            GuessGame.Guess();
                            break;
                        case 2:
                            ShowAuthorInfo();
                            break;
                        case 3:
                            SortAction();
                            break;
                        case 4:
                        new Reversi().Game(); 
                            break;
                        case 5:
                            Menu();
                            break;
                        case 6:
                            Going = Stay();
                            break;
                        default:
                            Console.WriteLine("Нет такого варианта");
                            break;
                    }
                } while (Going);
            }

            /// <summary>
            /// Метод работы со строками по заданию.
            /// </summary>
            static void Menu()
            {
                Console.WriteLine("1 - Работа со своей строкой ");
                Console.WriteLine("2 - Работа с данной строкой ");
                Console.WriteLine();
                Console.WriteLine(" Введите порядковый номер: ");
                int num = InputControl.InputInteger();
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Введите свою строку");
                        string s = Console.ReadLine();
                        new StringManager(s).User();
                        break;
                    case 2:
                        new StringManager().Out();
                        break;
                    default:
                        Console.WriteLine(" Вы ввели неправильный номер ");
                        break;
                }
            }

            /// <summary>
            /// Метод работы с классом сортировки по заданию.
            /// </summary>
            static void SortAction()
            {
                ArraySorter arraySorter;
                Console.WriteLine("Сортировка элементов с заданным колвом элементов");
                Console.WriteLine("Введите размер массива:");
                arraySorter = new ArraySorter(InputControl.InputInteger(1));
                arraySorter.InputArray();
                arraySorter.SpeedSort();
                Console.WriteLine('\n' + "Сортировка массива с кол-вом элементов по умолчанию");
                arraySorter = new ArraySorter();
                arraySorter.InputArray();
                arraySorter.SpeedSort();
            }

            /// <summary>
            /// Метод вывода информации об авторе.
            /// </summary>
            static void ShowAuthorInfo()
            { Console.WriteLine("Варов Всеволод Андреевич 6102"); }

            /// <summary>
            /// Метод выхода.
            /// </summary>
            /// <returns> Выйти/остаться. </returns>
            static bool Stay()
            {
                Console.WriteLine("Выйти?" + '\n' +
                    "д-да н-нет");

                switch (Console.ReadKey(true).KeyChar)
                {
                    case 'д':
                        Console.WriteLine("До свидания!");
                        return false;
                    case 'н':
                        Console.WriteLine("Остаёмся");
                        return true;
                    default:
                        Console.WriteLine("Введите другой вариант");
                        return true;
                }
            }
        }
    } 

