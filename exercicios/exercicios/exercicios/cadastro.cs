using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace exercicios
{
    public partial class cadastro : Form
    {
        List<string> nome, dtnasc, anoL, sexo, nomeR1, cpfR1, nomeR2, cpfR2;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtanoLetivo = "";
            txtcpfR = "";
            txtcpfR2 = "";
            txtdtNascimento = "";
            txtnome = "";
            txtnomeR = "";
            txtnomeR2 = "";
            txtsexoA = "";
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            novo = true;
            txtanoLetivo = "";
            txtcpfR = "";
            txtcpfR2 = "";
            txtdtNascimento = "";
            txtnome = "";
            txtnomeR = "";
            txtnomeR2 = "";
            txtsexoA = "";
            btncad.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (novo)
            {
                txtanoLetivo.add(txtanoLetivo.Text);
                txtcpfR.add(txtcpfR1.Text);
                txtcpfR2.add(txtcpfR2.Text);
                txtdtNascimento.add(txtdtNascimento.Text);
                txtnome.add(txtnome.Text);
                txtnomeR.add(txtnomeR.Text);
                txtnomeR2.add(txtnomeR2.Text);
                txtsexoA.add(txtsexoA.Text);
            }
            else
            {
                txtanoLetivo[listBox1.SelectedIndex] = txtanoLetivo.Text;
                txtcpfR[listBox1.SelectedIndex] = txtcpdR.Text;
                txtcpfR2[listBox1.SelectedIndex] = txtcpfR2.Text;
                txtdtNascimento[listBox1.SelectedIndex] = txtdtNascimento;
                txtnome[listBox1.SelectedIndex] = txtnome.Text;
                txtnomeR[listBox1.SelectedIndex] = txtnomeR.Text;
                txtnomeR2[listBox1.SelectedIndex] = txtnomeR2.Text;
                txtsexoA[listBox1.SelectedIndex] = txtsexoA.Text;
            }
        }

        bool novo
        public cadastro()
        {
            InitializeComponent();
            nome = new List<string>();
            dtnasc = new List<string>();
            anoL = new List<string>();
            sexo = new List<string>();
            nomeR1 = new List<string>();
            cpfR1 = new List<string>();
            nomeR2 = new List<string>();
            cpfR2 = new List<string>();
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
