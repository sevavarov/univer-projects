using System;
using System.Drawing;

namespace Varov.Lab8
{
    class Reversi
    {
        /// <summary>
        /// Метод, проверяющий победителя в игре.
        /// </summary>

        public static string CheckWinner()
        {
            Reversi1 obj = new Reversi1();
            int white = 0, black = 0;
            for (int i = 0; i < obj._contr.GetLength(0); i++)
            {
                for (int j = 0; j < obj._contr.GetLength(1); j++)
                {
                    if (String.Equals(obj._contr[i, j], "0"))
                        white++;
                    else if (String.Equals(obj._contr[i, j], "1"))
                        black++;
                }
            }
            if (white > black)
                return ("Белых:" + white + "\nЧёрных: " + black + "\nПобедили белые!");
            else if (white < black)
                return ("Белых:" + white + "\nЧёрных: " + black + "\nПобедили чёрные!");
            else return ("Белых:" + white + "\nЧёрных: " + black + "\nНичья!");
        }
        /// <summary>
        /// Метод, меняющий элементы в игре Реверси.
        /// </summary>
        /// <param name="whatChange"> Какой элемент меняется. </param>
        /// <param name="whatIsChange"> На что меняется элемент. </param>
        /// <param name="b"> Элемент, противоположный предыдущей переменной.</param>
        /// <param name="array"> Массив строк.</param>
        public static void ChangeElementsTo(Color whatChange, Color whatIsChange, Color b, Color[] array)
        {
            int firstIndexOf, lastIndexOf;
            bool check = true;
            if ((Array.IndexOf(array, whatIsChange) != -1) && (Array.LastIndexOf(array, whatIsChange) != -1))
            {
                firstIndexOf = Array.IndexOf(array, whatIsChange);
                lastIndexOf = Array.LastIndexOf(array, whatIsChange);
                if ((array[firstIndexOf].Equals(whatIsChange)) && (firstIndexOf != lastIndexOf))
                {
                    for (int r = firstIndexOf + 1; (firstIndexOf < r) && (r < lastIndexOf); r++)
                    {
                        if (array[r] == Color.Pink)
                        {
                            check = false;
                        }
                    }

                    if (check == true)
                        for (int r = firstIndexOf + 1; (firstIndexOf < r) && (r < lastIndexOf); r++)
                        {
                            if (array[r] == b)
                            {
                                array[r] = whatIsChange;
                                whatChange = whatIsChange;
                            }
                        }
                }
            }
        }
       
    }
}