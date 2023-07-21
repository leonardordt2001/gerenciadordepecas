using gerenciadordepecas.Model;
using gerenciadordepecas.View;
using Microsoft.Data.SqlClient;
using System.Data;


namespace gerenciadordepecas.Controller
{
    internal class ManipulaPecas
    {
        public void CadPecas()
        {
          SqlConnection cn = new SqlConnection(Conexao.Conectar());
          SqlCommand cmd = new SqlCommand("pcadastrarPecas",cn);
          cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("Pecas",Pecas.Peca);
                cmd.Parameters.AddWithValue("Marcas",Pecas.Marca);
                cmd.Parameters.AddWithValue("Capacidades",Pecas.Capacidade);

                SqlParameter nv = cmd.Parameters.Add("idPecas", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Peça cadastrada com sucesso, Deseja cadastrar outra peça", "Novo registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    TelaCadastrarPeca telaCadastrar = new TelaCadastrarPeca();
                    telaCadastrar.AbrirCadastro();
                }
            }
            catch (Exception)
            {

                throw;
            } 

        }

        public void BuscaPecasCod()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pBuscaPecasCodigo", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@idPecas", Pecas.Codigo);
                cn.Open();

                var registros = cmd.ExecuteReader();

                if (registros.Read())
                {
                    Pecas.Codigo = Convert.ToInt32(registros["IdPecas"]);
                    Pecas.Peca = (String)registros["Pecas"];
                    Pecas.Marca = (String)registros["Marcas"];
                    Pecas.Capacidade = (String)registros["Capacidades"];
                }
                else
                {
                    Pecas.Codigo = 0;
                    Pecas.Peca = "";
                    Pecas.Marca = "";
                    Pecas.Capacidade = "";
                    MessageBox.Show("Peça não encontrada", "Pesquisa código");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeletarPecasCod() 
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pDeletarPecas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("IdPecas", Pecas.Codigo);
                cn.Open();
                cmd.ExecuteNonQuery();
               

                var resposta = MessageBox.Show("Peça deletada com sucesso?", "Deletar registro)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AlterarPecas() 
        {

            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pAlterarpecas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@idPecas", Pecas.Codigo);
                cmd.Parameters.AddWithValue("@Pecas", Pecas.Peca);
                cmd.Parameters.AddWithValue("@Marcas", Pecas.Marca);
                cmd.Parameters.AddWithValue("@Capacidade", Pecas.Capacidade);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Peça alterada com sucesso.");

                Pecas.Codigo = 0;
                Pecas.Peca = "";
                Pecas.Marca = "";
                Pecas.Capacidade="";
            }
            catch (Exception)
            {

                throw;
            }

        }
    }

    
}
