namespace ui_wfa_SistVet
{
    partial class frmEspeciesCadastro
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
            tbEspecieId = new TextBox();
            tbEspecieNome = new TextBox();
            lbIdEspécie = new Label();
            lbNomeEspécie = new Label();
            btCadastrarEspécie = new Button();
            btAlterarEspécie = new Button();
            btExcluirEspecie = new Button();
            tbSelecionarEspécie = new Button();
            btLimparFrmEspecie = new Button();
            btFecharEspécie = new Button();
            dataGridEspecie = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            lbEspeciesCadastradas = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridEspecie).BeginInit();
            SuspendLayout();
            // 
            // tbEspecieId
            // 
            tbEspecieId.BackColor = SystemColors.ScrollBar;
            tbEspecieId.Enabled = false;
            tbEspecieId.Location = new Point(45, 51);
            tbEspecieId.Name = "tbEspecieId";
            tbEspecieId.Size = new Size(100, 23);
            tbEspecieId.TabIndex = 0;
            // 
            // tbEspecieNome
            // 
            tbEspecieNome.Location = new Point(166, 51);
            tbEspecieNome.Name = "tbEspecieNome";
            tbEspecieNome.Size = new Size(100, 23);
            tbEspecieNome.TabIndex = 1;
            // 
            // lbIdEspécie
            // 
            lbIdEspécie.AutoSize = true;
            lbIdEspécie.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbIdEspécie.Location = new Point(50, 31);
            lbIdEspécie.Name = "lbIdEspécie";
            lbIdEspécie.Size = new Size(73, 17);
            lbIdEspécie.TabIndex = 2;
            lbIdEspécie.Text = "ID Espécie";
            // 
            // lbNomeEspécie
            // 
            lbNomeEspécie.AutoSize = true;
            lbNomeEspécie.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbNomeEspécie.Location = new Point(166, 31);
            lbNomeEspécie.Name = "lbNomeEspécie";
            lbNomeEspécie.Size = new Size(92, 17);
            lbNomeEspécie.TabIndex = 3;
            lbNomeEspécie.Text = "Nome Espécie";
            // 
            // btCadastrarEspécie
            // 
            btCadastrarEspécie.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btCadastrarEspécie.Location = new Point(45, 106);
            btCadastrarEspécie.Name = "btCadastrarEspécie";
            btCadastrarEspécie.Size = new Size(100, 23);
            btCadastrarEspécie.TabIndex = 4;
            btCadastrarEspécie.Text = "Cadastrar";
            btCadastrarEspécie.UseVisualStyleBackColor = true;
            btCadastrarEspécie.Click += btCadastrarEspécie_Click;
            // 
            // btAlterarEspécie
            // 
            btAlterarEspécie.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btAlterarEspécie.Location = new Point(166, 106);
            btAlterarEspécie.Name = "btAlterarEspécie";
            btAlterarEspécie.Size = new Size(100, 23);
            btAlterarEspécie.TabIndex = 5;
            btAlterarEspécie.Text = "Alterar";
            btAlterarEspécie.UseVisualStyleBackColor = true;
            btAlterarEspécie.Click += btAlterarEspécie_Click;
            // 
            // btExcluirEspecie
            // 
            btExcluirEspecie.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btExcluirEspecie.Location = new Point(45, 166);
            btExcluirEspecie.Name = "btExcluirEspecie";
            btExcluirEspecie.Size = new Size(100, 23);
            btExcluirEspecie.TabIndex = 6;
            btExcluirEspecie.Text = "Remover";
            btExcluirEspecie.UseVisualStyleBackColor = true;
            btExcluirEspecie.Click += btExcluirEspecie_Click;
            // 
            // tbSelecionarEspécie
            // 
            tbSelecionarEspécie.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbSelecionarEspécie.Location = new Point(166, 166);
            tbSelecionarEspécie.Name = "tbSelecionarEspécie";
            tbSelecionarEspécie.Size = new Size(100, 23);
            tbSelecionarEspécie.TabIndex = 7;
            tbSelecionarEspécie.Text = "Selecionar";
            tbSelecionarEspécie.UseVisualStyleBackColor = true;
            tbSelecionarEspécie.Click += tbSelecionarEspécie_Click;
            // 
            // btLimparFrmEspecie
            // 
            btLimparFrmEspecie.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btLimparFrmEspecie.Location = new Point(45, 223);
            btLimparFrmEspecie.Name = "btLimparFrmEspecie";
            btLimparFrmEspecie.Size = new Size(100, 23);
            btLimparFrmEspecie.TabIndex = 8;
            btLimparFrmEspecie.Text = "Limpar";
            btLimparFrmEspecie.UseVisualStyleBackColor = true;
            btLimparFrmEspecie.Click += btLimparFrmEspecie_Click;
            // 
            // btFecharEspécie
            // 
            btFecharEspécie.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btFecharEspécie.Location = new Point(166, 223);
            btFecharEspécie.Name = "btFecharEspécie";
            btFecharEspécie.Size = new Size(100, 23);
            btFecharEspécie.TabIndex = 9;
            btFecharEspécie.Text = "Fechar";
            btFecharEspécie.UseVisualStyleBackColor = true;
            btFecharEspécie.Click += btFecharEspécie_Click;
            // 
            // dataGridEspecie
            // 
            dataGridEspecie.AllowUserToAddRows = false;
            dataGridEspecie.AllowUserToDeleteRows = false;
            dataGridEspecie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEspecie.Columns.AddRange(new DataGridViewColumn[] { Id, Nome });
            dataGridEspecie.Location = new Point(329, 51);
            dataGridEspecie.Name = "dataGridEspecie";
            dataGridEspecie.ReadOnly = true;
            dataGridEspecie.RowTemplate.Height = 25;
            dataGridEspecie.Size = new Size(270, 195);
            dataGridEspecie.TabIndex = 10;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id - Espécie";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 75;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome Espécie";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 150;
            // 
            // lbEspeciesCadastradas
            // 
            lbEspeciesCadastradas.AutoSize = true;
            lbEspeciesCadastradas.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbEspeciesCadastradas.Location = new Point(329, 31);
            lbEspeciesCadastradas.Name = "lbEspeciesCadastradas";
            lbEspeciesCadastradas.Size = new Size(137, 17);
            lbEspeciesCadastradas.TabIndex = 11;
            lbEspeciesCadastradas.Text = "Espécies Cadastradas";
            // 
            // frmEspeciesCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 340);
            Controls.Add(lbEspeciesCadastradas);
            Controls.Add(dataGridEspecie);
            Controls.Add(btFecharEspécie);
            Controls.Add(btLimparFrmEspecie);
            Controls.Add(tbSelecionarEspécie);
            Controls.Add(btExcluirEspecie);
            Controls.Add(btAlterarEspécie);
            Controls.Add(btCadastrarEspécie);
            Controls.Add(lbNomeEspécie);
            Controls.Add(lbIdEspécie);
            Controls.Add(tbEspecieNome);
            Controls.Add(tbEspecieId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmEspeciesCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ":::Espécies:::";
            Load += frmEspeciesCadastro_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridEspecie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbEspecieId;
        private TextBox tbEspecieNome;
        private Label lbIdEspécie;
        private Label lbNomeEspécie;
        private Button btCadastrarEspécie;
        private Button btAlterarEspécie;
        private Button btExcluirEspecie;
        private Button tbSelecionarEspécie;
        private Button btLimparFrmEspecie;
        private Button btFecharEspécie;
        private DataGridView dataGridEspecie;
        private Label lbEspeciesCadastradas;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
    }
}