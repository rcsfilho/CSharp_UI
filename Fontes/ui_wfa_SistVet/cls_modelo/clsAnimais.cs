using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cls_modelo
{
    public class clsAnimais
    {
        private int _aniid;
        private string _nome;
        private string _apelido;
        private DateTime _date;
        private string _obs;
        private int _aniespid;

        public int Id
        {
            get { return _aniid; }
            set { _aniid = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Apelido
        {
            get { return _apelido; }
            set { _apelido = value; }
        }

        public DateTime Data
        {
            get { return _date; }
            set { _date = value; }
        }

        public string Obs
        {
            get { return _obs; }
            set { _obs = value; }
        }

        public int AniEspeciesId // Propriedade para a chave estrangeira
        {
            get { return _aniespid; }
            set { _aniespid = value; }
        }
        
        //public clsEspecies AniEspecies { get; set; }
    }
}
