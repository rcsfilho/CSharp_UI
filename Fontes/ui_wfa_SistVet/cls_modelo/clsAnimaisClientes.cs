using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cls_modelo
{
    public class clsAnimaisClientes
    {
        private int _cliid;
        private string _clinome;
        private int _aniid;
        private string _aninome;

        public int ClienteId
        {
            get { return _cliid; }
            set { _cliid = value; }
        }

        public string ClienteNome
        {
            get { return _clinome; }
            set { _clinome = value; }
        }

        public int AnimalId
        {
            get { return _aniid; }
            set { _aniid = value; }
        }

        public string AnimalNome
        {
            get { return _aninome; }
            set { _aninome = value; }
        }
    }
}
