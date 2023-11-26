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
using System.Text.RegularExpressions;

namespace ui_wfa_SistVet
{
    public partial class frmClientesCadastro : Form
    {
        private List<clsAnimais> listaAnimais;
        public frmClientesCadastro()
        {
            InitializeComponent();

            // Crie uma instância do frmClientesPesquisar
            frm = new frmClientesPesquisar();

            // Inscreva-se para o evento BotaoClicado
            frm.BotaoClicado += (selecionado) =>
            {
                if (selecionado)
                {
                    ClienteSelecionadoHandler();
                }
                else
                {
                    ativarFormulario();
                }
            };
        }
        public frmClientesPesquisar frm;
        clsClientesAnimaisDal ClientesAnimaisDal = new clsClientesAnimaisDal();
        private void ativarFormulario()
        {
            btCadastrarCliente.Enabled = true;
            btAlterarCliente.Enabled = false;
            btRemoverCliente.Enabled = false;
            btPesquisarCliente.Enabled = true;
            btLimparClientes.Enabled = true;
            btFecharFrmClientes.Enabled = true;
        }
        private void btPesquisarCliente_Click(object sender, EventArgs e)
        {
            frm.ShowDialog();

            if (frm.clientes.Id > 0)
            {
                tbIDCliente.Text = frm.clientes.Id.ToString();
                tbNomeCliente.Text = frm.clientes.Nome.ToString();
                tbCPFCliente.Text = frm.clientes.CPF.ToString();
                tbEmailCliente.Text = frm.clientes.Email.ToString();
                tbDataCadastro.Text = frm.clientes.DataCadastro.ToString();
            }
        }
        private void ClienteSelecionadoHandler()
        {
            btCadastrarCliente.Enabled = false;
            btAlterarCliente.Enabled = true;
            btRemoverCliente.Enabled = true;
            btPesquisarCliente.Enabled = true;
            btLimparClientes.Enabled = true;
            btFecharFrmClientes.Enabled = true;
        }

        private void carregarGridDonos()
        {
            dgDonosAnimais.DataSource = ClientesAnimaisDal.listarTodosArray();
        }

