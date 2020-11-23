using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using DesafioSegurançaInformação.Cadastro;

namespace DesafioSegurançaInformação
{
    public partial class Form_Cadastro : Form
    {


        public Form_Cadastro()
        {
            InitializeComponent();
        }

        private bool ValidarCampos()
        {
            if (TBNome_Form_Cadastro.Text == "")
            {
                MessageBox.Show("Nome Inválido", "Atenção");
                return false;
            }

            if (tbTelefone_Form_Cadastro.Text == "")
            {
                MessageBox.Show("Telefone Inválido", "Atenção");
                return false;
            }

            if (!tbemail_Form_Cadastro.Text.Contains("@") || tbemail_Form_Cadastro.Text == "")
            {
                MessageBox.Show("Email Inválido", "Atenção");
                return false;
            }

            if (tbSenha_Form_Cadastro.Text == "")
            {
                MessageBox.Show("Senha Inválido", "Atenção");
                return false;
            }

            return true;
        }

        private void LimparCampos()
        {
            TBNome_Form_Cadastro.Text = "";
            tbTelefone_Form_Cadastro.Text = "";
            tbemail_Form_Cadastro.Text = "";
            tbSenha_Form_Cadastro.Text = "";
        }


        private void btnVoltar_Form_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form L = new Form_Principal();
            L.Closed += (s, args) => this.Close();
            L.Show();
        }

       

        private void btnSalvar_Form_Cadastro_Click(object sender, EventArgs e)
        {
            Codificacão codificacao = new Codificacão();
            string senhafinal = codificacao.CriptografarSenha(tbSenha_Form_Cadastro.Text);

            if (ValidarCampos())
            {
                ManipulaCadastro.manipulacao.InserirRegistro(TBNome_Form_Cadastro.Text, tbTelefone_Form_Cadastro.Text, tbemail_Form_Cadastro.Text, senhafinal);
                MessageBox.Show($"Usuário adicionado {TBNome_Form_Cadastro.Text}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LimparCampos();
        }
    }
}
