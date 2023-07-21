using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerenciadordepecas.Model
{
    internal class Conexao
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\leonardo.saraujo8\source\repos\gerenciadordepecas\gerenciadordepecas\Model\pecasbd.mdf;Integrated Security=True";
        }
    }
}
