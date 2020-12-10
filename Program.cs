using System;
using POO_polimorfismo.classes;

namespace POO_polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMan jogador = new MegaMan();
            jogador.Correr();

            Zero jogador2 = new Zero();
            jogador2.Correr();


            Console.WriteLine($"jogador 1 {jogador.Correr()}");
            Console.WriteLine($"jogador 2 {jogador2.Correr()}");
        }
    }
}
