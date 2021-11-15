using System;

namespace Pasta_main
{
    class Player
    {
        private string nome; 
        private float bebeuQnts; 
        
        //construtor player
        public Player(string n,float q)
        {
            nome = n;
            bebeuQnts = q; 
        }

        public string getNome(){
            return nome;
        }
         public float getBebeuQnts(){
            return bebeuQnts;
        }
}
}
