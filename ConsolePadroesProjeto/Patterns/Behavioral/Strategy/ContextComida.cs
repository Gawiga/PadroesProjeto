using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePadroesProjeto.Patterns.Behavioral.Strategy
{
    class ContextComida
    {
        private string Comida;
        private PreparoComida _estrategiaPreparoComida;

        public void DefineEstrategiaDePreparo(PreparoComida estrategiaPreparoComida)
        {
            this._estrategiaPreparoComida = estrategiaPreparoComida;
        }

        public void DefineComida(string nome)
        {
            Comida = nome;
        }

        public void Cozinhar()
        {
            _estrategiaPreparoComida.PrepararComida(Comida);
            Console.WriteLine();
        }
    }
}
