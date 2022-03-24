using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace ProjetoCarlosEduardo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculadora_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        private void radioButtonCanal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCanal.Checked == true)
            {

            }
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {

            try
            {
                int quantidade, canal, obturacao;

                if (textBoxNome.Text == "")
                {
                    MessageBox.Show("Favor. Informe seu nome!");
                    textBoxNome.Focus();
                }
                else if (textBoxQuantidade.Text == "")
                {
                    MessageBox.Show("Informe a quantidade do serviço.");
                }
                else if (radioButtonCanal.Checked == false && radioButtonObturacao.Checked == false)
                {
                    MessageBox.Show("Selecione o tipo de orçamento.");
                }
                else if (radioButtonCanal.Checked == true)
                {
                    quantidade = int.Parse(textBoxQuantidade.Text);
                    canal = quantidade * 400;
                    textBoxValorPagar.Text = canal.ToString("C2");
                    textBoxQuantidade.Clear();
                }
                else if (radioButtonObturacao.Checked == true)
                {
                    quantidade = int.Parse(textBoxQuantidade.Text);
                    obturacao = quantidade * 100;
                    textBoxValorPagar.Text = obturacao.ToString("C2");
                    textBoxQuantidade.Clear();
                }
                string nomearq = "Recibo.txt";
                StreamWriter objRecibo1 = new StreamWriter(nomearq);

                objRecibo1.WriteLine(" ---------------------------------------- ");
                objRecibo1.WriteLine(" Recibo de Compra ");
                objRecibo1.WriteLine("Data da Compra " + DateTime.Now);
                objRecibo1.WriteLine("Nome: " + textBoxNome.Text);
                objRecibo1.WriteLine("Valor: " + textBoxValorPagar.Text);
                objRecibo1.WriteLine(" ---------------------------------------- ");
                objRecibo1.Close(); MessageBox.Show("Recibo Gerado ");

            }
            catch (Exception erro)
            { MessageBox.Show("Erro de conexão ou problemas no banco de dados " + erro.Message); 
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxNome.Clear();
            textBoxQuantidade.Clear();
            textBoxValorPagar.Clear();
        }
    }
}
