namespace ui_wfa_SistVet
{
    partial class frmClientesCadastro
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
            tbIDCliente = new TextBox();
            tbNomeCliente = new TextBox();
            tbCPFCliente = new TextBox();
            tbEmailCliente = new TextBox();
            tbDataCadastro = new TextBox();
            lbIdCliente = new Label();
            lbNomeCliente = new Label();
            lbCPFCliente = new Label();
            lbEmailCliente = new Label();
            lbDataCadastroCliente = new Label();
            btCadastrarCliente = new Button();
            btAlterarCliente = new Button();
            btRemoverCliente = new Button();
            btPesquisarCliente = new Button();
            btLimparClientes = new Button();
            btFecharFrmClientes = new Button();
            dgDonosAnimais = new DataGridView();
            ClienteId = new DataGridViewTextBoxColumn();
            ClienteNome = new DataGridViewTextBoxColumn();
            AnimalId = new DataGridViewTextBoxColumn();
            AnimalNome = new DataGridViewTextBoxColumn();
            tbIdentificaçãoAnimal = new TextBox();
            lbAnimaisClientes = new Label();
            label1 = new Label();
            lbAnimaisDonos = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dgDonosAnimais).BeginInit();
            SuspendLayout();
            // 
            // tbIDCliente
            // 
            tbIDCliente.BackColor = SystemColors.ScrollBar;
            tbIDCliente.Enabled = false;
            tbIDCliente.Location = new Point(33, 27);
            tbIDCliente.Name = "tbIDCliente";
            tbIDCliente.Size = new Size(40, 23);
            tbIDCliente.TabIndex = 0;
            // 
            // tbNomeCliente
            // 
            tbNomeCliente.Location = new Point(79, 27);
            tbNomeCliente.Name = "tbNomeCliente";
            tbNomeCliente.Size = new Size(527, 23);
            tbNomeCliente.TabIndex = 1;
            // 
            // tbCPFCliente
            // 
            tbCPFCliente.Location = new Point(33, 78);
            tbCPFCliente.Name = "tbCPFCliente";
            tbCPFCliente.Size = new Size(179, 23);
            tbCPFCliente.TabIndex = 2;
            // 
            // tbEmailCliente
            // 
            tbEmailCliente.Location = new Point(219, 78);
            tbEmailCliente.Name = "tbEmailCliente";
            tbEmailCliente.Size = new Size(217, 23);
            tbEmailCliente.TabIndex = 3;
            // 
            // tbDataCadastro
            // 
            tbDataCadastro.Location = new Point(442, 78);
            tbDataCadastro.Name = "tbDataCadastro";
            tbDataCadastro.Size = new Size(164, 23);
            tbDataCadastro.TabIndex = 4;
            // 
            // lbIdCliente
            // 
            lbIdCliente.AutoSize = true;
            lbIdCliente.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbIdCliente.Location = new Point(33, 9);
            lbIdCliente.Name = "lbIdCliente";
            lbIdCliente.Size = new Size(24, 17);
            lbIdCliente.TabIndex = 5;
            lbIdCliente.Text = "ID";
            // 
            // lbNomeCliente
            // 
            lbNomeCliente.AutoSize = true;
            lbNomeCliente.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbNomeCliente.Location = new Point(79, 9);
            lbNomeCliente.Name = "lbNomeCliente";
            lbNomeCliente.Size = new Size(47, 17);
            lbNomeCliente.TabIndex = 6;
            lbNomeCliente.Text = "Nome ";
            // 
            // lbCPFCliente
            // 
            lbCPFCliente.AutoSize = true;
            lbCPFCliente.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbCPFCliente.Location = new Point(33, 60);
            lbCPFCliente.Name = "lbCPFCliente";
            lbCPFCliente.Size = new Size(33, 17);
            lbCPFCliente.TabIndex = 7;
            lbCPFCliente.Text = "CPF";
            // 
            // lbEmailCliente
            // 
            lbEmailCliente.AutoSize = true;
            lbEmailCliente.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbEmailCliente.Location = new Point(223, 60);
            lbEmailCliente.Name = "lbEmailCliente";
            lbEmailCliente.Size = new Size(43, 17);
            lbEmailCliente.TabIndex = 8;
            lbEmailCliente.Text = "E-mail";
            // 
            // lbDataCadastroCliente
            // 
            lbDataCadastroCliente.AutoSize = true;
            lbDataCadastroCliente.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbDataCadastroCliente.Location = new Point(456, 60);
            lbDataCadastroCliente.Name = "lbDataCadastroCliente";
            lbDataCadastroCliente.Size = new Size(98, 17);
            lbDataCadastroCliente.TabIndex = 9;
            lbDataCadastroCliente.Text = "Data Cadastro";
            // 
            // btCadastrarCliente
            // 
            btCadastrarCliente.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btCadastrarCliente.Location = new Point(33, 189);
            btCadastrarCliente.Name = "btCadastrarCliente";
            btCadastrarCliente.Size = new Size(179, 23);
            btCadastrarCliente.TabIndex = 10;
            btCadastrarCliente.Text = "Cadastrar";
            btCadastrarCliente.UseVisualStyleBackColor = true;
            btCadastrarCliente.Click += btCadastrarCliente_Click;
            // 
            // btAlterarCliente
            // 
            btAlterarCliente.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btAlterarCliente.Location = new Point(219, 189);
            btAlterarCliente.Name = "btAlterarCliente";
            btAlterarCliente.Size = new Size(217, 23);
            btAlterarCliente.TabIndex = 11;
            btAlterarCliente.Text = "Alterar";
            btAlterarCliente.UseVisualStyleBackColor = true;
            btAlterarCliente.Click += btAlterarCliente_Click;
            // 
            // btRemoverCliente
            // 
            btRemoverCliente.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btRemoverCliente.Location = new Point(442, 189);
            btRemoverCliente.Name = "btRemoverCliente";
            btRemoverCliente.Size = new Size(164, 23);
            btRemoverCliente.TabIndex = 12;
            btRemoverCliente.Text = "Remover";
            btRemoverCliente.UseVisualStyleBackColor = true;
            btRemoverCliente.Click += btRemoverCliente_Click;
            // 
            // btPesquisarCliente
            // 
            btPesquisarCliente.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btPesquisarCliente.Location = new Point(33, 239);
            btPesquisarCliente.Name = "btPesquisarCliente";
            btPesquisarCliente.Size = new Size(179, 23);
            btPesquisarCliente.TabIndex = 13;
            btPesquisarCliente.Text = "Pesquisar";
            btPesquisarCliente.UseVisualStyleBackColor = true;
            btPesquisarCliente.Click += btPesquisarCliente_Click;
            // 
            // btLimparClientes
            // 
            btLimparClientes.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btLimparClientes.Location = new Point(219, 239);
            btLimparClientes.Name = "btLimparClientes";
            btLimparClientes.Size = new Size(217, 23);
            btLimparClientes.TabIndex = 14;
            btLimparClientes.Text = "Limpar";
            btLimparClientes.UseVisualStyleBackColor = true;
            btLimparClientes.Click += btLimparClientes_Click;
            // 
            // btFecharFrmClientes
            // 
            btFecharFrmClientes.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btFecharFrmClientes.Location = new Point(442, 239);
            btFecharFrmClientes.Name = "btFecharFrmClientes";
            btFecharFrmClientes.Size = new Size(164, 23);
            btFecharFrmClientes.TabIndex = 15;
            btFecharFrmClientes.Text = "Fechar";
            btFecharFrmClientes.UseVisualStyleBackColor = true;
            btFecharFrmClientes.Click += btFecharFrmClientes_Click;
            // 
            // dgDonosAnimais
            // 
            dgDonosAnimais.AllowUserToAddRows = false;
            dgDonosAnimais.AllowUserToDeleteRows = false;
            dgDonosAnimais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDonosAnimais.Columns.AddRange(new DataGridViewColumn[] { ClienteId, ClienteNome, AnimalId, AnimalNome });
            dgDonosAnimais.Location = new Point(33, 283);
            dgDonosAnimais.Name = "dgDonosAnimais";
            dgDonosAnimais.ReadOnly = true;
            dgDonosAnimais.RowTemplate.Height = 25;
            dgDonosAnimais.Size = new Size(573, 213);
            dgDonosAnimais.TabIndex = 16;
            // 
            // ClienteId
            // 
            ClienteId.DataPropertyName = "ClienteId";
            ClienteId.HeaderText = "ID Cliente";
            ClienteId.Name = "ClienteId";
            ClienteId.ReadOnly = true;
            // 
            // ClienteNome
            // 
            ClienteNome.DataPropertyName = "ClienteNome";
            ClienteNome.HeaderText = "Nome Cliente";
            ClienteNome.Name = "ClienteNome";
            ClienteNome.ReadOnly = true;
            ClienteNome.Width = 165;
            // 
            // AnimalId
            // 
            AnimalId.DataPropertyName = "AnimalId";
            AnimalId.HeaderText = "ID Animal";
            AnimalId.Name = "AnimalId";
            AnimalId.ReadOnly = true;
            // 
            // AnimalNome
            // 
            AnimalNome.DataPropertyName = "AnimalNome";
            AnimalNome.HeaderText = "Nome Animal";
            AnimalNome.Name = "AnimalNome";
            AnimalNome.ReadOnly = true;
            AnimalNome.Width = 165;
            // 
            // tbIdentificaçãoAnimal
            // 
            tbIdentificaçãoAnimal.BackColor = SystemColors.ScrollBar;
            tbIdentificaçãoAnimal.Enabled = false;
            tbIdentificaçãoAnimal.Location = new Point(219, 135);
            tbIdentificaçãoAnimal.Name = "tbIdentificaçãoAnimal";
            tbIdentificaçãoAnimal.Size = new Size(96, 23);
            tbIdentificaçãoAnimal.TabIndex = 18;
            // 
            // lbAnimaisClientes
            // 
            lbAnimaisClientes.AutoSize = true;
            lbAnimaisClientes.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbAnimaisClientes.Location = new Point(34, 115);
            lbAnimaisClientes.Name = "lbAnimaisClientes";
            lbAnimaisClientes.Size = new Size(119, 17);
            lbAnimaisClientes.TabIndex = 19;
            lbAnimaisClientes.Text = "Selecione o Animal";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(219, 117);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 20;
            label1.Text = "Nº Animal";
            // 
            // lbAnimaisDonos
            // 
            lbAnimaisDonos.FormattingEnabled = true;
            lbAnimaisDonos.ItemHeight = 15;
            lbAnimaisDonos.Location = new Point(33, 133);
            lbAnimaisDonos.Name = "lbAnimaisDonos";
            lbAnimaisDonos.Size = new Size(179, 34);
            lbAnimaisDonos.TabIndex = 21;
            lbAnimaisDonos.SelectedIndexChanged += lbAnimaisDonos_SelectedIndexChanged;
            // 
            // frmClientesCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 521);
            Controls.Add(lbAnimaisDonos);
            Controls.Add(label1);
            Controls.Add(lbAnimaisClientes);
            Controls.Add(tbIdentificaçãoAnimal);
            Controls.Add(dgDonosAnimais);
            Controls.Add(btFecharFrmClientes);
            Controls.Add(btLimparClientes);
            Controls.Add(btPesquisarCliente);
            Controls.Add(btRemoverCliente);
            Controls.Add(btAlterarCliente);
            Controls.Add(btCadastrarCliente);
            Controls.Add(lbDataCadastroCliente);
            Controls.Add(lbEmailCliente);
            Controls.Add(lbCPFCliente);
            Controls.Add(lbNomeCliente);
            Controls.Add(lbIdCliente);
            Controls.Add(tbDataCadastro);
            Controls.Add(tbEmailCliente);
            Controls.Add(tbCPFCliente);
            Controls.Add(tbNomeCliente);
            Controls.Add(tbIDCliente);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmClientesCadastro";
            StartPosition = FormStartPosition.CenterParent;
            Text = ":::Clientes:::";
            Load += frmClientesCadastro_Load;
            ((System.ComponentModel.ISupportInitialize)dgDonosAnimais).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbIDCliente;
        private TextBox tbNomeCliente;
        private TextBox tbCPFCliente;
        private TextBox tbEmailCliente;
        private TextBox tbDataCadastro;
        private Label lbIdCliente;
        private Label lbNomeCliente;
        private Label lbCPFCliente;
        private Label lbEmailCliente;
        private Label lbDataCadastroCliente;
        private Button btCadastrarCliente;
        private Button btAlterarCliente;
        private Button btRemoverCliente;
        private Button btPesquisarCliente;
        private Button btLimparClientes;
        private Button btFecharFrmClientes;
        private DataGridView dgDonosAnimais;
        private DataGridViewTextBoxColumn ClienteId;
        private DataGridViewTextBoxColumn ClienteNome;
        private DataGridViewTextBoxColumn AnimalId;
        private DataGridViewTextBoxColumn AnimalNome;
        private TextBox tbIdentificaçãoAnimal;
        private Label lbAnimaisClientes;
        private Label label1;
        private ListBox lbAnimaisDonos;
    }
}