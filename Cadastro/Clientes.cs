using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSegurançaInformação
{
    public class Clientes
    {
        public string nome;
        public string telefone;
        public string email;
        public string senha;

        public Clientes()
        {

        }

        public Clientes(string nome, string telefone, string email, string senha)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.senha = senha;
        }
    }
}

