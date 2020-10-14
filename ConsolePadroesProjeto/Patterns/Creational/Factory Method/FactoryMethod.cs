using System;

namespace ConsolePadroesProjeto.Patterns.Creational.Factory_Method
{
    /* Product - Define a intefaces dos objetos que o Factory Method irá criar.
     * ConcreteProduct - Objetos que implementam a interface do Product
     * Creator - Declara o Factory Method, no qual retorna um objeto do tipo Product. O Creator também pode definir uma implementação padrão do Factory Method. 
     * ConcreteCreator - Objeto que sobreescreve o Factory Method para retornar uma instância do ConcreteProduct.
    */
    public static class FactoryMethod
    {
        public static void Executar()
        {
            var sanduicheDePeru = new SanduicheDePeru();

            foreach (var item in sanduicheDePeru.Ingredientes)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
