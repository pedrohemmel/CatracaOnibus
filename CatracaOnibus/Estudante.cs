using System;
using System.Collections.Generic;
using System.Text;

namespace CatracaOnibus
{
    class Estudante : PessoaCivil
    {
        public Estudante(string nome, bool temDinheiro) : base(nome, temDinheiro)
        {
        }

        public override void apresentacaoPessoa()
        {
            Console.WriteLine($"\nMe chamo {this.nome}, estou indo para a faculdade, graças a Deus tenho bilhete único e pago meia entrada para passar na catraca, vamos la!\n");
        }
    }
}
