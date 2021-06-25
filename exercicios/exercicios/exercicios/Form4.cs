using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace exercicios
{
    public partial class Form4 : Form
    {
        string vendedor;
        double preco, comi;
        int cod, qtd;
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            cod = int.Parse(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            preco = double.Parse(textBox3.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            qtd = int.Parse(textBox4.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comi = (qtd*preco)* 0.05;
            MessageBox.Show($"Ola {vendedor}, Sua comissão no produto {cod} sera de R${comi}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            vendedor = (textBox1.Text);
        }
    }
}
