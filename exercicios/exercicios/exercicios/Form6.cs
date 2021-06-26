using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace exercicios
{
    public partial class Form6 : Form
    {
        double horas, vel, dist, litros, consu;

        private void consulmo_TextChanged(object sender, EventArgs e)
        {
            consu = double.Parse(consulmo.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dist = horas * vel;
            litros = dist / consu;
            MessageBox.Show($"Em uma viagem de {horas} horas a {vel}Km/h \n" +
                $"um veiculo que faz {consu}KM por litro de Gasolina\n" +
                $"percorre uma distancia de {dist}KM \n" +
                $"e usa {litros}L de gasolina");
        }

        private void velo_TextChanged(object sender, EventArgs e)
        {
            vel = double.Parse(velo.Text);
        }

        public Form6()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            horas = double.Parse(textBox1.Text);
        }
    }
}
