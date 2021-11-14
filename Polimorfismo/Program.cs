using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto estagio = new Estagiário();
            estagio.valeAlimentacao(1000);
            estagio.valeAlimentacao(1000);
            Console.WriteLine("----------");

            Imposto gerenciar = new Gerente();
            gerenciar.valeAlimentacao(5000);
            gerenciar.valeTransporte(5000);
            Console.WriteLine("----------");

            Imposto atender = new Atendente();
            atender.valeAlimentacao(2000);
            atender.valeTransporte(2000);
            Console.WriteLine("----------");
        }
    }
}
