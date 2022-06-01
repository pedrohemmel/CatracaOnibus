using System;
using System.Collections.Generic;
using System.Text;

namespace CatracaOnibus
{
    class Idoso : PessoaCivil
    {
        public Idoso(string nome) : base(nome)
        {
        }

        public override void apresentacaoPessoa()
        {
            Console.WriteLine($"\nMe chamo {this.nome}, ja me aposentei e sou carente, não tenho mais o que fazer. Como tenho mais de 65 anos, tenho passagem gratuita no ônibus, vou fofocar °o°.\n");
        }
    }
}
