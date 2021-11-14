using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class Aluno
    {
        private double nota1, nota2;

        private double media()
        {
            return (nota1 + nota2) / 2;
        }

        public void mensagem()
        {
            Console.Write("Digite a primeira nota: ");
            nota1 = float.Parse(Console.ReadLine());
            Console.Write("Digite a segundo nota: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"A média é {media()}");

        }
    }
}
