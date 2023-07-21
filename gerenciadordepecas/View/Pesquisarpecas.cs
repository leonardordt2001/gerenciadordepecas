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
using gerenciadordepecas.Controller;

namespace gerenciadordepecas.View
{
    public partial class Pesquisarpecas : Form
    {
        public Pesquisarpecas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(textBoxCodigo.Text);
            ManipulaPecas mpecas= new ManipulaPecas();
            mpecas.BuscaPecasCod();

            textBoxCodigo.Text =Pecas.Codigo.ToString();
            textBoxppecas.Text = Pecas.Peca;
            textBoxmMarca.Text = Pecas.Marca;
            textBoxcCapacidade.Text = Pecas.Capacidade;
                

        }
    }
}
