
namespace DesafioSegurançaInformação
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.btnLogar_from_login = new System.Windows.Forms.Button();
            this.TBusario_Form_Login = new System.Windows.Forms.TextBox();
            this.TbSenha_Form_Login = new System.Windows.Forms.TextBox();
            this.lUsuario_Form_Login = new System.Windows.Forms.Label();
            this.lSenha_Form_Login = new System.Windows.Forms.Label();
            this.btnVoltar_Form_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogar_from_login
            // 
            this.btnLogar_from_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar_from_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogar_from_login.Location = new System.Drawing.Point(92, 179);
            this.btnLogar_from_login.Name = "btnLogar_from_login";
            this.btnLogar_from_login.Size = new System.Drawing.Size(147, 33);
            this.btnLogar_from_login.TabIndex = 0;
            this.btnLogar_from_login.Text = "Logar";
            this.btnLogar_from_login.UseVisualStyleBackColor = true;
            this.btnLogar_from_login.Click += new System.EventHandler(this.btnLogar_from_login_Click);
            // 
            // TBusario_Form_Login
            // 
            this.TBusario_Form_Login.Location = new System.Drawing.Point(92, 36);
            this.TBusario_Form_Login.Name = "TBusario_Form_Login";
            this.TBusario_Form_Login.Size = new System.Drawing.Size(230, 20);
            this.TBusario_Form_Login.TabIndex = 1;
            // 
            // TbSenha_Form_Login
            // 
            this.TbSenha_Form_Login.Location = new System.Drawing.Point(92, 85);
            this.TbSenha_Form_Login.Name = "TbSenha_Form_Login";
            this.TbSenha_Form_Login.Size = new System.Drawing.Size(172, 20);
            this.TbSenha_Form_Login.TabIndex = 2;
            // 
            // lUsuario_Form_Login
            // 
            this.lUsuario_Form_Login.AutoSize = true;
            this.lUsuario_Form_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsuario_Form_Login.Location = new System.Drawing.Point(24, 36);
            this.lUsuario_Form_Login.Name = "lUsuario_Form_Login";
            this.lUsuario_Form_Login.Size = new System.Drawing.Size(45, 17);
            this.lUsuario_Form_Login.TabIndex = 3;
            this.lUsuario_Form_Login.Text = "Nome";
            // 
            // lSenha_Form_Login
            // 
            this.lSenha_Form_Login.AutoSize = true;
            this.lSenha_Form_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSenha_Form_Login.Location = new System.Drawing.Point(24, 88);
            this.lSenha_Form_Login.Name = "lSenha_Form_Login";
            this.lSenha_Form_Login.Size = new System.Drawing.Size(49, 17);
            this.lSenha_Form_Login.TabIndex = 4;
            this.lSenha_Form_Login.Text = "Senha";
            // 
            // btnVoltar_Form_Login
            // 
            this.btnVoltar_Form_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar_Form_Login.Location = new System.Drawing.Point(367, 206);
            this.btnVoltar_Form_Login.Name = "btnVoltar_Form_Login";
            this.btnVoltar_Form_Login.Size = new System.Drawing.Size(147, 33);
            this.btnVoltar_Form_Login.TabIndex = 5;
            this.btnVoltar_Form_Login.Text = "Voltar ao Menu";
            this.btnVoltar_Form_Login.UseVisualStyleBackColor = true;
            this.btnVoltar_Form_Login.Click += new System.EventHandler(this.btnVoltar_Form_Login_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(526, 251);
            this.Controls.Add(this.btnVoltar_Form_Login);
            this.Controls.Add(this.lSenha_Form_Login);
            this.Controls.Add(this.lUsuario_Form_Login);
            this.Controls.Add(this.TbSenha_Form_Login);
            this.Controls.Add(this.TBusario_Form_Login);
            this.Controls.Add(this.btnLogar_from_login);
            this.Name = "Form_Login";
            this.Text = "Form_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogar_from_login;
        private System.Windows.Forms.TextBox TBusario_Form_Login;
        private System.Windows.Forms.TextBox TbSenha_Form_Login;
        private System.Windows.Forms.Label lUsuario_Form_Login;
        private System.Windows.Forms.Label lSenha_Form_Login;
        private System.Windows.Forms.Button btnVoltar_Form_Login;
    }
}