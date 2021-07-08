using academia.Alunos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desing

{
    public partial class Form1 : Form
    {
        Academia academia;
        public Form1()
        {
            InitializeComponent();
            academia = new Academia();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            academia.AdicionaAluno(txtNome.Text);
            atualizaListBox();
        }
        private void atualizaListBox()
        {
            listBox1.Items.Clear();
            foreach (var aluno in academia.Alunos)
            {
                listBox1.Items.Add(aluno);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
