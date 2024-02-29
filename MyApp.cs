using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String text = textBox1.Text;
            MessageBox.Show("You entered : " + text);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            String textLAbel = textBox2.Text;
            label3.Text = "You entered : " + textBox2.Text;

            label3.Show();
        }
    }
}
