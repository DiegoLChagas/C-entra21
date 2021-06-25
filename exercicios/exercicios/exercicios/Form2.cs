using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace exercicios
{
    public partial class Form2 : Form
    {
        int n1, n2, med;
        public Form2()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            n1 = int.Parse(textBox1.Text);
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            n2 = int.Parse(textBox2.Text);
        }
        private void btnesto_Click(object sender, EventArgs e)
        {
            med = (n1 + n2)/2;
            MessageBox.Show($"O estoque medio é : {med}");
        }
    }
}
