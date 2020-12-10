using System;

namespace POO_polimorfismo.classes
{
    public class Player
    {
        private float velocidade;
        private float forcaPaulo;

        public virtual string Correr(){
            return "Correndo na velocidade 1x";
        }
    }
}