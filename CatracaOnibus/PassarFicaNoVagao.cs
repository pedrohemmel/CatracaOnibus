using System;
using System.Collections.Generic;
using System.Text;

namespace CatracaOnibus
{
    class PassarFicaNoVagao : IPodePassar
    {
        public void podePassar()
        {
            Console.WriteLine("\nPoderia passar pela catraca, mas decidi ficar no vagão da frente.\n");
        }
    }
}
