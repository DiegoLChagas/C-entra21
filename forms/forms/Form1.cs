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
        const int tamanhoHistorico = 3;
        int[] HistoricoCalculadora = new int[100];
        int indiceHistorico = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnad_Click(object sender, EventArgs e)
        {
            AdicionarHistorico(n1 + n2);
            
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            AdicionarHistorico(n1 - n2);
           
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            AdicionarHistorico(n1 * n2);
            
        }
        private void AdicionarHistorico(int valor)
        {
            if(indiceHistorico < HistoricoCalculadora.Length)
            {
            HistoricoCalculadora[indiceHistorico] = valor;
            indiceHistorico++;
            MessageBox.Show($"{valor}");
            }
            else
            {
                MessageBox.Show("memoria cheia");
            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            if (n2 == 0)
            {
                Console.WriteLine("impossivel dividir por zero");
            }

            else 
            {
                AdicionarHistorico(n1 / n2);

                
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            n1 = int.Parse(textBox1.Text);
        }

        private void btnhist_Click(object sender, EventArgs e)
        {
            string mensagem = "";
            foreach (var item in HistoricoCalculadora)
            {
                if (item != 0)
                {
                    mensagem += $" {item} \n ";
                }
            }
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            HistoricoCalculadora = new int[tamanhoHistorico];
            indiceHistorico = 0;
        }

        private void btnsalve_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            n2 = int.Parse(textBox2.Text);
        }
    }
}
