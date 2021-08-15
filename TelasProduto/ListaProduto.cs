using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMercado
{
    class ListaProduto
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public ListaProduto(string nome, int quantidade, double preco)
        {
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
        }
    }
}
