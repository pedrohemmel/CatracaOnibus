using System;
using System.Collections.Generic;
using System.Text;

namespace CatracaOnibus
{
    abstract class PessoaCivil
    {
        //Atribuindo variáveis
        public string nome { get; private set; }
        public bool temDinheiro { get; private set; }

        //chamando variavel do tipo interface com protected

        protected IPodePassar comportamentoCatraca;

        //FOI CRIADO 3 CONSTRUTORES OPCIONAIS PARA CADA TIPO DE OCASIÃO

        //Criando construtor para futuras instâncias
        public PessoaCivil()
        {
           
        }

        //Criando construtor para futuras instâncias
        public PessoaCivil(string nome)
        {
            this.nome = nome;
            this.temDinheiro = true;
        }

        //Criando construtor para futuras instâncias
        public PessoaCivil(string nome, bool temDinheiro)
        {
            this.nome = nome;
            this.temDinheiro = temDinheiro;
        }

        //Função que atribuira o comportamento do objeto
        public void atribuirComportamento(IPodePassar novoComportamento)
        {
            if(temDinheiro == false)
            {
                this.comportamentoCatraca = new PassarNaoPassar();
            } else
            {
                this.comportamentoCatraca = novoComportamento;
            }
            
        }

        //Criando a função que dará a opção do usuário executar o comportamento
        public void executarComportamento()
        {
            comportamentoCatraca.podePassar();
        }

        //Função abstrata que apresentará as pessoas
        public abstract void apresentacaoPessoa();


    }
}
