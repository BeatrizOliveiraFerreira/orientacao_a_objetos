using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acesso
{
    class Produto
    {
        public string nome;

        private double valor;

        public void mensagem()
        {
            Console.WriteLine($"Seu nome é {nome}");
        }
    }
}
