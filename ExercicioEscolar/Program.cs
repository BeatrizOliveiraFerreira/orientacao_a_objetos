using System;

namespace ExercicioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno escola = new Aluno();
            escola.nome = "Beatriz";
            escola.nota1 = 6;
            escola.nota2 = 9.5f;
            escola.mensagem();

        }
    }
}
