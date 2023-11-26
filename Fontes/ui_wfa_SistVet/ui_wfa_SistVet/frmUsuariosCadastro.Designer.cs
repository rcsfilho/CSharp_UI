namespace ui_wfa_SistVet
{
    partial class frmUsuariosCadastro
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
            tbIdUsuario = new TextBox();
            tbNomeUsuario = new TextBox();
            tbLoginUsuario = new TextBox();
            tbSenhaUsuario = new TextBox();
            tbEmailUsuario = new TextBox();
            tbObsUsuario = new TextBox();
            btCadastrarUsuario = new Button();
            btAtualizarUsuario = new Button();
            btRemoverUsuario = new Button();
            btPesquisarUsuario = new Button();
            btLimparUsuario = new Button();
            btFecharUsuario = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // tbIdUsuario
            // 
            tbIdUsuario.BackColor = SystemColors.ScrollBar;
            tbIdUsuario.Enabled = false;
            tbIdUsuario.Location = new Point(26, 34);
            tbIdUsuario.Name = "tbIdUsuario";
            tbIdUsuario.Size = new Size(63, 23);
            tbIdUsuario.TabIndex = 0;
            // 
            // tbNomeUsuario
            // 
            tbNomeUsuario.Location = new Point(26, 77);
            tbNomeUsuario.Name = "tbNomeUsuario";
            tbNomeUsuario.Size = new Size(332, 23);
            tbNomeUsuario.TabIndex = 1;
            // 
            // tbLoginUsuario
            // 
            tbLoginUsuario.Location = new Point(26, 123);
            tbLoginUsuario.Name = "tbLoginUsuario";
            tbLoginUsuario.Size = new Size(155, 23);
            tbLoginUsuario.TabIndex = 2;
            // 
            // tbSenhaUsuario
            // 
            tbSenhaUsuario.Location = new Point(203, 123);
            tbSenhaUsuario.Name = "tbSenhaUsuario";
            tbSenhaUsuario.PasswordChar = '*';
            tbSenhaUsuario.Size = new Size(155, 23);
            tbSenhaUsuario.TabIndex = 3;
            // 
            // tbEmailUsuario
            // 
            tbEmailUsuario.Location = new Point(26, 175);
            tbEmailUsuario.Name = "tbEmailUsuario";
            tbEmailUsuario.Size = new Size(332, 23);
            tbEmailUsuario.TabIndex = 4;
            // 
            // tbObsUsuario
            // 
            tbObsUsuario.Location = new Point(26, 221);
            tbObsUsuario.Name = "tbObsUsuario";
            tbObsUsuario.Size = new Size(332, 23);
            tbObsUsuario.TabIndex = 5;
            // 
            // btCadastrarUsuario
            // 
            btCadastrarUsuario.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btCadastrarUsuario.Location = new Point(30, 262);
            btCadastrarUsuario.Name = "btCadastrarUsuario";
            btCadastrarUsuario.Size = new Size(95, 23);
            btCadastrarUsuario.TabIndex = 6;
            btCadastrarUsuario.Text = "Cadastrar";
            btCadastrarUsuario.UseVisualStyleBackColor = true;
            btCadastrarUsuario.Click += btCadastrarUsuario_Click;
            // 
            // btAtualizarUsuario
            // 
            btAtualizarUsuario.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btAtualizarUsuario.Location = new Point(145, 262);
            btAtualizarUsuario.Name = "btAtualizarUsuario";
            btAtualizarUsuario.Size = new Size(95, 23);
            btAtualizarUsuario.TabIndex = 7;
            btAtualizarUsuario.Text = "Alterar";
            btAtualizarUsuario.UseVisualStyleBackColor = true;
            btAtualizarUsuario.Click += btAtualizarUsuario_Click;
            // 
            // btRemoverUsuario
            // 
            btRemoverUsuario.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btRemoverUsuario.Location = new Point(263, 262);
            btRemoverUsuario.Name = "btRemoverUsuario";
            btRemoverUsuario.Size = new Size(95, 23);
            btRemoverUsuario.TabIndex = 8;
            btRemoverUsuario.Text = "Remover";
            btRemoverUsuario.UseVisualStyleBackColor = true;
            btRemoverUsuario.Click += btRemoverUsuario_Click;
            // 
            // btPesquisarUsuario
            // 
            btPesquisarUsuario.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btPesquisarUsuario.Location = new Point(30, 296);
            btPesquisarUsuario.Name = "btPesquisarUsuario";
            btPesquisarUsuario.Size = new Size(95, 23);
            btPesquisarUsuario.TabIndex = 9;
            btPesquisarUsuario.Text = "Pesquisar";
            btPesquisarUsuario.UseVisualStyleBackColor = true;
            btPesquisarUsuario.Click += btPesquisarUsuario_Click;
            // 
            // btLimparUsuario
            // 
            btLimparUsuario.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btLimparUsuario.Location = new Point(145, 296);
            btLimparUsuario.Name = "btLimparUsuario";
            btLimparUsuario.Size = new Size(95, 23);
            btLimparUsuario.TabIndex = 10;
            btLimparUsuario.Text = "Limpar";
            btLimparUsuario.UseVisualStyleBackColor = true;
            btLimparUsuario.Click += btLimparUsuario_Click;
            // 
            // btFecharUsuario
            // 
            btFecharUsuario.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btFecharUsuario.Location = new Point(263, 296);
            btFecharUsuario.Name = "btFecharUsuario";
            btFecharUsuario.Size = new Size(95, 23);
            btFecharUsuario.TabIndex = 11;
            btFecharUsuario.Text = "Fechar";
            btFecharUsuario.UseVisualStyleBackColor = true;
            btFecharUsuario.Click += btFecharUsuario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 16);
            label1.Name = "label1";
            label1.Size = new Size(24, 17);
            label1.TabIndex = 12;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 60);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 13;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 105);
            label3.Name = "label3";
            label3.Size = new Size(40, 17);
            label3.TabIndex = 14;
            label3.Text = "Login";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(203, 105);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 15;
            label4.Text = "Senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(30, 157);
            label5.Name = "label5";
            label5.Size = new Size(43, 17);
            label5.TabIndex = 16;
            label5.Text = "E-mail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(30, 203);
            label6.Name = "label6";
            label6.Size = new Size(83, 17);
            label6.TabIndex = 17;
            label6.Text = "Observações";
            // 
            // frmUsuariosCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 353);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btFecharUsuario);
            Controls.Add(btLimparUsuario);
            Controls.Add(btPesquisarUsuario);
            Controls.Add(btRemoverUsuario);
            Controls.Add(btAtualizarUsuario);
            Controls.Add(btCadastrarUsuario);
            Controls.Add(tbObsUsuario);
            Controls.Add(tbEmailUsuario);
            Controls.Add(tbSenhaUsuario);
            Controls.Add(tbLoginUsuario);
            Controls.Add(tbNomeUsuario);
            Controls.Add(tbIdUsuario);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmUsuariosCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "::: Cadastro de Usuários :::";
            Load += frmUsuariosCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbIdUsuario;
        private TextBox tbNomeUsuario;
        private TextBox tbLoginUsuario;
        private TextBox tbSenhaUsuario;
        private TextBox tbEmailUsuario;
        private TextBox tbObsUsuario;
        private Button btCadastrarUsuario;
        private Button btAtualizarUsuario;
        private Button btRemoverUsuario;
        private Button btPesquisarUsuario;
        private Button btLimparUsuario;
        private Button btFecharUsuario;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}