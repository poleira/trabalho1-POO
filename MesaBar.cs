using System;
using System.Collections.Generic;

namespace Pasta_main
{
    class MesaBar
    {

        float somaBebeuQnts;
        float valorTotalMesa;
        float quantidadeCerveja;
        float valorCerveja;

        public MesaBar(float q, float v){
        quantidadeCerveja = q;
        valorCerveja = v;
        valorTotalMesa = quantidadeCerveja * valorCerveja;
        }

        List<Player> lp = new List<Player>();

        public void adicionarPlayer(Player p){
        lp.Add(p);
   
        }

        public float somarproporcao() {
            somaBebeuQnts = 0;
            foreach (Player p in lp){
                p.getBebeuQnts();  
                somaBebeuQnts = somaBebeuQnts + p.getBebeuQnts();
            }
            return somaBebeuQnts;
        }
 
        public void contaMesa(){
            somarproporcao();
            foreach (Player p in lp){
                p.getNome();
                p.getBebeuQnts();    
                Console.WriteLine("O cachaceiro {0} tem que pagar: " + ( valorTotalMesa / somarproporcao()) * p.getBebeuQnts(), p.getNome());
            }
        
        }











    }
}   