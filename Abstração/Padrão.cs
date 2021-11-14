using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstração
{
    abstract class Padrão
    {
        public abstract void taxaEmprestimo(double valor);

        public void calculoPoupanca(double valor, double taxa)
        {
            Console.WriteLine($"Ganho obtidos pela poupança R${valor * taxa}");
        }
    }
}
