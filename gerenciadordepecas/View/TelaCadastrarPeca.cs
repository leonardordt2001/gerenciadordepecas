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
    public partial class TelaCadastrarPeca : Form
    {
        public TelaCadastrarPeca()
        {
            InitializeComponent();
        }

        private void btnCadastrarPecas_Click(object sender, EventArgs e)
        {
            Pecas.Peca = textBoxpecas.Text;
            Pecas.Marca = textBoxMarca.Text;
            Pecas.Capacidade = textBoxCapacidade.Text;

            ManipulaPecas mPeca= new ManipulaPecas();
            mPeca.CadPecas();


        }

        public void AbrirCadastro() 
        {
            this.ShowDialog();        
        }
    }
}
