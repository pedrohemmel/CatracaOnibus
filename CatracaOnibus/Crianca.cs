using System;
using System.Collections.Generic;
using System.Text;

namespace CatracaOnibus
{
    class Crianca : PessoaCivil
    {
        public Crianca(string nome) : base(nome)
        {
        }

        public override void apresentacaoPessoa()
        {
            Console.WriteLine($"\nMe chamo {this.nome}, estou indo para escola com minha mamãe, como tenho 6 anos, vou passar de baixo da catraca.\n");
        }
    }
}
