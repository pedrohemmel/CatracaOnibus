using System;
using System.Collections.Generic;
using System.Text;

namespace CatracaOnibus
{
    class PassarDGraca : IPodePassar
    {
        public void podePassar()
        {
            Console.WriteLine("\nConsegui passar pela catraca! Passei gratuitamente.\n");
        }
    }
}
