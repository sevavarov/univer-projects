namespace Varov.Lab8
{
    partial class ExitDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.yes_button = new System.Windows.Forms.Button();
            this.no_button = new System.Windows.Forms.Button();
            this.exit_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yes_button
            // 
            this.yes_button.Location = new System.Drawing.Point(81, 130);
            this.yes_button.Name = "yes_button";
            this.yes_button.Size = new System.Drawing.Size(75, 23);
            this.yes_button.TabIndex = 0;
            this.yes_button.Text = "Yes";
            this.yes_button.UseVisualStyleBackColor = true;
            this.yes_button.Click += new System.EventHandler(this.yes_button_Click_1);
            // 
            // no_button
            // 
            this.no_button.Location = new System.Drawing.Point(277, 130);
            this.no_button.Name = "no_button";
            this.no_button.Size = new System.Drawing.Size(75, 23);
            this.no_button.TabIndex = 1;
            this.no_button.Text = "No";
            this.no_button.UseVisualStyleBackColor = true;
            this.no_button.Click += new System.EventHandler(this.no_button_Click_1);
            // 
            // exit_label
            // 
            this.exit_label.AutoSize = true;
            this.exit_label.Location = new System.Drawing.Point(170, 64);
            this.exit_label.Name = "exit_label";
            this.exit_label.Size = new System.Drawing.Size(98, 13);
            this.exit_label.TabIndex = 2;
            this.exit_label.Text = "Вы хотите выйти?";
            this.exit_label.Click += new System.EventHandler(this.exit_label_Click);
            // 
            // ExitDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 222);
            this.Controls.Add(this.exit_label);
            this.Controls.Add(this.no_button);
            this.Controls.Add(this.yes_button);
            this.Name = "ExitDialog";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yes_button;
        private System.Windows.Forms.Button no_button;
        private System.Windows.Forms.Label exit_label;
    }
}