        private void btAlterarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbIDCliente.Text) || string.IsNullOrEmpty(tbNomeCliente.Text) || string.IsNullOrEmpty(tbCPFCliente.Text) || string.IsNullOrEmpty(tbDataCadastro.Text))
            {
                MessageBox.Show("Certifique-se de preencher todos os campos obrigatórios: ID, Nome, CPF e Data de Cadastro.");
                return;
            }

            int idCliente;
            if (!int.TryParse(tbIDCliente.Text, out idCliente))
            {
                MessageBox.Show("ID do Cliente deve ser um valor numérico válido.");
                return;
            }

            decimal cpfCliente;
            if (!decimal.TryParse(tbCPFCliente.Text, out cpfCliente))
            {
                MessageBox.Show("CPF do Cliente deve ser um valor numérico válido.");
                return;
            }

            DateTime dataCadastro;
            if (!DateTime.TryParse(tbDataCadastro.Text, out dataCadastro))
            {
                MessageBox.Show("Data de Cadastro inválida. Por favor, insira uma data válida.");
                return;
            }

            clsClientes clientes = new clsClientes();
            clientes.Id = idCliente;
            clientes.Nome = tbNomeCliente.Text;
            clientes.CPF = cpfCliente;
            clientes.Email = tbEmailCliente.Text;
            clientes.DataCadastro = dataCadastro;

            List<int> idsAnimaisSelecionados = new List<int>();
            foreach (int selectedIndex in lbAnimaisDonos.SelectedIndices)
            {
                string selectedItem = lbAnimaisDonos.Items[selectedIndex].ToString();
                int animalId = int.Parse(Regex.Match(selectedItem, @"\d+").Value); // Extrai o ID do animal
                idsAnimaisSelecionados.Add(animalId);
            }

            // Use os IDs para obter os objetos clsAnimais correspondentes
            List<clsAnimais> animaisSelecionados = listaAnimais.Where(animal => idsAnimaisSelecionados.Contains(animal.Id)).ToList();

            // Associe a lista de animais ao cliente
            clientes.AnimaisAssociados = animaisSelecionados;

            clsClientesDal clientesDal = new clsClientesDal();
            clientesDal.Atualizar(clientes);
            this.carregarGridDonos();
            MessageBox.Show("Registro atualizado com sucesso!");
            tbIDCliente.Clear();
            tbNomeCliente.Clear();
            tbCPFCliente.Clear();
            tbEmailCliente.Clear();
            tbDataCadastro.Clear();
            tbNomeCliente.Focus();
        }

        private void btRemoverCliente_Click(object sender, EventArgs e)
        {

            clsClientes clientes = new clsClientes();
            clientes.Id = Int32.Parse(tbIDCliente.Text);

            int cliId = clientes.Id; // Use o ID do cliente

            string[] numerosText = tbIdentificaçãoAnimal.Text.Split(',');

            clsClientesAnimaisDal animaisClientes = new clsClientesAnimaisDal();
            clsClientesDal clientesDal = new clsClientesDal();

            foreach (string numeroTexto in numerosText)
            {
                if (int.TryParse(numeroTexto, out int aniId))
                {
                    animaisClientes.Remover(cliId, aniId);
                }
                else
                {
                    // mensagem de erro.
                    MessageBox.Show($"'{numeroTexto}' não é um número inteiro válido.");
                }
            }

            clientesDal.Excluir(clientes);
            this.carregarGridDonos();

            MessageBox.Show("Registros removidos com sucesso!");
            tbIDCliente.Clear();
            tbNomeCliente.Clear();
            tbCPFCliente.Clear();
            tbEmailCliente.Clear();
            tbDataCadastro.Clear();
            tbIdentificaçãoAnimal.Clear();
            tbNomeCliente.Focus();

        }

        private void btCadastrarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNomeCliente.Text) || string.IsNullOrEmpty(tbCPFCliente.Text) || string.IsNullOrEmpty(tbDataCadastro.Text))
            {
                MessageBox.Show("Certifique-se de preencher todos os campos obrigatórios: Nome, CPF e Data de Cadastro.");
                return;
            }

            decimal cpfCliente;
            if (!decimal.TryParse(tbCPFCliente.Text, out cpfCliente))
            {
                MessageBox.Show("CPF do Cliente deve ser um valor numérico válido.");
                return;
            }

            DateTime dataCadastro;
            if (!DateTime.TryParse(tbDataCadastro.Text, out dataCadastro))
            {
                MessageBox.Show("Data de Cadastro inválida. Por favor, insira uma data válida.");
                return;
            }

            clsClientes clientes = new clsClientes();
            clientes.Nome = tbNomeCliente.Text;
            clientes.CPF = cpfCliente;
            clientes.Email = tbEmailCliente.Text;
            clientes.DataCadastro = dataCadastro;

            // Associe os IDs dos animais selecionados na ListBox ao cliente
            List<int> idsAnimaisSelecionados = new List<int>();
            foreach (int selectedIndex in lbAnimaisDonos.SelectedIndices)
            {
                string selectedItem = lbAnimaisDonos.Items[selectedIndex].ToString();
                int animalId = int.Parse(Regex.Match(selectedItem, @"\d+").Value); // Extrai o ID do animal
                idsAnimaisSelecionados.Add(animalId);
            }

            // Use os IDs para obter os objetos clsAnimais correspondentes
            List<clsAnimais> animaisSelecionados = listaAnimais.Where(animal => idsAnimaisSelecionados.Contains(animal.Id)).ToList();

            // Associe a lista de animais ao cliente
            clientes.AnimaisAssociados = animaisSelecionados;

            clsClientesDal clientesDal = new clsClientesDal();
            clientesDal.Inserir(clientes);
            this.carregarGridDonos();
            MessageBox.Show("Cliente cadastrado com sucesso!");
        }

        private void btLimparClientes_Click(object sender, EventArgs e)
        {
            tbIDCliente.Clear();
            tbNomeCliente.Clear();
            tbCPFCliente.Clear();
            tbEmailCliente.Clear();
            tbDataCadastro.Clear();
            tbIdentificaçãoAnimal.Clear();
            tbNomeCliente.Focus();
            this.ativarFormulario();
        }

        private void btFecharFrmClientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClientesCadastro_Load(object sender, EventArgs e)
        {
            this.carregarGridDonos();
            this.ativarFormulario();
            this.carregarGridDonos();
            this.ativarFormulario();
            clsAnimaisDal animaisDal = new clsAnimaisDal();

            // Atribua a lista de animais retornada pelo método ListaAnimais à variável listaAnimais
            listaAnimais = animaisDal.ListaAnimais();

            // Preencha a ListBox com os nomes e IDs dos animais
            foreach (clsAnimais animal in listaAnimais)
            {
                lbAnimaisDonos.Items.Add($"{animal.Nome} (ID: {animal.Id})");
            }

            // Configure a seleção múltipla
            lbAnimaisDonos.SelectionMode = SelectionMode.MultiSimple;

            // Adicione o evento SelectedIndexChanged à ListBox
            lbAnimaisDonos.SelectedIndexChanged += new EventHandler(lbAnimaisDonos_SelectedIndexChanged);

        }

        private void lbAnimaisDonos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Inicialize uma lista para armazenar os IDs dos animais selecionados
            List<int> idsSelecionados = new List<int>();

            // Percorra os itens selecionados na ListBox
            foreach (int selectedIndex in lbAnimaisDonos.SelectedIndices)
            {
                // Obtém o ID do animal com base no índice selecionado
                clsAnimais animal = listaAnimais[selectedIndex];
                idsSelecionados.Add(animal.Id);
            }

            // Concatene os IDs separados por vírgula e exiba na TextBox
            tbIdentificaçãoAnimal.Text = string.Join(", ", idsSelecionados);
        }
    }
}
