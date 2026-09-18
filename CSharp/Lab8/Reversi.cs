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
        /// <summary>
        /// Метод, проверяющий какие фишки нужно перевернуть в игре Реверси.
        /// </summary>
        /// <param name="numberLine"> Номер строки в матрице.</param>
        /// <param name="numberColumn"> Номер столбца в матрице.</param>
        /// <returns></returns>
        //public static Button[,] Reversion(int numberLine, int numberColumn, int currentStep, ref Button[,] _field) // Переворот фишек
        //{
        //    Color[] array = new Color[_field.GetLength(0)];
        //    for (int j = 0; j < _field.GetLength(1); j++) // Переписываем строку в массив для изменений
        //    {
        //        array[j] = _field[numberLine, j].BackColor;
        //    }
        //    for (int j = 0; j < _field.GetLength(1); j++) // По строке
        //    {
        //        if (currentStep % 2 == 0)
        //        {
        //            ChangeElementsTo(array[j], Color.Black, Color.White, array);
        //        }
        //        else
        //            ChangeElementsTo(array[j], Color.White, Color.Black, array);
        //    }
        //    for (int j = 0; j < _field.GetLength(1); j++) // Обратно
        //    {
        //        _field[numberLine, j].BackColor = array[j];
        //    }

        //    for (int i = 0; i < _field.GetLength(0); i++) // Переписываем столбец в массив для изменений
        //    {
        //        array[i] = _field[i, numberColumn].BackColor;
        //    }
        //    for (int i = 0; i < _field.GetLength(0); i++) // По столбцу
        //    {
        //        if (currentStep % 2 == 0)
        //        {
        //            ChangeElementsTo(array[i], Color.Black, Color.White, array);
        //        }
        //        else
        //            ChangeElementsTo(array[i], Color.White, Color.Black, array);
        //    }
        //    for (int i = 0; i < _field.GetLength(0); i++) //Обратно
        //    {
        //        _field[i, numberColumn].BackColor = array[i];
        //    }
        //    return _field;
        //}

    }
}