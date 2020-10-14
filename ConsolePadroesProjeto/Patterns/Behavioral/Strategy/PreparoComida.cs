using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePadroesProjeto.Patterns.Behavioral.Strategy
{
    abstract class PreparoComida
    {
        public abstract void PrepararComida(string comida);
    }

    class Cozinhar : PreparoComida
    {
        public override void PrepararComida(string comida)
        {
            Console.WriteLine("\nCozinhando " + comida);
        }
    }

    class Fritar : PreparoComida
    {
        public override void PrepararComida(string comida)
        {
            Console.WriteLine("\nFritando " + comida);
        }
    }

    class Assar : PreparoComida
    {
        public override void PrepararComida(string comida)
        {
            Console.WriteLine("\nAssando " + comida);
        }
    }


}
