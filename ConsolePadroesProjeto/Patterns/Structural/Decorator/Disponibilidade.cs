using ConsolePadroesProjeto.Patterns.Structural.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePadroesProjeto.Patterns.Structural.Decorator
{
    /// <summary>
    /// A ConcreteDecorator. This class will impart "responsibilities" onto the dishes 
    /// (e.g. whether or not those dishes have enough ingredients left to order them)
    /// </summary>
    class Disponibilidade : Decorator
    {
        public int NumeroDisponivel { get; set; } //quantos pratos podemos fazer
        protected List<string> clientes = new List<string>();

        public Disponibilidade(PratoRestaurante prato, int numeroDisponivel) : base(prato)
        {
            NumeroDisponivel = numeroDisponivel;
        }

        public void PedirItem(string nome)
        {
            if(NumeroDisponivel > 0)
            {
                clientes.Add(nome);
                NumeroDisponivel--;
            }
            else
            {
                Console.WriteLine("\nNão há ingredientes suficientes para o pedido do cliente " + nome);
            }
        }

        public override void Disponivel()
        {
            base.Disponivel();

            foreach (var cliente in clientes)
            {
                Console.WriteLine("Pedido por " + cliente);

            }
        }
    }
}
