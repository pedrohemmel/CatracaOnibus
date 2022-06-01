using System;
using System.Collections.Generic;
using System.Text;

namespace CatracaOnibus
{
    class PassarNaoPassar : IPodePassar
    {
        public void podePassar()
        {
            Console.WriteLine("\nNão consegui passar pela catraca :(. Estou sem dinheiro.\n");
        }
    }
}
