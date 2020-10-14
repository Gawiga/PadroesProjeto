using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePadroesProjeto.Patterns.Structural.Decorator
{
    /// <summary>
    /// The abstract Component class
    /// </summary>
    abstract class PratoRestaurante
    {
        public abstract void Disponivel();
    }

    /// <summary>
    /// A ConcreteComponent class
    /// </summary>
    class SaladaFresca : PratoRestaurante
    {
        private string _verdura;
        private string _queijo;
        private string _tempero;

        public SaladaFresca(string verdura, string queijo, string tempero)
        {
            _verdura = verdura;
            _queijo = queijo;
            _tempero = tempero;
        }

        public override void Disponivel()
        {
            Console.WriteLine("\nSalada fresca:");
            Console.WriteLine(" Verduras: {0}", _verdura);
            Console.WriteLine(" Queijo: {0}", _queijo);
            Console.WriteLine(" Tempero: {0}", _tempero);
        }
    }

    class Macarrao : PratoRestaurante
    {
        private string _tipoMacarrao;
        private string _molho;

        public Macarrao(string tipoMacarrao, string molho)
        {
            _tipoMacarrao = tipoMacarrao;
            _molho = molho;
        }

        public override void Disponivel()
        {
            Console.WriteLine("\nMacarrão clássico:");
            Console.WriteLine(" Tipo do Macarrão: {0}", _tipoMacarrao);
            Console.WriteLine(" Molho: {0}", _molho);
        }
    }
}
