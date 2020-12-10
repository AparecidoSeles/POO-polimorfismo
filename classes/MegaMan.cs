using System;

namespace POO_polimorfismo.classes
{
    public class MegaMan : Player
    {
        //ATRIBUTOS
        private string buster;

        public override string Correr(){
            return "correndo na velocidade 2x";
        }
    }
}