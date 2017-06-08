using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feynman
{
    public partial class Tela1 : Form
    {
        public Tela1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
      
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = "3) Volte no tema e pesquise sobre ele";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Text = "4) Revise e simplifique ainda mais";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Text = "3) Volte no tema e pesquise sobre ele";
        }

        private void bt01_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            
                Tela2 frms = new Tela2();
                frms.ShowDialog();
            
        }
    }
}


/*

4 passos para aprender tudo que você quiser,
segundo um Nobel da Física  Richard Feynman (1918-1988), 

1) Escolha um conceito
2) Escreva-o como se estivesse ensinando uma criança
3) Volte no tema e pesquise sobre ele
4) Revise e simplifique ainda mais

Iremos abortar um pouco disso, vamos?
*/
