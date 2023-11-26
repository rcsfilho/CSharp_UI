using Microsoft.Win32;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ui_wfa_SistVet
{
    public partial class frmPrincipal : Form
    {
        public static string NomeUsuario { get; set; }
        public frmPrincipal()
        {
            InitializeComponent();

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile(@"C:\Users\Usuário\Documents\Unip - Curso 3 semestre\Programação OO II\Fotos para projeto\cheetos.jpg");
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage; // Ajuste o modo conforme necessário

            this.Controls.Add(pictureBox);

        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientesCadastro clientes = new frmClientesCadastro();
            clientes.ShowDialog();
        }

        private void animaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnimaisCadastro animais = new frmAnimaisCadastro();
            animais.ShowDialog();
        }

        private void espéciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEspeciesCadastro especie = new frmEspeciesCadastro();
            especie.ShowDialog();

        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuariosCadastro usuarios = new frmUsuariosCadastro();
            usuarios.ShowDialog();
        }

        private void btInicio_Click(object sender, EventArgs e)
        {
            cadastroToolStripMenuItem.ShowDropDown();
        }

        private void btSobre_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.ShowDialog();
        }

        private void lbNomeSistema_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Kristen ITC;", 30);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(20, 530);
            e.Graphics.RotateTransform(-90);
            e.Graphics.DrawString("SistVet - Sistema Veterinário", myfont, mybrush, 0, 0);
        }

        private void tmPrincipal_Tick(object sender, EventArgs e)
        {
            ssData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Verifique se o NomeUsuario foi definido em frmAcesso
            if (!string.IsNullOrEmpty(NomeUsuario))
            {
                ssUsuario.Text = "Usuário: " + NomeUsuario;
            }
        }

        private void btAjuda_Click(object sender, EventArgs e)
        {
            frmAjuda ajuda = new frmAjuda();
            ajuda.ShowDialog();
        }
    }
}
