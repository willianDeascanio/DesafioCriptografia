using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSegurançaInformação
{
   public class CadastroClientes
    {
        List<Clientes> clientes = new List<Clientes>();

        public CadastroClientes()
        {

        }

        public void Salvar(string nome, string telefone, string email, string senha)
        {
            Clientes cliente = new Clientes(nome, telefone, email, senha);
            clientes.Add(cliente);
        }
    }
}
