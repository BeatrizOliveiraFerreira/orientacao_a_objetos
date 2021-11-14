using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    class Pessoa
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}
