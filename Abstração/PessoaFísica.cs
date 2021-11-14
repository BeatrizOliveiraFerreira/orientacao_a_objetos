using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstração
{
    class PessoaFísica : Padrão
    {
        public override void taxaEmprestimo(double valor)
        {
            Console.WriteLine($"Taxa de empréstimo de Pessoa Física R${valor * 0.1}");

        }
    }
}
