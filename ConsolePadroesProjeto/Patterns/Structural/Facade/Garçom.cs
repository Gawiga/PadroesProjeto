using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePadroesProjeto.Patterns.Structural.Facade
{
    class Garçom
    {
        private PreparoFrio _preparoFrio = new PreparoFrio();
        private PreparoQuente _preparoQuente = new PreparoQuente();

        public Pedido PrepararPedido(Patrao patrao, int comidaQuenteId, int comidaFriaId)
        {
            Console.WriteLine("{0}, realizando pedido para o prato frio", comidaFriaId.ToString());
            Console.WriteLine("{0}, realizando pedido para o prato quente", comidaQuenteId.ToString());

            Pedido pedido = new Pedido
            {
                Aperitivo = _preparoFrio.PrepararPrato(comidaFriaId),
                Entrada = _preparoQuente.PrepararPrato(comidaQuenteId)
            };

            return pedido;
        }
    }
}
