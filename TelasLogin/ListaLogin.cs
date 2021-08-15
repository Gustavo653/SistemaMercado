using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMercado
{
    class ListaLogin
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public ListaLogin(string usuario, string senha)
        {
            Usuario = usuario;
            Senha = senha;
        }
    }
}
