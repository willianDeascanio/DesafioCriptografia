using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DesafioSegurançaInformação.Cadastro
{
    class Codificacão
    {

        public string CriptografarSenha(string senha)
        {

            var valorCodificado = Encoding.UTF8.GetBytes(senha);
            var senhaCriptografada = SHA1.Create().ComputeHash(valorCodificado);

            StringBuilder stringBuilder = new StringBuilder();

            for (int contador = 0; contador < senhaCriptografada.Length; contador++)
            {
                stringBuilder.Append(senhaCriptografada[contador].ToString("X2"));
            }

            return stringBuilder.ToString();
        }
    }
}
