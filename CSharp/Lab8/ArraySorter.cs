using System;
using System.Collections.Generic;
using System.Text;

namespace Varov.Lab8
{
    class ArraySorter
    {
        private int n;
        private int[] mas;

      public int Count
     { get { return n; } }
        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public ArraySorter()
        {
            n = 10;
            mas = new int[n];
        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="a"> Число элементов массива.
        /// </param>
        public ArraySorter(int a)
        {
            n = a;
            mas = new int[n];
        }

        /// <summary>
        /// Метод сравнения время двух видов сортировок.
        /// </summary>
     
        public void SpeedSort()
        {

            long time = DateTime.Now.Millisecond;
            GnomeSort();
            Console.WriteLine("Массив Гномьей сортировкой: ");
            OutputArray(GnomeSort());
            long gnometime = DateTime.Now.Millisecond - time;
            Console.WriteLine();

            long time1 = DateTime.Now.Millisecond;
            InsertionSort();
            Console.WriteLine("Массив сортировкой вставками");
            OutputArray(InsertionSort());
            long inserttime = DateTime.Now.Millisecond - time1;
            Console.WriteLine();
            if (gnometime > inserttime)
            {
                Console.WriteLine("Сортировка Вставками выполняется быстрее");
                Console.WriteLine();
            }
            else
    if (gnometime < inserttime)
            {
                Console.WriteLine("Гномья сортировка выполняется быстрее");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Сортировки выполняются одинаково быстро");
                Console.WriteLine();
                Console.ReadKey();
            }
        }
        public void InputArray(int min, int max)
        {

            Random rnd = new Random();
            for (int i = 0; i < mas.Length; i++)
            { mas[i] = rnd.Next(min, max); }
        }
        /// <summary>
        /// Метод ввода массива.
        /// </summary>

        public void InputArray()
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите " + (i + 1) + "й элемент массива:");
                mas[i] = InputControl.InputInteger();
            }
        }

        /// <summary>
        /// Метод сортировки Шелла.
        /// </summary>
        /// <returns> Массив отсортированных элементов. </returns>
        public int[] GnomeSort()
        {
            int[] mas1 = new int[mas.Length];
            int i, tmp;
            Array.Copy(mas, mas1, mas.Length);
            i = 0;
            while (i < n)
            {
                if (i == 0 || mas[i - 1] <= mas[i])
                    i++;
                else
                {
                    tmp = mas[i];
                    mas[i] = mas[i - 1];
                    mas[i - 1] = tmp;
                    i--;
                }
            }
            return mas1;
        }

        /// <summary>
        ///  Метод сортировки выбором.
        /// </summary>
        /// <returns> Массив отсортированных элементов. </returns>
        public int[] InsertionSort()
        {
            int[] mas1 = new int[mas.Length];
            Array.Copy(mas, mas1, mas.Length);
            for (int i = 1; i < n; i++)
            {
                int tmp = mas1[i];
                int step = i - 1;
                while (step >= 0 && mas1[step] > tmp)
                {
                    mas1[step + 1] = mas1[step];
                    step -= 1;
                }
                mas1[step + 1] = tmp;
            }
            return mas1;
        }
        /// <summary>
        /// Метод вывода элементов массива.
        /// </summary>
        /// <param name="mas"> Массив. </param>
        public int[] GetArray()
        {
            int[] res = new int[mas.Length];
            Array.Copy(mas, res, mas.Length);
            return res;
        }
        public static void OutputArray(int[] mas)
        {
            foreach (int i in mas)
            {
                Console.Write(" {0} ", i);
            }
            Console.WriteLine();
        }
    }
}
