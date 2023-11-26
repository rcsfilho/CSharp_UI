using cls_Dal;
using cls_modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsBLL
{
    public class clsClientesAnimaisBLL
    {
        private clsClientesAnimaisDal clientesAnimaisDal;

        public clsClientesAnimaisBLL()
        {
            clientesAnimaisDal = new clsClientesAnimaisDal();
        }
        public void Inserir(int cliId, int aniId)
        {
            this.clientesAnimaisDal.Inserir(cliId, aniId);
        }
        public void Remover(int cliId, int aniId)
        {
            this.clientesAnimaisDal.Remover(cliId, aniId);
        }
        public DataTable ListarTodos()
        {
            return this.clientesAnimaisDal.ListarTodos();
        }
        public List<clsAnimaisClientes> listarTodosArray()
        {
            return this.clientesAnimaisDal.listarTodosArray();
        }
    }
}
