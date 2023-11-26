namespace ui_wfa_SistVet
{
    partial class frmAnimaisPesquisar
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
            dataGridAnimais = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Apelido = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            Obs = new DataGridViewTextBoxColumn();
            AniEspeciesId = new DataGridViewTextBoxColumn();
            btVoltarPesquisaAnimais = new Button();
            btSelecionarAnimais = new Button();
            lbAnimaisPesquisar = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridAnimais).BeginInit();
            SuspendLayout();
            // 
            // dataGridAnimais
            // 
            dataGridAnimais.AllowUserToAddRows = false;
            dataGridAnimais.AllowUserToDeleteRows = false;
            dataGridAnimais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAnimais.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Apelido, Data, Obs, AniEspeciesId });
            dataGridAnimais.Location = new Point(12, 23);
            dataGridAnimais.Name = "dataGridAnimais";
            dataGridAnimais.ReadOnly = true;
            dataGridAnimais.RowTemplate.Height = 25;
            dataGridAnimais.Size = new Size(732, 323);
            dataGridAnimais.TabIndex = 0;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id Animal";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 75;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.FillWeight = 120F;
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 120;
            // 
            // Apelido
            // 
            Apelido.DataPropertyName = "Apelido";
            Apelido.FillWeight = 120F;
            Apelido.HeaderText = "Apelido";
            Apelido.Name = "Apelido";
            Apelido.ReadOnly = true;
            Apelido.Width = 120;
            // 
            // Data
            // 
            Data.DataPropertyName = "Data";
            Data.HeaderText = "Dta. Nasc.";
            Data.Name = "Data";
            Data.ReadOnly = true;
            Data.Width = 98;
            // 
            // Obs
            // 
            Obs.DataPropertyName = "Obs";
            Obs.FillWeight = 150F;
            Obs.HeaderText = "Observações";
            Obs.Name = "Obs";
            Obs.ReadOnly = true;
            Obs.Width = 200;
            // 
            // AniEspeciesId
            // 
            AniEspeciesId.DataPropertyName = "AniEspeciesId";
            AniEspeciesId.HeaderText = "Id - Espécie";
            AniEspeciesId.Name = "AniEspeciesId";
            AniEspeciesId.ReadOnly = true;
            AniEspeciesId.Width = 75;
            // 
            // btVoltarPesquisaAnimais
            // 
            btVoltarPesquisaAnimais.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btVoltarPesquisaAnimais.Location = new Point(659, 352);
            btVoltarPesquisaAnimais.Name = "btVoltarPesquisaAnimais";
            btVoltarPesquisaAnimais.Size = new Size(85, 23);
            btVoltarPesquisaAnimais.TabIndex = 1;
            btVoltarPesquisaAnimais.Text = "Voltar";
            btVoltarPesquisaAnimais.UseVisualStyleBackColor = true;
            btVoltarPesquisaAnimais.Click += btVoltarPesquisaAnimais_Click;
            // 
            // btSelecionarAnimais
            // 
            btSelecionarAnimais.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btSelecionarAnimais.Location = new Point(568, 352);
            btSelecionarAnimais.Name = "btSelecionarAnimais";
            btSelecionarAnimais.Size = new Size(85, 23);
            btSelecionarAnimais.TabIndex = 2;
            btSelecionarAnimais.Text = "Selecionar";
            btSelecionarAnimais.UseVisualStyleBackColor = true;
            btSelecionarAnimais.Click += btSelecionarAnimais_Click;
            // 
            // lbAnimaisPesquisar
            // 
            lbAnimaisPesquisar.AutoSize = true;
            lbAnimaisPesquisar.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbAnimaisPesquisar.Location = new Point(12, 5);
            lbAnimaisPesquisar.Name = "lbAnimaisPesquisar";
            lbAnimaisPesquisar.Size = new Size(54, 17);
            lbAnimaisPesquisar.TabIndex = 3;
            lbAnimaisPesquisar.Text = "Animais";
            // 
            // frmAnimaisPesquisar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 390);
            Controls.Add(lbAnimaisPesquisar);
            Controls.Add(btSelecionarAnimais);
            Controls.Add(btVoltarPesquisaAnimais);
            Controls.Add(dataGridAnimais);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "frmAnimaisPesquisar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ":::Pesquisar - Animais:::";
            Load += frmAnimaisPesquisar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridAnimais).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridAnimais;
        private Button btVoltarPesquisaAnimais;
        private Button btSelecionarAnimais;
        private Label lbAnimaisPesquisar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Apelido;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Obs;
        private DataGridViewTextBoxColumn AniEspeciesId;
    }
}