using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePadroesProjeto.Patterns.Structural.Facade
{
    /* Subsistemas - São quaisquer classes ou objetos que implementam funcionalidade mas podem ser "envoltos" por uma fachada (Facade) para simplificar a interface
     * Facade - É a camada de abstração acima dos subsistemas, e sabe para qual subsistema delegar o trabalho correto
    */
    public static class Facade
    {
        public static void Executar()
        {
            Garçom garçom = new Garçom();

            Console.WriteLine("Olá, serei seu garçom hoje, qual o seu nome?");
            var nome = Console.ReadLine();

            Patrao patrao = new Patrao(nome);

            Console.WriteLine("Olá " + patrao.Nome + ". Qual sera seu aperitivo hoje? (1-15):");
            var comidaFriaId = int.Parse(Console.ReadLine());

            Console.WriteLine("Muito bem. Qual será a entrada? (1-20):");
            var comidaQuenteId = int.Parse(Console.ReadLine());

            Console.WriteLine("Certo, já vou pedir para preparem já!");

            garçom.PrepararPedido(patrao, comidaQuenteId, comidaFriaId); 
            
            Console.ReadKey();
        }
    }
}
