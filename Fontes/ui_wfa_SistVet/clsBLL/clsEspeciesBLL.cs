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
    public class clsEspeciesBLL
    {
        private clsEspeciesDal especiesDal;

        public clsEspeciesBLL()
        {
            especiesDal = new clsEspeciesDal();
        }
        public void inserir(clsEspecies parEspecie)
        {
            this.especiesDal.inserir(parEspecie);
        }
        public void Atualizar(clsEspecies parEspecie)
        {
            this.especiesDal.Atualizar(parEspecie);
        }
        public void Excluir(clsEspecies parEspecie)
        {
            this.especiesDal.Excluir(parEspecie);
        }
        public DataTable ListarTodos()
        {
            return this.especiesDal.ListarTodos();
        }
        public List<clsEspecies> listarTodosArray()
        {
            return this.especiesDal.listarTodosArray();
        }
        public List<clsEspecies> ObterTodasAsEspecies()
        {
            return this.especiesDal.ObterTodasAsEspecies();
        }
    }
}
