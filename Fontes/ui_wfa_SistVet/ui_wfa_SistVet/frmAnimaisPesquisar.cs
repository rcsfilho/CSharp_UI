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
    public partial class frmAnimaisPesquisar : Form
    {
        public frmAnimaisPesquisar()
        {
            InitializeComponent();
        }

        public clsAnimais animais;
        private clsAnimaisDal animaisDal;
        public event Action<clsAnimais> AnimalSelecionado;
        public event Action SairSemSelecionar;

        private void carregarGrid()
        {
            dataGridAnimais.DataSource = animaisDal.listarTodosArray();
        }
        private void selecionarItem()
        {
            Int32 i = 0;

            i = dataGridAnimais.CurrentRow.Index;
            animais.Id = Int32.Parse(dataGridAnimais[0, i].Value.ToString());
            animais.Nome = dataGridAnimais[1, i].Value.ToString();
            animais.Apelido = dataGridAnimais[2, i].Value.ToString();
            animais.Data = Convert.ToDateTime(dataGridAnimais[3, i].Value.ToString());
            animais.Obs = dataGridAnimais[4, i].Value.ToString();
            animais.AniEspeciesId = Int32.Parse(dataGridAnimais[5, i].Value.ToString());
        }

        private void frmAnimaisPesquisar_Load(object sender, EventArgs e)
        {
            this.animais = new clsAnimais();
            this.animaisDal = new clsAnimaisDal();
            this.carregarGrid();
        }

        private void btSelecionarAnimais_Click(object sender, EventArgs e)
        {
            this.selecionarItem();
            AnimalSelecionado?.Invoke(this.animais);
            this.Close();
        }

        private void btVoltarPesquisaAnimais_Click(object sender, EventArgs e)
        {
            if (this.animais.Id == 0)
            {
                // Dispare o evento se o usuário sair sem selecionar nada
                SairSemSelecionar?.Invoke();
            }
            this.Close();
        }
    }
}
