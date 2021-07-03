using ContaOO.dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaOO
{
    public partial class Form1 : Form
    {
        conta conta;
        List<conta> contas = new List<conta>();
        public Form1()
        {
            InitializeComponent();

            
            conta conta2 = new conta(1, "Bruno");
            conta.deposita(20);
            contas.Add(conta);
            contas.Remove(conta);
        }


        private void btnnovaconta_Click(object sender, EventArgs e)
        {
            
           bool sacou = conta.saca(double.Parse(mskvalor.Text));
            if(sacou)
            {

            MessageBox.Show($"Numero = {conta.Numero}" +
                $" Titular = {conta.Titular} " +
                $"Saldo: {conta.Saldo} ");

            }
            else
            {

                MessageBox.Show($"Saldo Insulficiente. " +
                    $"Saldo atual {conta.Saldo}");
            }
            mskvalor.Text = conta.Saldo.ToString();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtnomeconta.Text = conta.Numero.ToString();
            txtTitular.Text = conta.Titular;
            mskvalor.Text = conta.Saldo.ToString();
        }
    }
}
