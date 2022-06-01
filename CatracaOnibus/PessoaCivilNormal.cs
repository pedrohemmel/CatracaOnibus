using System;
using System.Collections.Generic;
using System.Text;

namespace CatracaOnibus
{
    class PessoaCivilNormal : PessoaCivil
    {
        public PessoaCivilNormal(string nome, bool temDinheiro) : base(nome, temDinheiro)
        {
        }

        public override void apresentacaoPessoa()
        {
            Console.WriteLine($"\nMe chamo {this.nome}, estou indo para o trabalho e preciso pegar ônibus no caminho, espero que tudo dê certo para eu passar pela catraca.\n");
        }
    }
}
