using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePadroesProjeto.Patterns.Structural.Facade
{
    class SubSistema
    {
    }

    class PreparoFrio : SecaoCozinha
    {
        public Comida PrepararPrato(int pratoId)
        {
            return new Comida()
            {
                PratoId = pratoId
            };
        }
    }

    class PreparoQuente : SecaoCozinha
    {
        public Comida PrepararPrato(int pratoId)
        {
            return new Comida()
            {
                PratoId = pratoId
            };
        }
    }

}
