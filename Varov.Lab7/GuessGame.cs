using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varov.Lab7
{
    static class GuessGame
    {
        private static int total_x = 3;

        /// <summary>
        /// Метод угадывания значения функции.
        /// </summary>
        public static void Guess()
        {
            double a, b;
            int result;
            int x = total_x;

            GetNums(out a, out b);

            result = GetResult(a, b);

            Console.WriteLine("У вас есть " + x.ToString() + " попытки, чтобы угадать ответ");
            while (x > 0 && !IsAnswerRight(result))
            {
                x--;
                Console.WriteLine("Неверно");
                if (x > 0)
                    Console.WriteLine("У вас осталось " + x.ToString() + " попытки");
            }
            if (x > 0)
            { Console.WriteLine("Верно"); }

            Console.WriteLine("Правильный ответ: " + result);
        }

        /// <summary>
        /// Метод ввода аргуметов функции.
        /// </summary>
        /// <param name="a"> Первый аргумент функции. </param>
        /// <param name="b"> Второй аргумент функции. </param>
        static void GetNums(out double a, out double b)
        {
           

            bool m;
            do
            {
                Console.WriteLine("Введите a:");
                a = InputControl.InputDouble();
                Console.WriteLine("Введите b:");
                b = InputControl.InputDouble();

                if (Math.Cos(2 * a) <= 0)
                {
                    m = false;
                    Console.WriteLine("Значение под корнем отрицательное или равно нулю");
                    Console.WriteLine();
                }
                else
                {
                    
                    if (b <= 0)
                    {
                        m = false;
                        Console.WriteLine("Значение под логарифмом отрицательное или равно нулю!");
                        Console.WriteLine();
                    }

                    else
                    { m = true; }
                   
                    }
            } while (!m);
        }

        /// <summary>
        /// Метод сравнения ответа пользователя и правильного.
        /// </summary>
        /// <param name="result1"> Ответ пользователя. </param>
        /// <returns> Правильно/неправильно. </returns>
        static bool IsAnswerRight(int result)
        {
            int result1;

            Console.WriteLine("Введите ваш вариант ответа:");
            result1 = InputControl.InputInteger();

            if (result1 == result)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Метод, вычисляющий значение функции.
        /// </summary>
        /// <param name="a"> Первый аргумент функции. </param>
        /// <param name="b"> Второй аргумент функции. </param>
        /// <returns> Результат. </returns>
        static int GetResult(double a, double b)
        {
            int result = (int)Math.Round(Math.Pow(Math.Sin(Math.Log(b, 5) / Math.Sqrt(Math.Cos(2 * a))), 2), MidpointRounding.AwayFromZero);
            return result;
        }
    }

}
