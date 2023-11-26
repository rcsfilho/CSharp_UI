using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cls_modelo
{
    public class clsClientes
    {
        private int _cliid;
        private string _clinome;
        private decimal _clicpf;
        private string _cliemail;
        private DateTime _clidatacadastro;

        public int Id
        {
            get { return _cliid; }
            set { _cliid = value; }
        }

        public string Nome
        {
            get { return _clinome; }
            set { _clinome = value; }
        }

        public decimal CPF
        {
            get { return _clicpf; }
            set { _clicpf = value; }
        }

        public string Email
        {
            get { return _cliemail; }
            set { _cliemail = value; }
        }

        public DateTime DataCadastro
        {
            get { return _clidatacadastro; }
            set { _clidatacadastro = value; }
        }

        public List<clsAnimais> AnimaisAssociados { get; set; }
    }
}
