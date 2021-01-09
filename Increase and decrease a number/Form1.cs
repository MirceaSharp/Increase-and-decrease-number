using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Increase_and_decrease_a_number
{
    public partial class Form1 : Form
    {
        Number mynumber = new Number();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Number value:" +  mynumber.Count);
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            mynumber.Increase();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            mynumber.Reset();
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            mynumber.Decrease();
        }
    }
}
