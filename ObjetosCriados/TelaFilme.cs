using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjetosCriados
{
    public partial class TelaFilme : Form
    {
        public TelaFilme()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        Filme fil = new Filme();
        Filme[] vet = new Filme[5];
        int i = 0;
        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (i == 5)
            {
                MessageBox.Show("Não é possivel gravar!");
            }
            else
            {
                fil.Titulo = txtTitulo.Text;
                fil.Classificacao = txtClassificacao.Text;
                fil.Genero = txtGenero.Text;
                fil.Sinopse = txtSinopse.Text;
                vet[i] = fil;
                i++;
            }
            Limpar();
        }

        private void Limpar()
        {
            txtSinopse.Text = null;
            txtTitulo.Text = null;
            txtGenero.Text = null;
            txtClassificacao.Text = null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            for(int x = 0; x < 5; x++)
            {
                if (txtTitulo.Text.Equals(vet[x].Titulo))
                {
                    txtClassificacao.Text = vet[x].Classificacao;
                    txtGenero.Text = vet[x].Genero; 
                    txtSinopse.Text = vet[x].Sinopse;
                    x = 5;
                }
                else
                {
                    MessageBox.Show("Titulo não existe!");
                }
            }
        }
    }
}
