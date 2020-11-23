
namespace DesafioSegurançaInformação
{
    partial class Form_Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cadastro));
            this.TBNome_Form_Cadastro = new System.Windows.Forms.TextBox();
            this.tbemail_Form_Cadastro = new System.Windows.Forms.TextBox();
            this.tbSenha_Form_Cadastro = new System.Windows.Forms.TextBox();
            this.lbNome_Form_Cadastro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvar_Form_Cadastro = new System.Windows.Forms.Button();
            this.btnVoltar_Form_Login = new System.Windows.Forms.Button();
            this.tbTelefone_Form_Cadastro = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // TBNome_Form_Cadastro
            // 
            this.TBNome_Form_Cadastro.Location = new System.Drawing.Point(95, 28);
            this.TBNome_Form_Cadastro.Name = "TBNome_Form_Cadastro";
            this.TBNome_Form_Cadastro.Size = new System.Drawing.Size(263, 20);
            this.TBNome_Form_Cadastro.TabIndex = 0;
            // 
            // tbemail_Form_Cadastro
            // 
            this.tbemail_Form_Cadastro.Location = new System.Drawing.Point(95, 100);
            this.tbemail_Form_Cadastro.Name = "tbemail_Form_Cadastro";
            this.tbemail_Form_Cadastro.Size = new System.Drawing.Size(263, 20);
            this.tbemail_Form_Cadastro.TabIndex = 2;
            // 
            // tbSenha_Form_Cadastro
            // 
            this.tbSenha_Form_Cadastro.Location = new System.Drawing.Point(95, 135);
            this.tbSenha_Form_Cadastro.MaxLength = 6;
            this.tbSenha_Form_Cadastro.Name = "tbSenha_Form_Cadastro";
            this.tbSenha_Form_Cadastro.Size = new System.Drawing.Size(263, 20);
            this.tbSenha_Form_Cadastro.TabIndex = 3;
            this.tbSenha_Form_Cadastro.Tag = "";
            // 
            // lbNome_Form_Cadastro
            // 
            this.lbNome_Form_Cadastro.AutoSize = true;
            this.lbNome_Form_Cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome_Form_Cadastro.Location = new System.Drawing.Point(25, 31);
            this.lbNome_Form_Cadastro.Name = "lbNome_Form_Cadastro";
            this.lbNome_Form_Cadastro.Size = new System.Drawing.Size(45, 17);
            this.lbNome_Form_Cadastro.TabIndex = 4;
            this.lbNome_Form_Cadastro.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Senha";
            // 
            // btnSalvar_Form_Cadastro
            // 
            this.btnSalvar_Form_Cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar_Form_Cadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar_Form_Cadastro.Location = new System.Drawing.Point(151, 185);
            this.btnSalvar_Form_Cadastro.Name = "btnSalvar_Form_Cadastro";
            this.btnSalvar_Form_Cadastro.Size = new System.Drawing.Size(122, 38);
            this.btnSalvar_Form_Cadastro.TabIndex = 8;
            this.btnSalvar_Form_Cadastro.Text = "Salvar";
            this.btnSalvar_Form_Cadastro.UseVisualStyleBackColor = true;
            this.btnSalvar_Form_Cadastro.Click += new System.EventHandler(this.btnSalvar_Form_Cadastro_Click);
            // 
            // btnVoltar_Form_Login
            // 
            this.btnVoltar_Form_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar_Form_Login.Location = new System.Drawing.Point(367, 206);
            this.btnVoltar_Form_Login.Name = "btnVoltar_Form_Login";
            this.btnVoltar_Form_Login.Size = new System.Drawing.Size(147, 33);
            this.btnVoltar_Form_Login.TabIndex = 9;
            this.btnVoltar_Form_Login.Text = "Voltar ao Menu";
            this.btnVoltar_Form_Login.UseVisualStyleBackColor = true;
            this.btnVoltar_Form_Login.Click += new System.EventHandler(this.btnVoltar_Form_Login_Click);
            // 
            // tbTelefone_Form_Cadastro
            // 
            this.tbTelefone_Form_Cadastro.Location = new System.Drawing.Point(96, 63);
            this.tbTelefone_Form_Cadastro.Mask = "(99) 00000-0000";
            this.tbTelefone_Form_Cadastro.Name = "tbTelefone_Form_Cadastro";
            this.tbTelefone_Form_Cadastro.Size = new System.Drawing.Size(262, 20);
            this.tbTelefone_Form_Cadastro.TabIndex = 10;
            // 
            // Form_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(526, 251);
            this.Controls.Add(this.tbTelefone_Form_Cadastro);
            this.Controls.Add(this.btnVoltar_Form_Login);
            this.Controls.Add(this.btnSalvar_Form_Cadastro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNome_Form_Cadastro);
            this.Controls.Add(this.tbSenha_Form_Cadastro);
            this.Controls.Add(this.tbemail_Form_Cadastro);
            this.Controls.Add(this.TBNome_Form_Cadastro);
            this.Name = "Form_Cadastro";
            this.Text = "Form_Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBNome_Form_Cadastro;
        private System.Windows.Forms.TextBox tbemail_Form_Cadastro;
        private System.Windows.Forms.TextBox tbSenha_Form_Cadastro;
        private System.Windows.Forms.Label lbNome_Form_Cadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvar_Form_Cadastro;
        private System.Windows.Forms.Button btnVoltar_Form_Login;
        private System.Windows.Forms.MaskedTextBox tbTelefone_Form_Cadastro;
    }
}