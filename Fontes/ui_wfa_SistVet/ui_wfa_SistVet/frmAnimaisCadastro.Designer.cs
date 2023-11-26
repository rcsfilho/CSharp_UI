namespace ui_wfa_SistVet
{
    partial class frmAnimaisCadastro
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
            tbIdAnimal = new TextBox();
            tbNomeAnimal = new TextBox();
            tbApelidoAnimal = new TextBox();
            tbDataNasc = new TextBox();
            tbObsAnimal = new TextBox();
            tbIdEspecieAnimal = new TextBox();
            lbAnimalID = new Label();
            lbNomeAnimal = new Label();
            lbApelidoAnimal = new Label();
            lbDataNascimentoAnimal = new Label();
            lbObservaçoesAnimal = new Label();
            lbIdEspecieAnimal = new Label();
            btCadastrarAnimal = new Button();
            btAlterarAnimal = new Button();
            btRemoverAnimal = new Button();
            btPesquisarAnimal = new Button();
            btLimparAnimal = new Button();
            btFecharAnimal = new Button();
            label1 = new Label();
            cbEspeciesAnimais = new ComboBox();
            SuspendLayout();
            // 
            // tbIdAnimal
            // 
            tbIdAnimal.BackColor = SystemColors.ScrollBar;
            tbIdAnimal.Enabled = false;
            tbIdAnimal.Location = new Point(24, 37);
            tbIdAnimal.Name = "tbIdAnimal";
            tbIdAnimal.Size = new Size(57, 23);
            tbIdAnimal.TabIndex = 0;
            // 
            // tbNomeAnimal
            // 
            tbNomeAnimal.Location = new Point(102, 37);
            tbNomeAnimal.Name = "tbNomeAnimal";
            tbNomeAnimal.Size = new Size(431, 23);
            tbNomeAnimal.TabIndex = 1;
            // 
            // tbApelidoAnimal
            // 
            tbApelidoAnimal.Location = new Point(24, 109);
            tbApelidoAnimal.Name = "tbApelidoAnimal";
            tbApelidoAnimal.Size = new Size(100, 23);
            tbApelidoAnimal.TabIndex = 2;
            // 
            // tbDataNasc
            // 
            tbDataNasc.Location = new Point(162, 109);
            tbDataNasc.Name = "tbDataNasc";
            tbDataNasc.Size = new Size(100, 23);
            tbDataNasc.TabIndex = 3;
            // 
            // tbObsAnimal
            // 
            tbObsAnimal.Location = new Point(24, 183);
            tbObsAnimal.Name = "tbObsAnimal";
            tbObsAnimal.Size = new Size(509, 23);
            tbObsAnimal.TabIndex = 4;
            // 
            // tbIdEspecieAnimal
            // 
            tbIdEspecieAnimal.BackColor = SystemColors.ScrollBar;
            tbIdEspecieAnimal.Enabled = false;
            tbIdEspecieAnimal.Location = new Point(295, 109);
            tbIdEspecieAnimal.Name = "tbIdEspecieAnimal";
            tbIdEspecieAnimal.Size = new Size(60, 23);
            tbIdEspecieAnimal.TabIndex = 5;
            // 
            // lbAnimalID
            // 
            lbAnimalID.AutoSize = true;
            lbAnimalID.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbAnimalID.Location = new Point(24, 16);
            lbAnimalID.Name = "lbAnimalID";
            lbAnimalID.Size = new Size(24, 17);
            lbAnimalID.TabIndex = 6;
            lbAnimalID.Text = "ID";
            // 
            // lbNomeAnimal
            // 
            lbNomeAnimal.AutoSize = true;
            lbNomeAnimal.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbNomeAnimal.Location = new Point(102, 16);
            lbNomeAnimal.Name = "lbNomeAnimal";
            lbNomeAnimal.Size = new Size(88, 17);
            lbNomeAnimal.TabIndex = 7;
            lbNomeAnimal.Text = "Nome Animal";
            // 
            // lbApelidoAnimal
            // 
            lbApelidoAnimal.AutoSize = true;
            lbApelidoAnimal.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbApelidoAnimal.Location = new Point(24, 91);
            lbApelidoAnimal.Name = "lbApelidoAnimal";
            lbApelidoAnimal.Size = new Size(54, 17);
            lbApelidoAnimal.TabIndex = 8;
            lbApelidoAnimal.Text = "Apelido";
            // 
            // lbDataNascimentoAnimal
            // 
            lbDataNascimentoAnimal.AutoSize = true;
            lbDataNascimentoAnimal.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbDataNascimentoAnimal.Location = new Point(162, 91);
            lbDataNascimentoAnimal.Name = "lbDataNascimentoAnimal";
            lbDataNascimentoAnimal.Size = new Size(110, 17);
            lbDataNascimentoAnimal.TabIndex = 9;
            lbDataNascimentoAnimal.Text = "Dta. Nascimento";
            // 
            // lbObservaçoesAnimal
            // 
            lbObservaçoesAnimal.AutoSize = true;
            lbObservaçoesAnimal.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbObservaçoesAnimal.Location = new Point(24, 165);
            lbObservaçoesAnimal.Name = "lbObservaçoesAnimal";
            lbObservaçoesAnimal.Size = new Size(83, 17);
            lbObservaçoesAnimal.TabIndex = 10;
            lbObservaçoesAnimal.Text = "Observações";
            // 
            // lbIdEspecieAnimal
            // 
            lbIdEspecieAnimal.AutoSize = true;
            lbIdEspecieAnimal.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbIdEspecieAnimal.Location = new Point(295, 91);
            lbIdEspecieAnimal.Name = "lbIdEspecieAnimal";
            lbIdEspecieAnimal.Size = new Size(73, 17);
            lbIdEspecieAnimal.TabIndex = 11;
            lbIdEspecieAnimal.Text = "ID Espécie";
            // 
            // btCadastrarAnimal
            // 
            btCadastrarAnimal.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btCadastrarAnimal.Location = new Point(24, 240);
            btCadastrarAnimal.Name = "btCadastrarAnimal";
            btCadastrarAnimal.Size = new Size(118, 23);
            btCadastrarAnimal.TabIndex = 12;
            btCadastrarAnimal.Text = "Cadastrar";
            btCadastrarAnimal.UseVisualStyleBackColor = true;
            btCadastrarAnimal.Click += btCadastrarAnimal_Click;
            // 
            // btAlterarAnimal
            // 
            btAlterarAnimal.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btAlterarAnimal.Location = new Point(225, 240);
            btAlterarAnimal.Name = "btAlterarAnimal";
            btAlterarAnimal.Size = new Size(119, 23);
            btAlterarAnimal.TabIndex = 13;
            btAlterarAnimal.Text = "Alterar";
            btAlterarAnimal.UseVisualStyleBackColor = true;
            btAlterarAnimal.Click += btAlterarAnimal_Click;
            // 
            // btRemoverAnimal
            // 
            btRemoverAnimal.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btRemoverAnimal.Location = new Point(416, 240);
            btRemoverAnimal.Name = "btRemoverAnimal";
            btRemoverAnimal.Size = new Size(117, 23);
            btRemoverAnimal.TabIndex = 14;
            btRemoverAnimal.Text = "Remover";
            btRemoverAnimal.UseVisualStyleBackColor = true;
            btRemoverAnimal.Click += btRemoverAnimal_Click;
            // 
            // btPesquisarAnimal
            // 
            btPesquisarAnimal.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btPesquisarAnimal.Location = new Point(24, 292);
            btPesquisarAnimal.Name = "btPesquisarAnimal";
            btPesquisarAnimal.Size = new Size(118, 23);
            btPesquisarAnimal.TabIndex = 15;
            btPesquisarAnimal.Text = "Pesquisar";
            btPesquisarAnimal.UseVisualStyleBackColor = true;
            btPesquisarAnimal.Click += btPesquisarAnimal_Click;
            // 
            // btLimparAnimal
            // 
            btLimparAnimal.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btLimparAnimal.Location = new Point(225, 292);
            btLimparAnimal.Name = "btLimparAnimal";
            btLimparAnimal.Size = new Size(119, 23);
            btLimparAnimal.TabIndex = 16;
            btLimparAnimal.Text = "Limpar";
            btLimparAnimal.UseVisualStyleBackColor = true;
            btLimparAnimal.Click += btLimparAnimal_Click;
            // 
            // btFecharAnimal
            // 
            btFecharAnimal.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btFecharAnimal.Location = new Point(416, 292);
            btFecharAnimal.Name = "btFecharAnimal";
            btFecharAnimal.Size = new Size(117, 23);
            btFecharAnimal.TabIndex = 17;
            btFecharAnimal.Text = "Fechar";
            btFecharAnimal.UseVisualStyleBackColor = true;
            btFecharAnimal.Click += btFecharAnimal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(381, 91);
            label1.Name = "label1";
            label1.Size = new Size(115, 17);
            label1.TabIndex = 19;
            label1.Text = "Lista de Espécies ";
            // 
            // cbEspeciesAnimais
            // 
            cbEspeciesAnimais.FormattingEnabled = true;
            cbEspeciesAnimais.Location = new Point(381, 109);
            cbEspeciesAnimais.Name = "cbEspeciesAnimais";
            cbEspeciesAnimais.Size = new Size(152, 23);
            cbEspeciesAnimais.TabIndex = 21;
            cbEspeciesAnimais.SelectedIndexChanged += cbEspeciesAnimais_SelectedIndexChanged;
            // 
            // frmAnimaisCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 343);
            Controls.Add(cbEspeciesAnimais);
            Controls.Add(label1);
            Controls.Add(btFecharAnimal);
            Controls.Add(btLimparAnimal);
            Controls.Add(btPesquisarAnimal);
            Controls.Add(btRemoverAnimal);
            Controls.Add(btAlterarAnimal);
            Controls.Add(btCadastrarAnimal);
            Controls.Add(lbIdEspecieAnimal);
            Controls.Add(lbObservaçoesAnimal);
            Controls.Add(lbDataNascimentoAnimal);
            Controls.Add(lbApelidoAnimal);
            Controls.Add(lbNomeAnimal);
            Controls.Add(lbAnimalID);
            Controls.Add(tbIdEspecieAnimal);
            Controls.Add(tbObsAnimal);
            Controls.Add(tbDataNasc);
            Controls.Add(tbApelidoAnimal);
            Controls.Add(tbNomeAnimal);
            Controls.Add(tbIdAnimal);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmAnimaisCadastro";
            StartPosition = FormStartPosition.CenterParent;
            Text = ":::Animais:::";
            Load += frmAnimaisCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbIdAnimal;
        private TextBox tbNomeAnimal;
        private TextBox tbApelidoAnimal;
        private TextBox tbDataNasc;
        private TextBox tbObsAnimal;
        private TextBox tbIdEspecieAnimal;
        private Label lbAnimalID;
        private Label lbNomeAnimal;
        private Label lbApelidoAnimal;
        private Label lbDataNascimentoAnimal;
        private Label lbObservaçoesAnimal;
        private Label lbIdEspecieAnimal;
        private Button btCadastrarAnimal;
        private Button btAlterarAnimal;
        private Button btRemoverAnimal;
        private Button btPesquisarAnimal;
        private Button btLimparAnimal;
        private Button btFecharAnimal;
        private Label label1;
        private ComboBox cbEspeciesAnimais;
    }
}