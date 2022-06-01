using System;

namespace CatracaOnibus
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instanciando classes
            PessoaCivilNormal pedro = new PessoaCivilNormal("Pedro Hemmel", false);
            Idoso josefilda = new Idoso("Josefilda da Silva");
            Crianca brunao = new Crianca("Bruno Estevam");
            Estudante nikolas = new Estudante("Nikolas Alvez", false);
            Estudante maiara = new Estudante("Maiara Silva", true);
            Deficiente jaime = new Deficiente("Jaime Torresmo");

            string explicacao = "Olá professor, tudo bem? Por favor corrija nossa prova com carinho °u°\n\nA ideia foi simular como é a logística de passar pela catraca de um ônibus, por que isso varia muito dependendo da pessoa...Bom espero que goste!";

            for(int i = 0; i < explicacao.Length; i++)
            {
                System.Threading.Thread.Sleep(10);
                Console.Write(explicacao[i]);
            }

            System.Threading.Thread.Sleep(2000);

            Console.WriteLine();

            Console.WriteLine("\n------------------------------------------\n");
            Console.WriteLine("------------------------------------------\n");

            //Chamei a função para o Pedro atribuindo PassarCMeia, mas como Pedro não tem dinheiro, seá atribuido PassarNaoPassar
            pedro.atribuirComportamento(new PassarCMeia());

            System.Threading.Thread.Sleep(1000);

            pedro.apresentacaoPessoa();
             
            Console.WriteLine();

            System.Threading.Thread.Sleep(6000);

            pedro.executarComportamento();

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("\n------------------------------------------\n");
            Console.WriteLine("------------------------------------------\n");

            josefilda.atribuirComportamento(new PassarDGraca());

            System.Threading.Thread.Sleep(1000);

            josefilda.apresentacaoPessoa();

            Console.WriteLine();

            System.Threading.Thread.Sleep(6000);

            josefilda.executarComportamento();

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("\n------------------------------------------\n");
            Console.WriteLine("------------------------------------------\n");

            brunao.atribuirComportamento(new PassarDGraca());

            System.Threading.Thread.Sleep(1000);

            brunao.apresentacaoPessoa();

            Console.WriteLine();

            System.Threading.Thread.Sleep(6000);

            brunao.executarComportamento();

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("\n------------------------------------------\n");
            Console.WriteLine("------------------------------------------\n");

            //Chamei a função para o Pedro atribuindo PassarCMeia, mas como Pedro não tem dinheiro, seá atribuido PassarNaoPassar
            nikolas.atribuirComportamento(new PassarDGraca());

            System.Threading.Thread.Sleep(1000);

            nikolas.apresentacaoPessoa();

            Console.WriteLine();

            System.Threading.Thread.Sleep(6000);

            nikolas.executarComportamento();

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("\n------------------------------------------\n");
            Console.WriteLine("------------------------------------------\n");

            maiara.atribuirComportamento(new PassarCMeia());

            System.Threading.Thread.Sleep(1000);

            maiara.apresentacaoPessoa();

            Console.WriteLine();

            System.Threading.Thread.Sleep(6000);

            maiara.executarComportamento();

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("\n------------------------------------------\n");
            Console.WriteLine("------------------------------------------\n");

            jaime.atribuirComportamento(new PassarDGraca());

            System.Threading.Thread.Sleep(1000);

            jaime.apresentacaoPessoa();

            Console.WriteLine();

            System.Threading.Thread.Sleep(6000);

            jaime.executarComportamento();

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("\n------------------------------------------\n");
            Console.WriteLine("------------------------------------------\n");

        }
    }
}
