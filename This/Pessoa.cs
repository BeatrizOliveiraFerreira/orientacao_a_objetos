using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This
{
    class Pessoa
    {
        private string nome = "Beatriz";

        public Pessoa(string nome)
        {
            Console.WriteLine(nome);
            Console.WriteLine(this.nome);
        }
    }
}
