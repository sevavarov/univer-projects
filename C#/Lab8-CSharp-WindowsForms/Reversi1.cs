using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Varov.Lab8
{
    public partial class Reversi1 : Form
    {
        public Button[,] _contr;
        private int move = 0;
        private string _b;
        public Reversi1()
        {
            InitializeComponent();
            Steps.Text = "Ход черных";
            Winner.Text = " ";
            Button[,] but = new Button[,] { {button1, button9, button17, button25, button33, button41, button49, button57 },
                                             { button2, button10, button18, button26, button34, button42, button50, button58 },
                                             { button3, button11, button19, button27, button35, button43, button51, button59 },
                                             { button4, button12, button20, button28, button36, button44, button52, button60 },
                                             { button5, button13, button21, button29, button37, button45, button53, button61 },
                                             { button6, button14, button22, button30, button38, button46, button54, button62 },
                                             { button7, button15, button23, button31, button39, button47, button55, button63 },
                                             { button8, button16, button24, button32, button40, button48, button56, button64 } };
            _contr = but;
            for (int i = 0; i < _contr.GetLength(0); i++)
            {
                for (int j = 0; j < _contr.GetLength(1); j++)
                {
                    _contr[i, j].Enabled = false;
                }
            }
            for (int i = 2; i < 6; i++)
            {
                for (int j = 2; j < 6; j++)
                {
                    _contr[i, j].Enabled = true;
                }
            }
            _contr[3, 3].Enabled = false;
            _contr[3, 4].Enabled = false;
            _contr[4, 3].Enabled = false;
            _contr[4, 4].Enabled = false;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            _b = sender.GetType().GetProperty("Name").GetValue(sender).ToString();
            int i;
            int j;
            int LineNumber;
            int ColumnNumber;
            bool go = true;
            i = -1;
            j = 0;
            while (i < _contr.GetLength(0) && go == true)
            {
                i++;
                j = 0;
                while (j < _contr.GetLength(1) && go == true)
                {
                    if (_contr[i, j].Name == _b)
                    {
                        if (move % 2 == 0)
                        {
                            _contr[i, j].BackColor = Color.Black;
                        }
                        else _contr[i, j].BackColor = Color.White;
                        go = false;
                        j--;
                    }
                    j++;
                }
            }
            Reversion(i, j, move, ref _contr);
            LineNumber = i;
            ColumnNumber = j;
            for (i = LineNumber - 1; (i < LineNumber + 2); i++)
            {
                for (j = ColumnNumber - 1; j < ColumnNumber + 2; j++)
                {
                    if ((i >= 0) && (i < _contr.GetLength(0)) && (j >= 0) && (j < _contr.GetLength(1)))
                        if (_contr[i, j].BackColor == Color.Pink)
                        {
                            _contr[i, j].Enabled = true;
                        }
                }
            }
            _contr[LineNumber, ColumnNumber].Enabled = false;
            move++;
            if (move % 2 == 0)
            {
                Steps.Text = "Ход чёрных!";
            }
            else Steps.Text = "Ход белых!";
            if (move == 60)
            {
                Winner.Text = Reversi.CheckWinner();
                MessageBox.Show(Winner.Text);
            }
        }

        private static Button[,] Reversion(int numberLine, int numberColumn, int currentStep, ref Button[,] _field)
        {
            Color[] array = new Color[_field.GetLength(0)];
            for (int j = 0; j < _field.GetLength(1); j++) // Переписываем строку в массив для изменений
            {
                array[j] = _field[numberLine, j].BackColor;
            }
            for (int j = 0; j < _field.GetLength(1); j++) // По строке
            {
                if (currentStep % 2 == 0)
                {
                    Reversi.ChangeElementsTo(array[j], Color.Black, Color.White, array);
                }
                else
                    Reversi.ChangeElementsTo(array[j], Color.White, Color.Black, array);
            }
            for (int j = 0; j < _field.GetLength(1); j++) // Обратно
            {
                _field[numberLine, j].BackColor = array[j];
            }

            for (int i = 0; i < _field.GetLength(0); i++) // Переписываем столбец в массив для изменений
            {
                array[i] = _field[i, numberColumn].BackColor;
            }
            for (int i = 0; i < _field.GetLength(0); i++) // По столбцу
            {
                if (currentStep % 2 == 0)
                {
                    Reversi.ChangeElementsTo(array[i], Color.Black, Color.White, array);
                }
                else
                    Reversi.ChangeElementsTo(array[i], Color.White, Color.Black, array);
            }
            for (int i = 0; i < _field.GetLength(0); i++) //Обратно
            {
                _field[i, numberColumn].BackColor = array[i];
            }
            return _field;
        }
    }
}
