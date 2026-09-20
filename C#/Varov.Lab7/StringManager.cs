using System;
using System.Collections.Generic;
using System.Text;

namespace Varov.Lab7
{
    class StringManager
    {
        private const string text = "Варкалось.Хливкие шорьки " + "\nПырялись по наве," + "\nИ хрюкотали зелюки," + "\nКак мюмзики в мове." + "\nО бойся Бармаглота, сын!" + "\nОн так свиреп и дик," + "\nА в глуще рымитисполин - " + "\nЗлопастный Брандашмыг.";

        private string str;

        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public StringManager()
        {
            str = text;
        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="s"> Пользовательская строка. </param>

        public StringManager(string s) //: this()
        {
            str = s;

        }
        /// <summary>
        /// Метод работы со своей строкой, вывод её на экран и подсчёт количества символов в ней.
        /// </summary>
        public void User()
        {
            Console.WriteLine();
            Console.WriteLine("Количество букв А(а) " + new StringManager().Count(str));
            Console.WriteLine();
        }


        /// <summary>
        /// Метод работы с данной строкой,вывод её на экран и подсчёт количества символов в ней.
        /// </summary>
        public void Out()
        {
            Console.WriteLine(str);
            Console.WriteLine();
            Console.WriteLine("Количество букв А(а)" + new StringManager().Count(str));
            Console.WriteLine();
        }
        /// <summary>
        /// Метод, считающий количество символов в строке.
        /// </summary>
        /// <param name="str"> Строка. </param>
        /// <returns> Количество символов. </returns>
        private int Count(string text)
        {
            int count = 0;
            foreach (char i in text)
            {
                if ((i == 'а') || (i == 'А'))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
