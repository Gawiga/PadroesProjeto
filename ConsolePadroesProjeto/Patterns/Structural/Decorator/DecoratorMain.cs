using System;

namespace ConsolePadroesProjeto.Patterns.Structural.Decorator
{
    /* Based on https://exceptionnotfound.net/decorator-pattern-in-csharp/

    O padrão Decorator adiciona nova funcionalidades em um objeto existente sem alterar a definição do objeto. Em outras palavras, ele adiciona novas responsabilidades para uma instancia individual do objeto, sem adicionar essasresponsabilidades na classe dos objetos. É tipo uma alternativa à heranças
    
    Component
    Define a interface para os objetos que irão ter responsabilidades ou a habilidade de adiciona-los dinamicamente.
    
    ConcreteComponente
    Objetos que dizem quais responsabilidades serão adicionadas
    
    Decorator
    Mantem a referencia para um componentee define a interface que forma a interface do Component

    ConcreteDecorator
    Classes que realmente adicionam resposabilidades a clsses do ConcreteComponent
    */
    public static class DecoratorMain
    {
        public static void Executar()
        {
            //1º: Definir alguns pratos e quantos podemos fazer
            SaladaFresca caesarSalad = new SaladaFresca("Alface crocante", "Parmessao ralado", "Tempero da Casa");
            caesarSalad.Disponivel();

            Macarrao fettuccine = new Macarrao("Macarrão de Rico", "Molho de Rico");
            fettuccine.Disponivel();

            Console.WriteLine("\nDeixando esses pratos disponíveis...");

            //2º: Decorar os pratos; 
            //Se pedirmos pratos sem os ingredientes disponíveis, iremos notificar o cliente
            Disponibilidade disponibilidadeSalada = new Disponibilidade(caesarSalad, 2);
            Disponibilidade disponibilidadeMacarraco = new Disponibilidade(fettuccine, 1);

            disponibilidadeSalada.PedirItem("José");
            disponibilidadeSalada.PedirItem("Maria");
            disponibilidadeSalada.PedirItem("Alfredo"); //indisponível

            disponibilidadeMacarraco.PedirItem("Carlos");
            disponibilidadeMacarraco.PedirItem("Alberto"); //indisponivel
            disponibilidadeMacarraco.PedirItem("Nobrega"); //indisponivel

            disponibilidadeSalada.Disponivel();
            disponibilidadeMacarraco.Disponivel();

            Console.ReadKey();
        }
    }
}
