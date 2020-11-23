using DesafioSegurançaInformação.Cadastro;
using DesafioSegurançaInformação.ManipulaCadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioSegurançaInformação
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btnVoltar_Form_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form L = new Form_Principal();
            L.Closed += (s, args) => this.Close();
            L.Show();
        }
        private void LimparCampos()
        {
            TBusario_Form_Login.Text = "";
            TbSenha_Form_Login.Text = "";
        }


        private void btnLogar_from_login_Click(object sender, EventArgs e)
        {
           
            Codificacão codificacao = new Codificacão();
            string senhafinal = codificacao.CriptografarSenha(TbSenha_Form_Login.Text);

            manipulacao manipula = new manipulacao();
            bool igual = manipula.Verificarsenha(TBusario_Form_Login.Text,senhafinal);

            if (igual)
            {
                MessageBox.Show("Logado com Sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Login não encontrado, verifique login e senha", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LimparCampos();
        }
    }
}
