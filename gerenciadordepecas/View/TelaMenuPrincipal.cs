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
    public partial class TelaMenuPrincipal : Form
    {
        public TelaMenuPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastrarPeca telaCadastrar = new TelaCadastrarPeca();
            telaCadastrar.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pesquisarpecas pesquisarpecas= new Pesquisarpecas();
            pesquisarpecas.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaAlterarPecas telaAlterarPecas = new TelaAlterarPecas();
            telaAlterarPecas.Show();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaDeletarPecas telaDeletar = new TelaDeletarPecas();
            telaDeletar.Show();
        }
    }
}
