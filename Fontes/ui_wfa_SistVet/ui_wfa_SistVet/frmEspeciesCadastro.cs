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
    public partial class frmEspeciesCadastro : Form
    {
        public frmEspeciesCadastro()
        {
            InitializeComponent();
        }
        public clsEspecies especies;
        private clsEspeciesDal especiesDal;

        private void ativarFormulario()
        {
            btCadastrarEspécie.Enabled = true;
            btAlterarEspécie.Enabled = false;
            btExcluirEspecie.Enabled = false;
            tbSelecionarEspécie.Enabled = true;
            btLimparFrmEspecie.Enabled = true;
            btFecharEspécie.Enabled = true;
        }
        private void habilitarEdiçao()
        {
            btCadastrarEspécie.Enabled = false;
            btAlterarEspécie.Enabled = true;
            btExcluirEspecie.Enabled = true;
            tbSelecionarEspécie.Enabled = true;
            btLimparFrmEspecie.Enabled = true;
            btFecharEspécie.Enabled = true;
        }
        private void carregarGrid()
        {
            dataGridEspecie.DataSource = especiesDal.listarTodosArray();
        }
        private void selecionarItem()
        {
            Int32 i = 0;

            i = dataGridEspecie.CurrentRow.Index;
            especies.Id = Int32.Parse(dataGridEspecie[0, i].Value.ToString());
            especies.Nome = dataGridEspecie[1, i].Value.ToString();
        }

        private void frmEspeciesCadastro_Load(object sender, EventArgs e)
        {
            this.especies = new clsEspecies();
            this.especiesDal = new clsEspeciesDal();
            this.carregarGrid();
            this.ativarFormulario();
        }

        private void tbSelecionarEspécie_Click(object sender, EventArgs e)
        {
            this.selecionarItem();

            if (especies.Id > 0)
            {
                tbEspecieId.Text = especies.Id.ToString();
                tbEspecieNome.Text = especies.Nome.ToString();
            }
            this.habilitarEdiçao();
        }

        private void btCadastrarEspécie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbEspecieNome.Text))
            {
                MessageBox.Show("Certifique-se de preencher o campo de Nome da Espécie.");
                return;
            }

            especies.Nome = tbEspecieNome.Text;
            especiesDal.inserir(especies);
            MessageBox.Show("Espécie cadastrada com sucesso!");
            this.carregarGrid();
        }

        private void btAlterarEspécie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbEspecieId.Text) || !int.TryParse(tbEspecieId.Text, out int idEsp))
            {
                MessageBox.Show("Certifique-se de preencher o campo de ID da Espécie com um valor numérico válido.");
                return;
            }

            if (string.IsNullOrEmpty(tbEspecieNome.Text))
            {
                MessageBox.Show("Certifique-se de preencher o campo de Nome da Espécie.");
                return;
            }

            especies.Id = idEsp;
            especies.Nome = tbEspecieNome.Text;
            especiesDal.Atualizar(especies);
            MessageBox.Show("Registro atualizado com sucesso!");
            this.carregarGrid();
        }

        private void btExcluirEspecie_Click(object sender, EventArgs e)
        {
            especies.Id = Int32.Parse(tbEspecieId.Text);
            especiesDal.Excluir(especies);
            MessageBox.Show("Registro removido com sucesso!");
            tbEspecieId.Clear();
            tbEspecieNome.Clear();
            tbEspecieNome.Focus();
            this.carregarGrid();
        }

        private void btLimparFrmEspecie_Click(object sender, EventArgs e)
        {
            tbEspecieId.Clear();
            tbEspecieNome.Clear();
            tbEspecieNome.Focus();
            this.ativarFormulario();
        }

        private void btFecharEspécie_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
