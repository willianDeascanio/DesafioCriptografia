using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSegurançaInformação.ManipulaCadastro
{
    public class manipulacao
    {
        public static void InserirRegistro(string nome, string telefone, string email, string senha)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Conexao.Conectar();

            command.CommandText = $"INSERT Cadastro VALUES (@nome, @telefone, @email, @senha)";

            command.Parameters.AddWithValue("@nome", nome);
            command.Parameters.AddWithValue("@telefone", telefone);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@senha", senha);


            command.ExecuteNonQuery();
        }

        public bool SenhaCompativel = false;

        public bool Verificarsenha(string nome, string senha)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Conexao.Conectar();

            command.CommandText = $"SELECT nome, senha FROM Cadastro where nome = @nome and senha = @senha";

            command.Parameters.AddWithValue("@nome", nome);
            command.Parameters.AddWithValue("@senha", senha);

            SqlDataReader RetornoBancoDados = command.ExecuteReader();

            if (RetornoBancoDados.HasRows)
            {
                SenhaCompativel = true;
            }

            return SenhaCompativel;

        }

    }
}
