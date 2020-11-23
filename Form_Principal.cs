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
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form L = new Form_Login();
            L.Closed += (s, args) => this.Close();
            L.Show();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form C = new Form_Cadastro();
            C.Closed += (s, args) => this.Close();
            C.Show();

        }
    }
}
