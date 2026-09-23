using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Varov.Lab8
{
    public partial class Form1 : Form
    {
        private StringManager stringManager;
        const string text = "Варкалось.Хливкие шорьки " + "\nПырялись по наве," + "\nИ хрюкотали зелюки," + "\nКак мюмзики в мове." + "\nО бойся Бармаглота, сын!" + "\nОн так свиреп и дик," + "\nА в глуще рымитисполин - " + "\nЗлопастный Брандашмыг.";
        private ArraySorter arraySorter;
        //поля для работы угадайки, тк GuessGame - статик класс, те не хранит состояние
        private int param_a, param_b, result1, result, x;
        private bool isGuessing;
        const int size = 9;

        public Form1()
        {
            InitializeComponent();
            stringManager = new StringManager();
            arraySorter = new ArraySorter();
            isGuessing = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Reversi1 g = new Reversi1();
            g.Visible = true;

        }

    

        private void sort_button_Click_1(object sender, EventArgs e)
        {
            TimeSpan gnometime, inserttime;
            Stopwatch stopwatch = new Stopwatch();
            int size;
            int[] source, gnomeSort, insertionSort;
            if (int.TryParse(size_textBox.Text, out size) && size > 0)
            {
                if (arraySorter.Count != size)
                    arraySorter = new ArraySorter(size);
                arraySorter.InputArray(-10, 10);
                source_mas_dataGridView.RowCount = 1;
                GnomeSort_dataGridView.RowCount = 1;
                InsertionSort_dataGridView.RowCount = 1;
                source_mas_dataGridView.ColumnCount = size;
                GnomeSort_dataGridView.ColumnCount = size;
                InsertionSort_dataGridView.ColumnCount = size;

                source = arraySorter.GetArray();
                stopwatch.Start();
                gnomeSort = arraySorter.GnomeSort();
                stopwatch.Stop();
                gnometime = stopwatch.Elapsed;
                stopwatch.Restart();
                insertionSort = arraySorter.InsertionSort();
                stopwatch.Stop();
                inserttime = stopwatch.Elapsed;
                for (int i = 0; i < size; i++)
                {
                    source_mas_dataGridView.Columns[i].Width = source_mas_dataGridView.Width / size;
                    source_mas_dataGridView.Rows[0].Cells[i].Value = source[i].ToString();

                    GnomeSort_dataGridView.Columns[i].Width = GnomeSort_dataGridView.Width / size;
                    GnomeSort_dataGridView.Rows[0].Cells[i].Value = gnomeSort[i].ToString();

                    InsertionSort_dataGridView.Columns[i].Width = InsertionSort_dataGridView.Width / size;
                    InsertionSort_dataGridView.Rows[0].Cells[i].Value = insertionSort[i].ToString();
                }
                source_mas_dataGridView.ClearSelection();
                GnomeSort_dataGridView.ClearSelection();
                InsertionSort_dataGridView.ClearSelection();

                if (gnometime > inserttime)
                { MessageBox.Show("Сортировка Вставками выполняется быстрее"); }
                if (gnometime < inserttime)
                { MessageBox.Show("Гномья сортировка выполняется быстрее"); }
                if (gnometime == inserttime)
                { MessageBox.Show("Сортировки выполняются одинаково быстро"); }
            }
            else
                MessageBox.Show("Некорекктно указано количество элементов");
        }

        private void clear_button_Click_1(object sender, EventArgs e)
        {
            if (!isGuessing)
            {
                param_a_textBox.Text = string.Empty;
                param_b_textBox.Text = string.Empty;
                result1_textBox.Text = string.Empty;
                result_answer.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Нельзя очистить поля во время угадывания");
            }
        }


        private void input_button_Click(object sender, EventArgs e)
        {
            if (!isGuessing)
            {
                if (CanStartGuessing())
                    StartGuessing();
            }
            else
            {
                if (int.TryParse(result1_textBox.Text, out result1))
                {
                    x--;
                    if (result1 == result)
                    {
                        MessageBox.Show("Правильный ответ");
                        CancelGuessing();
                    }
                    else
                    {
                        MessageBox.Show("Неправильный ответ" + '\n' +
                            "осталось " + x + " попыток");
                    }
                    if (x < 1)
                        CancelGuessing();
                }
                else
                {
                    MessageBox.Show("Некорекктный вариант ответа");
                }
            }
        }
        private bool CanStartGuessing()
        {
            if (int.TryParse(param_a_textBox.Text, out param_a) && int.TryParse(param_b_textBox.Text, out param_b))
            {
                if (GuessGame.ParamsAllowed(param_a, param_b))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Параметры не входят в ОДЗ");
                }
            }
            else
            {
                MessageBox.Show("Параметры введены некорекктно");
            }
            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void param_a_label_Click(object sender, EventArgs e)
        {

        }

        private void param_b_label_Click(object sender, EventArgs e)
        {

        }

        private void param_a_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void param_b_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void result_answer_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void clear_button1_Click(object sender, EventArgs e)
        {
            strBox.Clear();
        }

        private void strBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void count_Click(object sender, EventArgs e)
        {
            if (strBox.Text != "")
            {
                StringManager s = new StringManager();
                string str = strBox.Text;//получить текст из текстбокса
                int count = s.Count(str);
                count_Box.Text = count.ToString();//вставить текст в текст бокс
            }
            else 
            {
                StringManager s = new StringManager(text);
                strBox.Text = text;
                int count = s.Count(text);
                count_Box.Text = count.ToString();//вставить текст в текст бокс
            }
        }

        private void InsertionSort_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_str_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_col_TextChanged(object sender, EventArgs e)
        {

        }

        private void author_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Варов Всеволод Андреевич 6102");
        }
        private void exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((new ExitDialog()).ShowDialog(this) == DialogResult.Yes)
            { Close(); }
        }
        private void StartGuessing()
        {
            x = GuessGame.total_x;
            result = GuessGame.GetResult(param_a, param_b);
            param_a_textBox.ReadOnly = true;
            param_b_textBox.ReadOnly = true;
            result1_textBox.ReadOnly = false;
            isGuessing = true;
            result_answer.Text = string.Empty;
            MessageBox.Show("У вас " + GuessGame.total_x + " попыток");
        }

        private void CancelGuessing()
        {
            param_a_textBox.ReadOnly = false;
            param_b_textBox.ReadOnly = false;
            result1_textBox.ReadOnly = true;
            isGuessing = false;

            result_answer.Text = result.ToString();
        }

    }
}

