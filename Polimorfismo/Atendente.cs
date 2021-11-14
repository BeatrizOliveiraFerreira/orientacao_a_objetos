using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Atendente : Imposto
    {
        public override void valeAlimentacao(double salario)
        {
            Console.WriteLine($"Desconto atendente do Vale alimentação R${salario * 0.12}");
        }
    }
}
