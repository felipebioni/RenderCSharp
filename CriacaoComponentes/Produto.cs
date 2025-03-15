using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoComponentes
{
    internal class Produto
    {
        private string Nome { get; set; }
        private double Preco { get; set;}
        private string Descricao { get; set; }
        private int Quantidade { get; set; }

        public Produto(string nome, double preco, string descricao, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Descricao = descricao;
            Quantidade = quantidade;
        }
    }
}
