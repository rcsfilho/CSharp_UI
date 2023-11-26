using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cls_modelo;
using cls_Dal;


namespace ui_wfa_SistVet
{
    public partial class frmAnimaisCadastro : Form
    {
        public frmAnimaisCadastro()
        {
            InitializeComponent();

        }
        private bool isUserInteraction;
        private void ativarFormulario()
        {
            btCadastrarAnimal.Enabled = true;
            btAlterarAnimal.Enabled = false;
            btRemoverAnimal.Enabled = false;
            btPesquisarAnimal.Enabled = true;
            btLimparAnimal.Enabled = true;
            btFecharAnimal.Enabled = true;           
            
        }
        private void limparFormulario()
        {
            tbIdAnimal.Clear();
            tbNomeAnimal.Clear();
            tbApelidoAnimal.Clear();
            tbDataNasc.Clear();
            tbObsAnimal.Clear();
            tbIdEspecieAnimal.Clear();
            tbNomeAnimal.Focus();
        }
        private void frmAnimaisCadastro_Load(object sender, EventArgs e)
        {           
            this.ativarFormulario();
            isUserInteraction = false;
            this.CarregarEspeciesNaComboBox();
            isUserInteraction = true;
        }
        private void btPesquisarAnimal_Click(object sender, EventArgs e)
        {
            frmAnimaisPesquisar frm = new frmAnimaisPesquisar();
            frm.AnimalSelecionado += AnimalSelecionadoHandler;
            frm.ShowDialog();

            if (frm.animais.Id > 0)
            {
                tbIdAnimal.Text = frm.animais.Id.ToString();
                tbNomeAnimal.Text = frm.animais.Nome.ToString();
                tbApelidoAnimal.Text = frm.animais.Apelido.ToString();
                tbDataNasc.Text = frm.animais.Data.ToString();
                tbObsAnimal.Text = frm.animais.Obs.ToString();
                tbIdEspecieAnimal.Text = frm.animais.AniEspeciesId.ToString();
            }
        }

        private void AnimalSelecionadoHandler(clsAnimais animais)
        {
            btCadastrarAnimal.Enabled = false;
            btAlterarAnimal.Enabled = true;
            btRemoverAnimal.Enabled = true;
            btLimparAnimal.Enabled = true;
            btFecharAnimal.Enabled = true;
        }
        private void SairSemSelecionarHandler()
        {
            this.ativarFormulario();
        }


        private void btAlterarAnimal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNomeAnimal.Text) || string.IsNullOrEmpty(tbDataNasc.Text) || string.IsNullOrEmpty(tbIdEspecieAnimal.Text))
            {
                MessageBox.Show("Certifique-se de preencher os campos obrigatórios: Nome, Data de Nascimento e ID da Espécie.");
                return;
            }

            DateTime dataNascimento;
            if (!DateTime.TryParse(tbDataNasc.Text, out dataNascimento))
            {
                MessageBox.Show("Data de Nascimento inválida. Por favor, insira uma data válida.");
                return;
            }

            int idAnimal, idEspecieAnimal;
            if (!int.TryParse(tbIdAnimal.Text, out idAnimal) || !int.TryParse(tbIdEspecieAnimal.Text, out idEspecieAnimal))
            {
                MessageBox.Show("ID do Animal e ID da Espécie devem ser valores numéricos válidos.");
                return;
            }

            clsAnimais animais = new clsAnimais();
            animais.Id = idAnimal;
            animais.Nome = tbNomeAnimal.Text;
            animais.Apelido = tbApelidoAnimal.Text;
            animais.Data = dataNascimento;
            animais.Obs = tbObsAnimal.Text;
            animais.AniEspeciesId = idEspecieAnimal;

            clsAnimaisDal animaisDal = new clsAnimaisDal();
            animaisDal.Atualizar(animais);
            MessageBox.Show("Registro atualizado com sucesso!");
            this.limparFormulario();
            this.ativarFormulario();
        }

        private void btRemoverAnimal_Click(object sender, EventArgs e)
        {
            clsAnimais animais = new clsAnimais();
            animais.Id = Int32.Parse(tbIdAnimal.Text);
            clsAnimaisDal animaisDal = new clsAnimaisDal();
            animaisDal.Excluir(animais);
            MessageBox.Show("Registro removido com sucesso!");
            tbIdAnimal.Clear();
            tbNomeAnimal.Clear();
            tbApelidoAnimal.Clear();
            tbDataNasc.Clear();
            tbObsAnimal.Clear();
            tbIdEspecieAnimal.Clear();
            tbIdAnimal.Focus();
            this.ativarFormulario();

        }

        private void btCadastrarAnimal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNomeAnimal.Text) || string.IsNullOrEmpty(tbDataNasc.Text) || string.IsNullOrEmpty(tbIdEspecieAnimal.Text))
            {
                MessageBox.Show("Certifique-se de preencher os campos obrigatórios: Nome, Data de Nascimento e ID da Espécie.");
                return;
            }

            DateTime dataNascimento;
            if (!DateTime.TryParse(tbDataNasc.Text, out dataNascimento))
            {
                MessageBox.Show("Data de Nascimento inválida. Por favor, insira uma data válida.");
                return;
            }

            int idEspecieAnimal;
            if (!int.TryParse(tbIdEspecieAnimal.Text, out idEspecieAnimal))
            {
                MessageBox.Show("ID da Espécie deve ser um valor numérico válido.");
                return;
            }

            clsAnimais animais = new clsAnimais();
            animais.Nome = tbNomeAnimal.Text;
            animais.Apelido = tbApelidoAnimal.Text;
            animais.Data = dataNascimento;
            animais.Obs = tbObsAnimal.Text;
            animais.AniEspeciesId = idEspecieAnimal;

            clsAnimaisDal animaisDal = new clsAnimaisDal();
            animaisDal.inserir(animais);
            MessageBox.Show("Animal cadastrado com sucesso!");
        }

        private void btLimparAnimal_Click(object sender, EventArgs e)
        {
            this.limparFormulario();
            this.ativarFormulario();
        }

        private void btFecharAnimal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CarregarEspeciesNaComboBox()
        {
            try
            {
                clsEspeciesDal dal = new clsEspeciesDal();
                List<clsEspecies> listaEspecies = dal.listarTodosArray();

                cbEspeciesAnimais.DataSource = listaEspecies;
                cbEspeciesAnimais.DisplayMember = "Nome"; // Nome da propriedade que você quer mostrar
                cbEspeciesAnimais.ValueMember = "Id"; // Nome da propriedade que representa o valor
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar as espécies: " + ex.Message);
            }
        }

        private void cbEspeciesAnimais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUserInteraction && cbEspeciesAnimais.SelectedIndex != -1)
            {
                clsEspecies especieSelecionada = cbEspeciesAnimais.SelectedItem as clsEspecies;

                if (especieSelecionada != null)
                {
                    tbIdEspecieAnimal.Text = especieSelecionada.Id.ToString();
                }
            }
        }
    }
}
