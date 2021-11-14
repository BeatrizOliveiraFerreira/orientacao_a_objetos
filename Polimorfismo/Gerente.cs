using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Gerente : Imposto
    {
        public override void valeAlimentacao(double salario)
        {
            Console.WriteLine($"Desconto gerente do Vale Alimentação R${salario * 0.15}");
        }
    }
}
