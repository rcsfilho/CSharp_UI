using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cls_modelo
{
    public class clsUsuarios
    {
        private int _usuid;
        private string _usunome;
        private string _usulogin;
        private string _ususenha;
        private string _usuemail;
        private string _usuobs;      

        public int Id
        {
            get { return _usuid; }
            set { _usuid = value; }
        }
        public string Nome
        {
            get { return _usunome; }
            set { _usunome = value; }
        }
        public string Login
        {
            get { return _usulogin; }
            set { _usulogin = value; }
        }
       
        public string Senha
        {
            get { return _ususenha; }
            set { _ususenha = value; }
        }
        public string Email
        {
            get { return _usuemail; }
            set { _usuemail = value; }
        }
        public string Observ
        {
            get { return _usuobs; }
            set { _usuobs = value; }
        }
    }
}
