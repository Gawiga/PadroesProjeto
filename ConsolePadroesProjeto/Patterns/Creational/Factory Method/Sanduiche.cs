using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePadroesProjeto.Patterns.Creational.Factory_Method
{
    abstract class Sanduiche
    {
        public Sanduiche()
        {
            CriarIngredientes();
        }

        public abstract void CriarIngredientes();

        public List<Ingredientes> Ingredientes { get; } = new List<Ingredientes>();
    }

    class SanduicheDePeru : Sanduiche
    {
        public override void CriarIngredientes()
        {
            Ingredientes.Add(new Pao());
            Ingredientes.Add(new Alface());
            Ingredientes.Add(new Peru());
            Ingredientes.Add(new Maionese());
            Ingredientes.Add(new Alface());
            Ingredientes.Add(new Peru());

        }
    }
}
