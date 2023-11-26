namespace ui_wfa_SistVet
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            espéciesToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            animaisToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            btInicio = new Button();
            imageList1 = new ImageList(components);
            btAjuda = new Button();
            btSobre = new Button();
            lbNomeSistema = new Label();
            statusStrip1 = new StatusStrip();
            ssData = new ToolStripStatusLabel();
            ssDivisão = new ToolStripStatusLabel();
            ssUsuario = new ToolStripStatusLabel();
            tmPrincipal = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, relatóriosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1370, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuáriosToolStripMenuItem, espéciesToolStripMenuItem, clientesToolStripMenuItem, animaisToolStripMenuItem });
            cadastroToolStripMenuItem.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(75, 21);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(119, 22);
            usuáriosToolStripMenuItem.Text = "Usuários";
            usuáriosToolStripMenuItem.Click += usuáriosToolStripMenuItem_Click;
            // 
            // espéciesToolStripMenuItem
            // 
            espéciesToolStripMenuItem.Name = "espéciesToolStripMenuItem";
            espéciesToolStripMenuItem.Size = new Size(119, 22);
            espéciesToolStripMenuItem.Text = "Espécies";
            espéciesToolStripMenuItem.Click += espéciesToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(119, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // animaisToolStripMenuItem
            // 
            animaisToolStripMenuItem.Name = "animaisToolStripMenuItem";
            animaisToolStripMenuItem.Size = new Size(119, 22);
            animaisToolStripMenuItem.Text = "Animais";
            animaisToolStripMenuItem.Click += animaisToolStripMenuItem_Click;
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(79, 21);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // btInicio
            // 
            btInicio.Font = new Font("Kristen ITC", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btInicio.ImageKey = "osso2.jpg";
            btInicio.ImageList = imageList1;
            btInicio.Location = new Point(1198, 125);
            btInicio.Name = "btInicio";
            btInicio.Size = new Size(172, 141);
            btInicio.TabIndex = 1;
            btInicio.Text = "&Iniciar";
            btInicio.UseVisualStyleBackColor = true;
            btInicio.Click += btInicio_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "osso2.jpg");
            // 
            // btAjuda
            // 
            btAjuda.Font = new Font("Kristen ITC", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btAjuda.ImageKey = "osso2.jpg";
            btAjuda.ImageList = imageList1;
            btAjuda.Location = new Point(1198, 318);
            btAjuda.Name = "btAjuda";
            btAjuda.Size = new Size(172, 141);
            btAjuda.TabIndex = 2;
            btAjuda.Text = "&Ajuda";
            btAjuda.UseVisualStyleBackColor = true;
            btAjuda.Click += btAjuda_Click;
            // 
            // btSobre
            // 
            btSobre.Font = new Font("Kristen ITC", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btSobre.ImageKey = "osso2.jpg";
            btSobre.ImageList = imageList1;
            btSobre.Location = new Point(1198, 513);
            btSobre.Name = "btSobre";
            btSobre.Size = new Size(172, 141);
            btSobre.TabIndex = 3;
            btSobre.Text = "&Sobre";
            btSobre.UseVisualStyleBackColor = true;
            btSobre.Click += btSobre_Click;
            // 
            // lbNomeSistema
            // 
            lbNomeSistema.Location = new Point(12, 96);
            lbNomeSistema.Name = "lbNomeSistema";
            lbNomeSistema.Size = new Size(90, 644);
            lbNomeSistema.TabIndex = 4;
            lbNomeSistema.TextAlign = ContentAlignment.MiddleCenter;
            lbNomeSistema.Paint += lbNomeSistema_Paint;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { ssData, ssDivisão, ssUsuario });
            statusStrip1.Location = new Point(0, 727);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1370, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // ssData
            // 
            ssData.Name = "ssData";
            ssData.Size = new Size(0, 17);
            // 
            // ssDivisão
            // 
            ssDivisão.Name = "ssDivisão";
            ssDivisão.Size = new Size(10, 17);
            ssDivisão.Text = "|";
            // 
            // ssUsuario
            // 
            ssUsuario.Name = "ssUsuario";
            ssUsuario.Size = new Size(118, 17);
            ssUsuario.Text = "toolStripStatusLabel1";
            // 
            // tmPrincipal
            // 
            tmPrincipal.Enabled = true;
            tmPrincipal.Interval = 1000;
            tmPrincipal.Tick += tmPrincipal_Tick;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1370, 749);
            Controls.Add(statusStrip1);
            Controls.Add(lbNomeSistema);
            Controls.Add(btSobre);
            Controls.Add(btAjuda);
            Controls.Add(btInicio);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ":::SistVet::: Ronaldo Caravieri de Souza Filho R.A: G086287";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem espéciesToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem animaisToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private Button btInicio;
        private Button btAjuda;
        private Button btSobre;
        private ImageList imageList1;
        private Label lbNomeSistema;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel ssData;
        private System.Windows.Forms.Timer tmPrincipal;
        private ToolStripStatusLabel ssDivisão;
        private ToolStripStatusLabel ssUsuario;
    }
}