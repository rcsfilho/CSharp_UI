namespace ui_wfa_SistVet
{
    partial class frmClientesPesquisar
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
            dataGridClientes = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            CPF = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            DataCadastro = new DataGridViewTextBoxColumn();
            btVoltarClientes = new Button();
            btSelecionarClientes = new Button();
            lbClientesPesquisar = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).BeginInit();
            SuspendLayout();
            // 
            // dataGridClientes
            // 
            dataGridClientes.AllowUserToAddRows = false;
            dataGridClientes.AllowUserToDeleteRows = false;
            dataGridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClientes.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, CPF, Email, DataCadastro });
            dataGridClientes.Location = new Point(12, 27);
            dataGridClientes.Name = "dataGridClientes";
            dataGridClientes.ReadOnly = true;
            dataGridClientes.RowTemplate.Height = 25;
            dataGridClientes.Size = new Size(604, 287);
            dataGridClientes.TabIndex = 0;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 60;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 150;
            // 
            // CPF
            // 
            CPF.DataPropertyName = "CPF";
            CPF.HeaderText = "CPF";
            CPF.Name = "CPF";
            CPF.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "E-mail";
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 150;
            // 
            // DataCadastro
            // 
            DataCadastro.DataPropertyName = "DataCadastro";
            DataCadastro.HeaderText = "Data de Cadastro";
            DataCadastro.Name = "DataCadastro";
            DataCadastro.ReadOnly = true;
            // 
            // btVoltarClientes
            // 
            btVoltarClientes.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btVoltarClientes.Location = new Point(541, 320);
            btVoltarClientes.Name = "btVoltarClientes";
            btVoltarClientes.Size = new Size(75, 23);
            btVoltarClientes.TabIndex = 1;
            btVoltarClientes.Text = "Voltar";
            btVoltarClientes.UseVisualStyleBackColor = true;
            btVoltarClientes.Click += btVoltarClientes_Click;
            // 
            // btSelecionarClientes
            // 
            btSelecionarClientes.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btSelecionarClientes.Location = new Point(445, 320);
            btSelecionarClientes.Name = "btSelecionarClientes";
            btSelecionarClientes.Size = new Size(90, 23);
            btSelecionarClientes.TabIndex = 2;
            btSelecionarClientes.Text = "Selecionar";
            btSelecionarClientes.UseVisualStyleBackColor = true;
            btSelecionarClientes.Click += btSelecionarClientes_Click;
            // 
            // lbClientesPesquisar
            // 
            lbClientesPesquisar.AutoSize = true;
            lbClientesPesquisar.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbClientesPesquisar.Location = new Point(12, 9);
            lbClientesPesquisar.Name = "lbClientesPesquisar";
            lbClientesPesquisar.Size = new Size(56, 17);
            lbClientesPesquisar.TabIndex = 3;
            lbClientesPesquisar.Text = "Clientes";
            // 
            // frmClientesPesquisar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 355);
            Controls.Add(lbClientesPesquisar);
            Controls.Add(btSelecionarClientes);
            Controls.Add(btVoltarClientes);
            Controls.Add(dataGridClientes);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmClientesPesquisar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ":::Clientes - Pesquisa:::";
            Load += frmClientesPesquisar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridClientes;
        private Button btVoltarClientes;
        private Button btSelecionarClientes;
        private Label lbClientesPesquisar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn CPF;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn DataCadastro;
    }
}