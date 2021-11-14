using System;

namespace Orientação_a_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa objeto = new Pessoa();
            objeto.idade = 25;
            objeto.nome = "Beatriz Oliveira Ferreira";
            objeto.mensagem();
        }
    }
}
