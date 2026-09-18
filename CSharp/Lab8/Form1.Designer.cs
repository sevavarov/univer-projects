namespace Varov.Lab8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.clear_button = new System.Windows.Forms.Button();
            this.result_answer = new System.Windows.Forms.Label();
            this.input_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.result1_textBox = new System.Windows.Forms.TextBox();
            this.param_b_textBox = new System.Windows.Forms.TextBox();
            this.param_a_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sort_button = new System.Windows.Forms.Button();
            this.description_richTextBox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.size_textBox = new System.Windows.Forms.TextBox();
            this.GnomeSort_dataGridView = new System.Windows.Forms.DataGridView();
            this.InsertionSort_dataGridView = new System.Windows.Forms.DataGridView();
            this.source_mas_dataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.clear_button1 = new System.Windows.Forms.Button();
            this.count_Box = new System.Windows.Forms.TextBox();
            this.strBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GnomeSort_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsertionSort_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.source_mas_dataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(692, 348);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.clear_button);
            this.tabPage1.Controls.Add(this.result_answer);
            this.tabPage1.Controls.Add(this.input_button);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.result1_textBox);
            this.tabPage1.Controls.Add(this.param_b_textBox);
            this.tabPage1.Controls.Add(this.param_a_textBox);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(684, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Отгадать ответ";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.label3_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(182, 272);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 23);
            this.clear_button.TabIndex = 10;
            this.clear_button.Text = "Очистить";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click_1);
            // 
            // result_answer
            // 
            this.result_answer.AutoSize = true;
            this.result_answer.Location = new System.Drawing.Point(170, 244);
            this.result_answer.Name = "result_answer";
            this.result_answer.Size = new System.Drawing.Size(106, 13);
            this.result_answer.TabIndex = 9;
            this.result_answer.Text = "                                 \r\n";
            this.result_answer.Click += new System.EventHandler(this.result_answer_Click);
            // 
            // input_button
            // 
            this.input_button.Location = new System.Drawing.Point(337, 138);
            this.input_button.Name = "input_button";
            this.input_button.Size = new System.Drawing.Size(114, 55);
            this.input_button.TabIndex = 8;
            this.input_button.Text = "Угадать ответ";
            this.input_button.UseVisualStyleBackColor = true;
            this.input_button.Click += new System.EventHandler(this.input_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Правильный ответ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ваш ответ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "b";
            this.label2.Click += new System.EventHandler(this.param_b_label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "a";
            this.label1.Click += new System.EventHandler(this.param_a_label_Click);
            // 
            // result1_textBox
            // 
            this.result1_textBox.Location = new System.Drawing.Point(173, 203);
            this.result1_textBox.Name = "result1_textBox";
            this.result1_textBox.Size = new System.Drawing.Size(100, 20);
            this.result1_textBox.TabIndex = 3;
            // 
            // param_b_textBox
            // 
            this.param_b_textBox.Location = new System.Drawing.Point(173, 168);
            this.param_b_textBox.Name = "param_b_textBox";
            this.param_b_textBox.Size = new System.Drawing.Size(100, 20);
            this.param_b_textBox.TabIndex = 2;
            this.param_b_textBox.TextChanged += new System.EventHandler(this.param_b_textBox_TextChanged);
            // 
            // param_a_textBox
            // 
            this.param_a_textBox.Location = new System.Drawing.Point(173, 135);
            this.param_a_textBox.Name = "param_a_textBox";
            this.param_a_textBox.Size = new System.Drawing.Size(100, 20);
            this.param_a_textBox.TabIndex = 1;
            this.param_a_textBox.TextChanged += new System.EventHandler(this.param_a_textBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Varov.Lab8.Properties.Resources.images_0;
            this.pictureBox1.Location = new System.Drawing.Point(8, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 57);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.sort_button);
            this.tabPage2.Controls.Add(this.description_richTextBox);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.size_textBox);
            this.tabPage2.Controls.Add(this.GnomeSort_dataGridView);
            this.tabPage2.Controls.Add(this.InsertionSort_dataGridView);
            this.tabPage2.Controls.Add(this.source_mas_dataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(684, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Сортировка";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sort_button
            // 
            this.sort_button.Location = new System.Drawing.Point(429, 187);
            this.sort_button.Name = "sort_button";
            this.sort_button.Size = new System.Drawing.Size(160, 39);
            this.sort_button.TabIndex = 9;
            this.sort_button.Text = "Сортировать";
            this.sort_button.UseVisualStyleBackColor = true;
            this.sort_button.Click += new System.EventHandler(this.sort_button_Click_1);
            // 
            // description_richTextBox
            // 
            this.description_richTextBox.Location = new System.Drawing.Point(375, 40);
            this.description_richTextBox.Name = "description_richTextBox";
            this.description_richTextBox.Size = new System.Drawing.Size(260, 98);
            this.description_richTextBox.TabIndex = 8;
            this.description_richTextBox.Text = "Метод заполняет массив случайными числами в диапазоне [-10;10]";
            this.description_richTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Сортировка вставками";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Гномья сортировка ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Исходный массив";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Количество элементов";
            // 
            // size_textBox
            // 
            this.size_textBox.Location = new System.Drawing.Point(29, 40);
            this.size_textBox.Name = "size_textBox";
            this.size_textBox.Size = new System.Drawing.Size(199, 20);
            this.size_textBox.TabIndex = 3;
            // 
            // GnomeSort_dataGridView
            // 
            this.GnomeSort_dataGridView.AllowUserToAddRows = false;
            this.GnomeSort_dataGridView.AllowUserToDeleteRows = false;
            this.GnomeSort_dataGridView.AllowUserToResizeColumns = false;
            this.GnomeSort_dataGridView.AllowUserToResizeRows = false;
            this.GnomeSort_dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GnomeSort_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GnomeSort_dataGridView.ColumnHeadersVisible = false;
            this.GnomeSort_dataGridView.Location = new System.Drawing.Point(29, 147);
            this.GnomeSort_dataGridView.Name = "GnomeSort_dataGridView";
            this.GnomeSort_dataGridView.RowHeadersVisible = false;
            this.GnomeSort_dataGridView.RowHeadersWidth = 62;
            this.GnomeSort_dataGridView.Size = new System.Drawing.Size(199, 24);
            this.GnomeSort_dataGridView.TabIndex = 2;
            // 
            // InsertionSort_dataGridView
            // 
            this.InsertionSort_dataGridView.AllowUserToAddRows = false;
            this.InsertionSort_dataGridView.AllowUserToDeleteRows = false;
            this.InsertionSort_dataGridView.AllowUserToResizeColumns = false;
            this.InsertionSort_dataGridView.AllowUserToResizeRows = false;
            this.InsertionSort_dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.InsertionSort_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InsertionSort_dataGridView.ColumnHeadersVisible = false;
            this.InsertionSort_dataGridView.Location = new System.Drawing.Point(29, 202);
            this.InsertionSort_dataGridView.Name = "InsertionSort_dataGridView";
            this.InsertionSort_dataGridView.RowHeadersVisible = false;
            this.InsertionSort_dataGridView.RowHeadersWidth = 62;
            this.InsertionSort_dataGridView.Size = new System.Drawing.Size(199, 24);
            this.InsertionSort_dataGridView.TabIndex = 1;
            this.InsertionSort_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InsertionSort_dataGridView_CellContentClick);
            // 
            // source_mas_dataGridView
            // 
            this.source_mas_dataGridView.AllowUserToAddRows = false;
            this.source_mas_dataGridView.AllowUserToDeleteRows = false;
            this.source_mas_dataGridView.AllowUserToResizeColumns = false;
            this.source_mas_dataGridView.AllowUserToResizeRows = false;
            this.source_mas_dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.source_mas_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.source_mas_dataGridView.ColumnHeadersVisible = false;
            this.source_mas_dataGridView.Location = new System.Drawing.Point(29, 94);
            this.source_mas_dataGridView.Name = "source_mas_dataGridView";
            this.source_mas_dataGridView.RowHeadersVisible = false;
            this.source_mas_dataGridView.RowHeadersWidth = 62;
            this.source_mas_dataGridView.Size = new System.Drawing.Size(199, 24);
            this.source_mas_dataGridView.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.clear_button1);
            this.tabPage3.Controls.Add(this.count_Box);
            this.tabPage3.Controls.Add(this.strBox);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(684, 322);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Строки";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(342, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Посчитать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.count_Click);
            // 
            // clear_button1
            // 
            this.clear_button1.Location = new System.Drawing.Point(137, 247);
            this.clear_button1.Name = "clear_button1";
            this.clear_button1.Size = new System.Drawing.Size(123, 29);
            this.clear_button1.TabIndex = 4;
            this.clear_button1.Text = "Очистить";
            this.clear_button1.UseVisualStyleBackColor = true;
            this.clear_button1.Click += new System.EventHandler(this.clear_button1_Click);
            // 
            // count_Box
            // 
            this.count_Box.Location = new System.Drawing.Point(416, 47);
            this.count_Box.Name = "count_Box";
            this.count_Box.Size = new System.Drawing.Size(139, 20);
            this.count_Box.TabIndex = 3;
            // 
            // strBox
            // 
            this.strBox.Location = new System.Drawing.Point(26, 47);
            this.strBox.Multiline = true;
            this.strBox.Name = "strBox";
            this.strBox.Size = new System.Drawing.Size(172, 171);
            this.strBox.TabIndex = 2;
            this.strBox.TextChanged += new System.EventHandler(this.strBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(417, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Количество А(а) в строке:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Исходная строка:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(684, 322);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Игра";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 141);
            this.button1.TabIndex = 1;
            this.button1.Text = "Начать игру";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обАвтореToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(692, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.обАвтореToolStripMenuItem.Text = "Об авторе";
            this.обАвтореToolStripMenuItem.Click += new System.EventHandler(this.author_ToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.exit_ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 356);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GnomeSort_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsertionSort_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.source_mas_dataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox description_richTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox size_textBox;
        private System.Windows.Forms.DataGridView GnomeSort_dataGridView;
        private System.Windows.Forms.DataGridView InsertionSort_dataGridView;
        private System.Windows.Forms.DataGridView source_mas_dataGridView;
        private System.Windows.Forms.Button sort_button;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button input_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox result1_textBox;
        private System.Windows.Forms.TextBox param_b_textBox;
        private System.Windows.Forms.TextBox param_a_textBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label result_answer;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button clear_button1;
        private System.Windows.Forms.TextBox count_Box;
        private System.Windows.Forms.TextBox strBox;
        private System.Windows.Forms.Button button1;
    }
}

