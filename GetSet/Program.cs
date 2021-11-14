using System;

namespace GetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Nome = "Alisson";
            Console.WriteLine(p.Nome);
        }
    }
}
