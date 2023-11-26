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
    public class clsUsuariosBLL
    {
        private clsUsuariosDal usuariosDal;

        public clsUsuariosBLL() 
        { 
            usuariosDal = new clsUsuariosDal();
        }
        public void Inserir(clsUsuarios parUsuario)
        {
            this.usuariosDal.Inserir(parUsuario);
        }
        public void Atualizar(clsUsuarios parUsuario)
        {
            this.usuariosDal.Atualizar(parUsuario);
        }
        public void Excluir(clsUsuarios parUsuario)
        {
            this.usuariosDal.Excluir(parUsuario);
        }
        public DataTable ListarTodos()
        {
            return this.usuariosDal.ListarTodos();
        }
        public List<clsUsuarios> listarTodosArray()
        {
            return this.usuariosDal.listarTodosArray();
        }
        public DataTable Validacao()
        {
            return this.usuariosDal.Validacao();
        }
    }
}
