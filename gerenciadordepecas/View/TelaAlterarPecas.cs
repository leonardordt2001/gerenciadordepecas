using gerenciadordepecas.Controller;
using gerenciadordepecas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerenciadordepecas.View
{
    public partial class TelaAlterarPecas : Form
    {
        public TelaAlterarPecas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32( textBoxCodalterar.Text);
            ManipulaPecas mpecas = new ManipulaPecas();
            mpecas.BuscaPecasCod();

            textBoxCodalterar.Text = Pecas.Codigo.ToString();
            textBoxpecas.Text = Pecas.Peca;
            textBoxmarca.Text = Pecas.Marca;
            textBoxcapacidade.Text = Pecas.Capacidade;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Pecas.Codigo = Convert.ToInt32(textBoxCodalterar.Text);
            Pecas.Peca = textBoxpecas.Text;
            Pecas.Marca = textBoxmarca.Text;
            Pecas.Capacidade = textBoxcapacidade.Text;

            ManipulaPecas mpecas =new ManipulaPecas();
            mpecas.AlterarPecas();
           
        }
    }
}
