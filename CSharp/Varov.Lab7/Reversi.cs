using System;
using System.Collections.Generic;
using System.Text;

namespace Varov.Lab7
{
    class Reversi
    {
        private string[,] array;
        private const int size = 9;
        
        
        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public Reversi()
        {
            array = new string[size, size];
        }
        
        /// <summary>
        /// Метод заполнения игрового поля.
        /// </summary>
        private void InputMatr()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    string[] StCol = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
                    array[i, 0] = StCol[i];
                    array[0, j] = StCol[j];
                    array[0, 0] = " ";
                    array[i, j] = " ";
                }
            }
            array[4, 4] = "1";
            array[5, 5] = "1";
            array[4, 5] = "0";
            array[5, 4] = "0";
        }
        
        /// <summary>
        /// Метод вывода игрового поля.
        /// </summary>
        private void OutputMatr()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Проверка конца игры
        /// <returns> Конец/не конец. </returns> 
        private bool GameOver(string arg)
        {
            int res = 0;
            for (int i = 1; i < size; i++)
            {
                for (int j = 1; j < size; j++)
                {
                    if (array[i, j] == arg)
                    {
                        res += 1;
                    }
                }
            }
            if (res == 0)
                return false;
            else
                return true;
        }
        /// <summary>
        /// Проверка на возможность хода вправо
        /// <returns> Номер позиции, до которой нужно заполнить поле фишками ходящего игрока. </returns> 
        private int CheckRight(string arg, int Str, int Col)
        {
            int result = 0;
            if (Col >= (size - 1))
                return result;
            else
            {
                if ((array[Str, Col + 1] == "1") || (array[Str, Col + 1] == "0"))
                {
                    int i = size - 1;
                    if (array[Str, i] == arg)
                        return i;
                    while (i > Col && array[Str, i] != arg)
                    {
                        i--;
                        result = i;
                    }
                }
                else
                    return result;
            }
            return result;
        }
        /// <summary>
        /// Метод, заполняющий нужные позиции на поле фишками игрока.
        /// </summary>
        private void FillRight(string arg, int Str, int Col)
        {
            int i = Col;
            while (i != CheckRight(arg, Str, Col))
            {
                if (array[Str, i] != " ")
                    array[Str, i] = arg;
                i++;
            }
        }
        /// <summary>
        /// Проверка на возможность хода вправо
        /// <returns> Номер позиции, до которой нужно заполнить поле фишками ходящего игрока. </returns> 
        private int CheckDown(string arg, int Str, int Col)
        {
            int result = 0;
            if (Str >= (size - 1))
                return result;
            else
            {
                if ((array[Str + 1, Col] == "1") || (array[Str + 1, Col] == "0"))
                {
                    int i = size + 1;
                    if (array[i, Col] == arg)
                        return i;
                    while (i > Str && array[i, Col] != arg)
                    {
                        i--;
                        result = i;
                    }
                }
                else
                    return result;
            }
            return result;
        }
        /// <summary>
        /// Метод, заполняющий нужные позиции на поле фишками игрока.
        /// </summary>
        private void FillDown(string arg, int Str, int Col)
        {
            int i = Str;
            while (i != CheckDown(arg, Str, Col))
            {
                if (array[i, Col] != " ")
                    array[i, Col] = arg;
                i++;
            }
        }
        /// <summary>
        /// Проверка на возможность хода вправо
        /// <returns> Номер позиции, до которой нужно заполнить поле фишками ходящего игрока. </returns> 
        private int CheckLeft(string arg, int Str, int Col)
        {
            int result = 0;
            if (Col <= 1)
                return result;
            else
            {
                if ((array[Str, Col - 1] == "1") || (array[Str, Col - 1] == "0"))
                {
                    int i = 1;
                    if (array[Str, i] == arg)
                        return i;
                    while (i < Col && array[Str, i] != arg)
                    {
                        i++;
                        result = i;
                    }
                }
                else
                    return result;
            }
            return result;
        }
        /// <summary>
        /// Метод, заполняющий нужные позиции на поле фишками игрока.
        /// </summary>
        private void FillLeft(string arg, int Str, int Col)
        {
            int i = Col;
            while (i != CheckLeft(arg, Str, Col))
            {
                if (array[Str, i] != " ")
                    array[Str, i] = arg;
                i--;
            }
        }
        /// <summary>
        /// Проверка на возможность хода вправо
        /// <returns> Номер позиции, до которой нужно заполнить поле фишками ходящего игрока. </returns> 
        private int CheckUp(string arg, int Str, int Col)
        {
            int result = 0;
            if (Str <= 1)
                return result;
            else
            {
                if ((array[Str - 1, Col] == "1") || (array[Str - 1, Col] == "0"))
                {
                    int i = 1;
                    if (array[i, Col] == arg)
                        return i;
                    while (i < Str && array[i, Col] != arg)
                    {
                        i++;
                        result = i;
                    }
                }
                else
                    return result;
            }
            return result;
        }
        /// <summary>
        /// Метод, заполняющий нужные позиции на поле фишками игрока.
        /// </summary>
        private void FillUp(string arg, int Str, int Col)
        {
            int i = Str;
            while (i != CheckUp(arg, Str, Col))
            {
                if (array[i, Col] != " ")
                    array[i, Col] = arg;
                i--;
            }
        }
        /// <summary>
        /// Метод, подсчитывающий кол-во фишек каждого игрока.
        /// <returns> Кол-во фишек каждого игрока. </returns> 
        private uint PointNumber(string arg)
        {
            uint count = 0;
            for (int i = 1; i < size; i++)
            {
                for (int j = 1; j < size; j++)
                {
                    if (array[i, j] == arg)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
         
        /// <summary>
         /// Метод, определяющий победителя.
         /// </summary>
        private void Winner()
        {
            switch (PointNumber("1") > PointNumber("0"))
            {
                case (true):
                    Console.WriteLine($"Черные [1] победили со счетом {PointNumber("1")} : {PointNumber("0")}");
                    break;
                case (false):
                    if (PointNumber("1") == PointNumber("0"))
                        Console.WriteLine($"Ничья! {PointNumber("0")} : {PointNumber("1")}");
                    else
                        Console.WriteLine($"Белые [0] победили со счетом {PointNumber("0")} : {PointNumber("1")}");
                    break;
                default:
            }
        }
        
        /// <summary>
        /// Метод, запускающий игру.
        /// </summary>
        public void Game()
        {
            InputMatr();
            int Col;
            int Str;
            bool next = true;
            bool move = true;
            string arg = "1";
            while (next)
            {
                bool mistake = true;
                Console.Clear();
                OutputMatr();
                if (move)
                    Console.WriteLine("Ход черного игрока [1]");
                else
                    Console.WriteLine("Ход белого игрока [0]");
                Console.Write("Введите номер строки: ");
                while (!int.TryParse(Console.ReadLine(), out Str) || (Str > (size - 1) || Str < 1))
                {
                    Console.Write("Введите другой номер: ");
                }
                Console.Write("Введите номер столбца: ");
                while (!int.TryParse(Console.ReadLine(), out Col) || (Col > (size - 1) || Col < 1))
                {
                    Console.Write("Введите другой номер: ");
                }
                while (mistake)
                {
                    if (array[Str, Col] != " " || (CheckRight(arg, Str, Col) == 0 && CheckDown(arg, Str, Col) == 0 && CheckLeft(arg, Str, Col) == 0 && CheckUp(arg, Str, Col) == 0)) //|| CheckRight(array, arg, Str, Col) == Col || CheckDown(array, arg, Str, Col) == Str || CheckLeft(array, arg, Str, Col) == Col || CheckUp(array, arg, Str, Col) == Str)
                    {

                        mistake = false;
                    }
                    else
                    {
                        if (GameOver(" "))
                        {
                            Console.Clear();
                            OutputMatr();
                            // Ход черного [1]
                            if (move)
                            {
                                if (GameOver("1") == false)
                                {
                                    next = false;
                                }
                                else
                                {
                                    array[Str, Col] = "1";
                                    if (CheckRight("1", Str, Col) > 0)
                                        FillRight("1", Str, Col);
                                    if (CheckDown("1", Str, Col) > 0)
                                        FillDown("1", Str, Col);
                                    if (CheckLeft("1", Str, Col) > 0)
                                        FillLeft("1", Str, Col);
                                    if (CheckUp("1", Str, Col) > 0)
                                        FillUp("1", Str, Col);
                                }
                                move = false;
                                arg = "0";
                            }
                            // Ход белого [0] 
                            else
                            {
                                if (GameOver("0") == false)
                                {
                                    next = false;
                                }
                                else
                                    array[Str, Col] = "0";
                                if (CheckRight("0", Str, Col) > 0)
                                    FillRight("0", Str, Col);
                                if (CheckDown("0", Str, Col) > 0)
                                    FillDown("0", Str, Col);

                                if (CheckLeft("0", Str, Col) > 0)
                                    FillLeft("0", Str, Col);
                                if (CheckUp("0", Str, Col) > 0)
                                    FillUp("0", Str, Col);
                                move = true;
                                arg = "1";
                            }
                        }
                        else
                        {
                            next = false;
                        }

                    }
                }
            }
            Winner();
            Console.ReadLine();
        }
                  
    }
}
