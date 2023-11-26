using cls_Dal;
using cls_modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui_wfa_SistVet
{
    public partial class frmUsuariosPesquisar : Form
    {
        public frmUsuariosPesquisar()
        {
            InitializeComponent();
        }

        public clsUsuarios usuarios;
        private clsUsuariosDal usuariosDal;
        public event Action<bool> BotaoClicado;
        private void carregarGrid()
        {
            dtgUsuario.DataSource = usuariosDal.listarTodosArray();
        }

        private void selecionarItem()
        {
            Int32 i = 0;

            i = dtgUsuario.CurrentRow.Index;
            usuarios.Id = Int32.Parse(dtgUsuario[0, i].Value.ToString());
            usuarios.Nome = dtgUsuario[1, i].Value.ToString();
            usuarios.Login = dtgUsuario[2, i].Value.ToString();
            usuarios.Senha = dtgUsuario[3, i].Value.ToString();
            usuarios.Email = dtgUsuario[4, i].Value.ToString();
            usuarios.Observ = dtgUsuario[5, i].Value.ToString();
        }

        private void frmUsuariosPesquisar_Load(object sender, EventArgs e)
        {
            this.usuarios = new clsUsuarios();
            this.usuariosDal = new clsUsuariosDal();
            this.carregarGrid();

            dtgUsuario.Columns["Login"].Visible = false;
            dtgUsuario.Columns["Senha"].Visible = false;
        }

        private void btSelecionarUsuario_Click(object sender, EventArgs e)
        {
            this.selecionarItem();
            BotaoClicado?.Invoke(true);
            this.Close();
        }

        private void btVoltarUsuario_Click(object sender, EventArgs e)
        {
            this.usuarios.Id = 0;
            BotaoClicado?.Invoke(false);
            this.Close();
        }
    }
}
