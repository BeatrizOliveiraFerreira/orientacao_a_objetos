using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientação_a_objetos
{
    class Pessoa
    {
        public string nome;
        public int idade;

        public void mensagem()
        {
            Console.WriteLine($"Olá {nome}\nVocê tem {idade} anos");
        }
    }
}
