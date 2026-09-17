using System;
using System.Collections.Generic;
using System.Text;

namespace Varov.Lab7
{
    static class InputControl
    {
        static string Message = "Некорректный ввод";

        /// <summary>
        /// Метод ввода целого числа.
        /// </summary>
        /// <returns></returns>
        public static int InputInteger()
        {
            int result;
            Console.WriteLine("Введите целое число");
            while (!int.TryParse(Console.ReadLine(), out result))
            { Console.WriteLine(Message); }

            return result;
        }

        /// <summary>
        /// Метод ввода целого числа болше некоторого минимума.
        /// </summary>
        /// <param name="min"> Минимальное значение вводимого числа. 
        /// </param>
        /// <returns></returns>
        public static int InputInteger(int min)
        {
            int result;
            Console.WriteLine("Введите целое число более " + min);
            while (!int.TryParse(Console.ReadLine(), out result) || result < min)
            { Console.WriteLine(Message); }

            return result;
        }

        /// <summary>
        /// Метод ввода вещественого числа.
        /// </summary>
        /// <returns></returns>
        public static double InputDouble()
        {
            double result;
            Console.WriteLine("Введите число");
            while (!double.TryParse(Console.ReadLine(), out result))
            { Console.WriteLine(Message); }

            return result;
        }
    }
}
