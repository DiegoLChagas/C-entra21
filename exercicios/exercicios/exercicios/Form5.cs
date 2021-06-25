using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace exercicios
{
    public partial class Form5 : Form
    {
        int n1, n2, n3, n4, total;

        private void valor3_TextChanged(object sender, EventArgs e)
        {
            n3 = int.Parse(valor3.Text);
        }

        private void valor4_TextChanged(object sender, EventArgs e)
        {
            n4 = int.Parse(valor4.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"A + B = {n1 + n2} \n" +
                $"A + C = {n1 + n3}\n" +
                $"A + D = {n1 + n4}\n" +
                $"B + C = {n2 + n3}\n" +
                $"B + D = {n2 + n4}\n" +
                $"C + D = {n3 + n4}\n");
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"A x B = {n1 * n2} \n" +
               $"A x C = {n1 * n3}\n" +
               $"A x D = {n1 * n4}\n" +
               $"B x C = {n2 * n3}\n" +
               $"B x D = {n2 * n4}\n" +
               $"C x D = {n3 * n4}\n");
        }

        private void valor2_TextChanged(object sender, EventArgs e)
        {
            n2 = int.Parse(valor2.Text);
        }

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void valor1_TextChanged(object sender, EventArgs e)
        {
            n1 = int.Parse(valor1.Text);
        }
    }
}
