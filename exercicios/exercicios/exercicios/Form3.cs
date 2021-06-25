using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace exercicios
{
    public partial class Form3 : Form
    {
        double cot, doll, real;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            doll = double.Parse(textBox1.Text);
        }

        private void btnreal_Click(object sender, EventArgs e)
        {
            real = doll * cot;
            MessageBox.Show($"isso da R${real}");
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void btncot_TextChanged(object sender, EventArgs e)
        {
            cot = double.Parse(btncot.Text);
        }
    }
}
