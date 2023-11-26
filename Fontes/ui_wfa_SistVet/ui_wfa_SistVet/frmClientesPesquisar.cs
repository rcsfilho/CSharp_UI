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
    public partial class frmClientesPesquisar : Form
    {
        public frmClientesPesquisar()
        {
            InitializeComponent();
        }

        public clsClientes clientes;
        private clsClientesDal clientesDal;
        public event Action<bool> BotaoClicado;


        private void carregarGrid()
        {
            dataGridClientes.DataSource = clientesDal.listarTodosArray();
        }
        private void selecionarItem()
        {
            Int32 i = 0;

            i = dataGridClientes.CurrentRow.Index;
            clientes.Id = Int32.Parse(dataGridClientes[0, i].Value.ToString());
            clientes.Nome = dataGridClientes[1, i].Value.ToString();
            clientes.CPF = decimal.Parse(dataGridClientes[2, i].Value.ToString());
            clientes.Email = dataGridClientes[3, i].Value.ToString();
            clientes.DataCadastro = Convert.ToDateTime(dataGridClientes[4, i].Value.ToString());
        }
        private void frmClientesPesquisar_Load(object sender, EventArgs e)
        {
            this.clientes = new clsClientes();
            this.clientesDal = new clsClientesDal();
            this.carregarGrid();
        }
        private void btSelecionarClientes_Click(object sender, EventArgs e)
        {
            this.selecionarItem();
            BotaoClicado?.Invoke(true);
            this.Close();
        }

        private void btVoltarClientes_Click(object sender, EventArgs e)
        {
            this.clientes.Id = 0;
            BotaoClicado?.Invoke(false);
            this.Close();
        }
    }
}
