namespace ui_wfa_SistVet
{
    partial class frmUsuariosPesquisar
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
            dtgUsuario = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Login = new DataGridViewTextBoxColumn();
            Senha = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Observ = new DataGridViewTextBoxColumn();
            btVoltarUsuario = new Button();
            btSelecionarUsuario = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgUsuario).BeginInit();
            SuspendLayout();
            // 
            // dtgUsuario
            // 
            dtgUsuario.AllowUserToAddRows = false;
            dtgUsuario.AllowUserToDeleteRows = false;
            dtgUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgUsuario.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Login, Senha, Email, Observ });
            dtgUsuario.Location = new Point(12, 24);
            dtgUsuario.Name = "dtgUsuario";
            dtgUsuario.ReadOnly = true;
            dtgUsuario.RowTemplate.Height = 25;
            dtgUsuario.Size = new Size(630, 218);
            dtgUsuario.TabIndex = 0;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 40;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Login
            // 
            Login.DataPropertyName = "Login";
            Login.HeaderText = "Login";
            Login.Name = "Login";
            Login.ReadOnly = true;
            // 
            // Senha
            // 
            Senha.DataPropertyName = "Senha";
            Senha.HeaderText = "Senha";
            Senha.Name = "Senha";
            Senha.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "E-mail";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Observ
            // 
            Observ.DataPropertyName = "Observ";
            Observ.HeaderText = "Observações";
            Observ.Name = "Observ";
            Observ.ReadOnly = true;
            Observ.Width = 150;
            // 
            // btVoltarUsuario
            // 
            btVoltarUsuario.Location = new Point(544, 248);
            btVoltarUsuario.Name = "btVoltarUsuario";
            btVoltarUsuario.Size = new Size(98, 23);
            btVoltarUsuario.TabIndex = 1;
            btVoltarUsuario.Text = "Voltar";
            btVoltarUsuario.UseVisualStyleBackColor = true;
            btVoltarUsuario.Click += btVoltarUsuario_Click;
            // 
            // btSelecionarUsuario
            // 
            btSelecionarUsuario.Location = new Point(440, 248);
            btSelecionarUsuario.Name = "btSelecionarUsuario";
            btSelecionarUsuario.Size = new Size(98, 23);
            btSelecionarUsuario.TabIndex = 2;
            btSelecionarUsuario.Text = "Selecionar";
            btSelecionarUsuario.UseVisualStyleBackColor = true;
            btSelecionarUsuario.Click += btSelecionarUsuario_Click;
            // 
            // frmUsuariosPesquisar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 295);
            Controls.Add(btSelecionarUsuario);
            Controls.Add(btVoltarUsuario);
            Controls.Add(dtgUsuario);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmUsuariosPesquisar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "::: Lista de Usuários :::";
            Load += frmUsuariosPesquisar_Load;
            ((System.ComponentModel.ISupportInitialize)dtgUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgUsuario;
        private Button btVoltarUsuario;
        private Button btSelecionarUsuario;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Login;
        private DataGridViewTextBoxColumn Senha;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Observ;
    }
}