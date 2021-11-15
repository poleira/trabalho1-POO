using System;

namespace Pasta_main
{
    class Program
    {
        static void Main(string[] args)
        {
            MesaBar mesa1 = new MesaBar (10, 10);

            Player player1 = new Player ("gustavo",10);
            Player player2 = new Player ("julio",7);
            Player player3 = new Player ("marco",10);
            Player player4 = new Player ("lucas",4);
            
            
            mesa1.adicionarPlayer(player1);    
            mesa1.adicionarPlayer(player2);
            mesa1.adicionarPlayer(player3);
            mesa1.adicionarPlayer(player4);

            mesa1.contaMesa();
            
        }
    }
}
