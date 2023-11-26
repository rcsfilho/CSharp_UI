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
    public partial class frmUsuariosCadastro : Form
    {
        private frmUsuariosPesquisar pesq;
        public frmUsuariosCadastro()
        {
            InitializeComponent();

            pesq = new frmUsuariosPesquisar(); // Crie uma instância aqui

            // Inscreva-se para o evento BotaoClicado
            pesq.BotaoClicado += (selecionado) =>
            {
                if (selecionado)
                {
                    this.ativarEdicao();
                }
                else
                {
                    this.ativarFormulario();
                }
            };
        }


        private void ativarFormulario()
        {
            btCadastrarUsuario.Enabled = true;
            btAtualizarUsuario.Enabled = false;
            btRemoverUsuario.Enabled = false;
            btPesquisarUsuario.Enabled = true;
            btLimparUsuario.Enabled = true;
            btFecharUsuario.Enabled = true;
        }

        private void ativarEdicao()
        {
            btCadastrarUsuario.Enabled = false;
            btAtualizarUsuario.Enabled = true;
            btRemoverUsuario.Enabled = true;
            btPesquisarUsuario.Enabled = true;
            btLimparUsuario.Enabled = true;
            btFecharUsuario.Enabled = true;
        }


        private void btCadastrarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNomeUsuario.Text) || string.IsNullOrEmpty(tbLoginUsuario.Text) || string.IsNullOrEmpty(tbSenhaUsuario.Text) || string.IsNullOrEmpty(tbEmailUsuario.Text))
            {
                MessageBox.Show("Certifique-se de preencher todos os campos obrigatórios: Nome, Login, Senha e Email.");
                return;
            }

            if (tbSenhaUsuario.Text.Length < 8 || !tbSenhaUsuario.Text.Any(char.IsUpper) || !tbSenhaUsuario.Text.Any(char.IsLower) || !tbSenhaUsuario.Text.Any(char.IsDigit))
            {
                MessageBox.Show("A senha deve ter pelo menos 8 caracteres e conter letras maiúsculas, minúsculas e números.");
                return;
            }

            clsUsuarios usuarios = new clsUsuarios();
            usuarios.Nome = tbNomeUsuario.Text;
            usuarios.Login = tbLoginUsuario.Text;
            usuarios.Senha = tbSenhaUsuario.Text;
            usuarios.Email = tbEmailUsuario.Text;
            usuarios.Observ = tbObsUsuario.Text;

            clsUsuariosDal usuariosDal = new clsUsuariosDal();
            usuariosDal.Inserir(usuarios);
            MessageBox.Show("Usuário cadastrado com sucesso!");
        }

        private void btAtualizarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbIdUsuario.Text) || !int.TryParse(tbIdUsuario.Text, out int idUsuario))
            {
                MessageBox.Show("Certifique-se de preencher o campo de ID do Usuário com um valor numérico válido.");
                return;
            }

            if (string.IsNullOrEmpty(tbNomeUsuario.Text) || string.IsNullOrEmpty(tbLoginUsuario.Text) || string.IsNullOrEmpty(tbEmailUsuario.Text))
            {
                MessageBox.Show("Certifique-se de preencher todos os campos obrigatórios: Nome, Login e Email.");
                return;
            }

            if (!string.IsNullOrEmpty(tbSenhaUsuario.Text) &&
                (tbSenhaUsuario.Text.Length < 8 || !tbSenhaUsuario.Text.Any(char.IsUpper) || !tbSenhaUsuario.Text.Any(char.IsLower) || !tbSenhaUsuario.Text.Any(char.IsDigit)))
            {
                MessageBox.Show("A senha deve ter pelo menos 8 caracteres e conter letras maiúsculas, minúsculas e números.");
                return;
            }

            clsUsuarios usuarios = new clsUsuarios();
            usuarios.Id = idUsuario;
            usuarios.Nome = tbNomeUsuario.Text;
            usuarios.Login = tbLoginUsuario.Text;
            usuarios.Senha = tbSenhaUsuario.Text;
            usuarios.Email = tbEmailUsuario.Text;
            usuarios.Observ = tbObsUsuario.Text;

            clsUsuariosDal usuariosDal = new clsUsuariosDal();
            usuariosDal.Atualizar(usuarios);
            MessageBox.Show("Dados do usuário alterados com sucesso!");

            tbIdUsuario.Clear();
            tbNomeUsuario.Clear();
            tbLoginUsuario.Clear();
            tbSenhaUsuario.Clear();
            tbEmailUsuario.Clear();
            tbObsUsuario.Clear();
            tbNomeUsuario.Focus();
        }

        private void btRemoverUsuario_Click(object sender, EventArgs e)
        {
            clsUsuarios usuarios = new clsUsuarios();
            usuarios.Id = int.Parse(tbIdUsuario.Text);
            clsUsuariosDal usuariosDal = new clsUsuariosDal();
            usuariosDal.Excluir(usuarios);
            MessageBox.Show("Usuário removido com sucesso!");

            tbIdUsuario.Clear();
            tbNomeUsuario.Clear();
            tbLoginUsuario.Clear();
            tbSenhaUsuario.Clear();
            tbEmailUsuario.Clear();
            tbObsUsuario.Clear();
            tbNomeUsuario.Focus();
        }

        private void btLimparUsuario_Click(object sender, EventArgs e)
        {
            tbIdUsuario.Clear();
            tbNomeUsuario.Clear();
            tbLoginUsuario.Clear();
            tbSenhaUsuario.Clear();
            tbEmailUsuario.Clear();
            tbObsUsuario.Clear();
            tbNomeUsuario.Focus();
            this.ativarFormulario();
        }

        private void btFecharUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPesquisarUsuario_Click(object sender, EventArgs e)
        {
            pesq.ShowDialog();

            if (pesq.usuarios.Id > 0)
            {
                tbIdUsuario.Text = pesq.usuarios.Id.ToString();
                tbNomeUsuario.Text = pesq.usuarios.Nome.ToString();
                tbLoginUsuario.Text = pesq.usuarios.Login.ToString();
                tbSenhaUsuario.Text = pesq.usuarios.Senha.ToString();
                tbEmailUsuario.Text = pesq.usuarios.Email.ToString();
                tbObsUsuario.Text = pesq.usuarios.Observ.ToString();
            }
        }

        private void frmUsuariosCadastro_Load(object sender, EventArgs e)
        {
            this.ativarFormulario();
        }
    }
}
