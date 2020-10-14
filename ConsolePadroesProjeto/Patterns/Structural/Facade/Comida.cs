using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePadroesProjeto.Patterns.Structural.Facade
{
    class Comida
    {
        public int PratoId;
    }

    interface SecaoCozinha
    {
        Comida PrepararPrato(int pratoId);
    }

    class Pedido
    {
        public Comida Aperitivo { get; set; }
        public Comida Entrada { get; set; }
        //public Comida Bebida { get; set; }
    }
}
