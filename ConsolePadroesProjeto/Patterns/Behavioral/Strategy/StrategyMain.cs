using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePadroesProjeto.Patterns.Behavioral.Strategy
{
    /* Based on https://exceptionnotfound.net/strategy-pattern-in-csharp/
    A ideia básica desse padrão é encapsular comportamentos como objetos. Nós podemos selecionar qual objeto usar e, portanto, qual comportamento implamentar baseado em inputs ou estados externos. Evitando if/else gigantes.
    
    Strategy
    Declara uma interface que é implementada por todos os algoritmos suportados

    ConcreteStrategy
    Objetos que implementam o algoritmo definido pelo Strategy

    Context
    Mantem uma referencia do objeto Strategy, e usa a referencia para chamar os objetos do ConcreteStrategy
    */
    public static class StrategyMain
    {
        public static void Executar()
        {
            ContextComida contexto = new ContextComida();

            Console.WriteLine("Qual a comida você vai preparar?");
            var comida = Console.ReadLine();
            contexto.DefineComida(comida);

            Console.WriteLine("Qual estratégia de preparo você gostaria de usar?" +
                "\n1 - Cozinhar" +
                "\n2 - Fritar" +
                "\n3 - Assar");
            int tipoPreparo = int.Parse(Console.ReadKey().KeyChar.ToString());

            switch (tipoPreparo)
            {
                case 1:
                    contexto.DefineEstrategiaDePreparo(new Cozinhar());
                    contexto.Cozinhar();
                    break;
                case 2:
                    contexto.DefineEstrategiaDePreparo(new Fritar());
                    contexto.Cozinhar();
                    break;
                case 3:
                    contexto.DefineEstrategiaDePreparo(new Assar());
                    contexto.Cozinhar();
                    break;
                default:
                    Console.WriteLine("Seleção invalida");
                    break;
            }

        }
    }
}
