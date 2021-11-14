using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Pessoa
    {
        public void apresentar()
        {
            Console.WriteLine("Olá!!");
        }

        public void apresentar(string nome)
        {
            Console.WriteLine($"Olá {nome}");
        }

        public void apresentar(string nome, int idade)
        {
           Console.WriteLine($"Seu nome é {nome} e você tem {idade} anos");
        }
    }
}
