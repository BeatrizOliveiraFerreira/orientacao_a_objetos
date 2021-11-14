using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class Pessoa
    {
        protected string nome;
        protected int idade;

        protected void mensagemPessoa()
        {
            Console.WriteLine($"nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
        }
    }
}
