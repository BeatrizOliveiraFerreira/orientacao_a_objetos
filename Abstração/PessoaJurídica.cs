using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstração
{
    class PessoaJurídica : Padrão
    {
        public override void taxaEmprestimo(double valor)
        {
            Console.WriteLine($"Taxa de empréstimo para Pessoa Jurídica R${valor * 0.2}");
        }
    }
}
