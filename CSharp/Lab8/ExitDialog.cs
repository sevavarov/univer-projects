using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Varov.Lab8
{
    public partial class ExitDialog : Form
    {
        public ExitDialog()
        {
            InitializeComponent();
        }

        private void exit_label_Click(object sender, EventArgs e)
        {

        }

        private void yes_button_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void no_button_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
