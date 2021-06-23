using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{
    public partial class Form1 : Form
    {
        int n1, n2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnad_Click(object sender, EventArgs e)
        {
           
            n1 = int.Parse(textBox1.Text);
            n2 = int.Parse(textBox2.Text);
            MessageBox.Show($"{n1 + n2}");
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(textBox1.Text);
            n2 = int.Parse(textBox2.Text);
            MessageBox.Show($"{n1 - n2}");
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            if( n1 == 1)
            { n1++; }
            n1 = int.Parse(textBox1.Text);
            n2 = int.Parse(textBox2.Text);
            MessageBox.Show($"{n1 * n2}");
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
          
            
            
            MessageBox.Show($"{n1 / n2}");
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            n1 = int.Parse(textBox1.Text);
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            n2 = int.Parse(textBox2.Text);
        }
    }
}
