using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace exercicios
{
    public partial class Form7 : Form
    {
        double cel, fah, cel1, fah1;
        public Form7()
        {
            InitializeComponent();
        }

        private void convert_Click(object sender, EventArgs e)
        {
            fah = (9 * cel + 160) / 5;
            MessageBox.Show($"{cel}Cº convertido em Fahrenheit sao: {fah}Fº");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fah1 = double.Parse(textBox1.Text);
        }

        private void btncel_Click(object sender, EventArgs e)
        {
            cel1 = (fah1 - 32) * 5 / 9;
            MessageBox.Show($"{fah1}Fº convertido em celsius sao: {cel1}Cº ");
        }

        private void celci_TextChanged(object sender, EventArgs e)
        {
            cel = double.Parse(celci.Text);
        }
    }
}
