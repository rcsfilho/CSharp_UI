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
    public class clsAnimaisBLL
    {
        private clsAnimaisDal animaisDal;

        public clsAnimaisBLL() 
        {
            animaisDal = new clsAnimaisDal();
        }
        public void inserir(clsAnimais parAnimal)
        {
            this.animaisDal.inserir(parAnimal);
        }
        public void Atualizar(clsAnimais parAnimal)
        {
            this.animaisDal.Atualizar(parAnimal);
        }
        public void Excluir(clsAnimais parAnimal)
        {
            this.animaisDal.Excluir(parAnimal);
        }
        public DataTable ListarTodos()
        {
            return this.animaisDal.ListarTodos();
        }
        public List<clsAnimais> listarTodosArray()
        {
            return this.animaisDal.listarTodosArray();
        }
        public List<clsAnimais> ListaAnimais()
        {
            return this.animaisDal.ListaAnimais();
        }
    }
}
