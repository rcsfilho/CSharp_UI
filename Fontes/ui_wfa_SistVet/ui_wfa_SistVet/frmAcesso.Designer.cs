namespace ui_wfa_SistVet
{
    partial class frmAcesso
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
            tbUsuariologin = new TextBox();
            tbSenhausuario = new TextBox();
            lbUsuarioLogin = new Label();
            lbSenhaUsuario = new Label();
            btSairAcesso = new Button();
            btAcessoPrograma = new Button();
            SuspendLayout();
            // 
            // tbUsuariologin
            // 
            tbUsuariologin.Location = new Point(165, 61);
            tbUsuariologin.Name = "tbUsuariologin";
            tbUsuariologin.Size = new Size(154, 23);
            tbUsuariologin.TabIndex = 0;
            // 
            // tbSenhausuario
            // 
            tbSenhausuario.Location = new Point(165, 112);
            tbSenhausuario.Name = "tbSenhausuario";
            tbSenhausuario.PasswordChar = '*';
            tbSenhausuario.Size = new Size(154, 23);
            tbSenhausuario.TabIndex = 1;
            // 
            // lbUsuarioLogin
            // 
            lbUsuarioLogin.AutoSize = true;
            lbUsuarioLogin.Font = new Font("Kristen ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbUsuarioLogin.Location = new Point(30, 54);
            lbUsuarioLogin.Name = "lbUsuarioLogin";
            lbUsuarioLogin.Size = new Size(129, 29);
            lbUsuarioLogin.TabIndex = 2;
            lbUsuarioLogin.Text = "UserName";
            // 
            // lbSenhaUsuario
            // 
            lbSenhaUsuario.AutoSize = true;
            lbSenhaUsuario.Font = new Font("Kristen ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbSenhaUsuario.Location = new Point(69, 105);
            lbSenhaUsuario.Name = "lbSenhaUsuario";
            lbSenhaUsuario.Size = new Size(81, 29);
            lbSenhaUsuario.TabIndex = 3;
            lbSenhaUsuario.Text = "Senha";
            // 
            // btSairAcesso
            // 
            btSairAcesso.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btSairAcesso.Location = new Point(144, 170);
            btSairAcesso.Name = "btSairAcesso";
            btSairAcesso.Size = new Size(75, 23);
            btSairAcesso.TabIndex = 4;
            btSairAcesso.Text = "&Sair";
            btSairAcesso.UseVisualStyleBackColor = true;
            btSairAcesso.Click += btSairAcesso_Click;
            // 
            // btAcessoPrograma
            // 
            btAcessoPrograma.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btAcessoPrograma.Location = new Point(244, 170);
            btAcessoPrograma.Name = "btAcessoPrograma";
            btAcessoPrograma.Size = new Size(75, 23);
            btAcessoPrograma.TabIndex = 5;
            btAcessoPrograma.Text = "&Acessar";
            btAcessoPrograma.UseVisualStyleBackColor = true;
            btAcessoPrograma.Click += btAcessoPrograma_Click;
            // 
            // frmAcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 231);
            Controls.Add(btAcessoPrograma);
            Controls.Add(btSairAcesso);
            Controls.Add(lbSenhaUsuario);
            Controls.Add(lbUsuarioLogin);
            Controls.Add(tbSenhausuario);
            Controls.Add(tbUsuariologin);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAcesso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "::: Acesso :::";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUsuariologin;
        private TextBox tbSenhausuario;
        private Label lbUsuarioLogin;
        private Label lbSenhaUsuario;
        private Button btSairAcesso;
        private Button btAcessoPrograma;
    }
}