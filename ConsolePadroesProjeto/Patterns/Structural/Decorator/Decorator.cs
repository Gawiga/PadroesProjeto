using ConsolePadroesProjeto.Patterns.Structural.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePadroesProjeto.Patterns.Structural.Decorator
{
    abstract class Decorator : PratoRestaurante
    {
        protected PratoRestaurante _prato;

        public Decorator(PratoRestaurante prato)
        {
            _prato = prato;
        }

        public override void Disponivel()
        {
            _prato.Disponivel();
        }
    }
}
