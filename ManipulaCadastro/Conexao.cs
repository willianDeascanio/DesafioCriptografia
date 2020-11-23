using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSegurançaInformação.ManipulaCadastro
{
    class Conexao
    {
        public static SqlConnection Conectar()
        {
            string conexao = @"Data Source=DESKTOP-P1LERIQ;Initial Catalog=desafiointeligencia;Integrated Security=True";
            SqlConnection conection = new SqlConnection(conexao);
            conection.Open();
            return conection;

        }

    }
}
