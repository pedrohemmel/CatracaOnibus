using System;
using System.Collections.Generic;
using System.Text;

namespace CatracaOnibus
{
    class Deficiente : PessoaCivil
    {
        public Deficiente(string nome) : base(nome)
        {
        }

        public override void apresentacaoPessoa()
        {
            Console.WriteLine($"\nMe chamo {this.nome}, estou indo para o médico e preciso pegar ônibus no caminho, como sou deficiênte, não preciso pagar passagem.\n");
        }
    }
}
