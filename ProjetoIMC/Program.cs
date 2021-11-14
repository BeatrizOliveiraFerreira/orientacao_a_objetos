using System;

namespace ProjetoIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Person situation = new Person();
            situation.weight = 80;
            situation.height = 1.80;
            situation.message();
        }
    }
}
