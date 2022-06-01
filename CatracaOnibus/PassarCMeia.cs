using System;
using System.Collections.Generic;
using System.Text;

namespace CatracaOnibus
{
    class PassarCMeia : IPodePassar
    {
        public void podePassar()
        {
            Console.WriteLine("\nConsegui passar pela catraca! Passei pagando meia entrada.\n");
        }
    }
}
