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
    public partial class TelaDeletarPecas : Form
    {
        public TelaDeletarPecas()
        {
            InitializeComponent();
        }

        private void buttonDeletarCodigo_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(textBoxCodigo.Text);
            ManipulaPecas mpecas = new ManipulaPecas();
            mpecas.BuscaPecasCod();

            textBoxCodigoVer.Text = Pecas.Codigo.ToString();
            textBoxPecas.Text = Pecas.Peca;
            textBoxMarca.Text = Pecas.Marca;
            textBoxCapacidade.Text = Pecas.Capacidade;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(textBoxCodigoVer.Text);

            ManipulaPecas mpecas = new ManipulaPecas();
            mpecas.DeletarPecasCod();

        }
        
    }
}
