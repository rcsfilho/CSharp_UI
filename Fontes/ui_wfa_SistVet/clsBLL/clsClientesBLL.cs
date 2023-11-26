using cls_modelo;
using cls_Dal;
using System.Data.SqlClient;
using System.Data;

namespace clsBLL
{
    public class clsClientesBLL
    {
        private clsClientesDal clientesDal;

        public clsClientesBLL()
        {
            clientesDal = new clsClientesDal();
        }

        public void Inserir(clsClientes parCliente)
        {
            this.clientesDal.Inserir(parCliente);
        }
        public void Atualizar(clsClientes parCliente)
        {
            this.clientesDal.Atualizar(parCliente);
        }
        public void Excluir(clsClientes parCliente)
        {
            this.clientesDal.Excluir(parCliente);
        }
        public DataTable ListarTodos()
        {
            return this.clientesDal.ListarTodos();
        }
        public List<clsClientes> listarTodosArray()
        {
            return this.clientesDal.listarTodosArray();
        }
    }
}