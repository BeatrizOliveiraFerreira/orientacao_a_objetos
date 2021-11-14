using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEscolar
{
    class Aluno
    {
        public string nome;
        public float nota1, nota2;

        public float media()
        {
            return (nota1 + nota2) / 2;
        }

        public string situacao(float media)
        {
            return media >= 7 ? "Aprovado" : "Reprovado";
        }

        public void mensagem()
        {
            float saber_a_media = media();
            string saber_a_situacao = situacao(saber_a_media);

            Console.WriteLine($"{nome} obteve a média {saber_a_media} e está {saber_a_situacao}");

        }
    }
}
