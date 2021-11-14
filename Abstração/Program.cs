using System;

namespace Abstração
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFísica pf = new PessoaFísica();
            pf.taxaEmprestimo(1000);

            PessoaJurídica pj = new PessoaJurídica();
            pj.taxaEmprestimo(1000);
        }
    }
}
