using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using cls_Dal;
using cls_modelo;



namespace ui_wfa_SistVet
{
    public partial class frmAcesso : Form
    {
        public frmAcesso()
        {
            InitializeComponent();
        }

        private void btAcessoPrograma_Click(object sender, EventArgs e)
        {
            string loginInserido = tbUsuariologin.Text;
            string senhaInserida = tbSenhausuario.Text;

            // Chame o método Validacao para obter os dados de login e senha da tabela
            clsUsuariosDal clsUsuario = new clsUsuariosDal();
            DataTable tabelaValidacao = clsUsuario.Validacao();

            bool credenciaisValidas = false;

            foreach (DataRow row in tabelaValidacao.Rows)
            {
                string loginBanco = row["usulogin"].ToString();
                string senhaBanco = row["ususenha"].ToString();

                if (loginInserido == loginBanco && senhaInserida == senhaBanco)
                {
                    credenciaisValidas = true;
                    frmPrincipal.NomeUsuario = row["usulogin"].ToString();
                    break;
                }
            }

            if (credenciaisValidas)
            {
                // Credenciais válidas, abrir o formulário principal
                frmPrincipal principal = new frmPrincipal();
                principal.FormClosed += (s, args) => this.Close(); // Fechar frmAcesso quando frmPrincipal for fechado
                principal.Show();
            }
            else
            {
                // Exibir mensagem de erro
                MessageBox.Show("Login ou senha inválidos");
            }
        }

        private void btSairAcesso_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
