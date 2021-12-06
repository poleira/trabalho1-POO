using System;
using System.Collections.Generic;

namespace Pasta_main{
class Conta{
        public int somaBebeuQnts;
        public float valorTotalMesa;
        public float quantidadeBebida;
        public float valorBebida;
         
        public List<Pessoa> lp = new List<Pessoa>();

        // Função que adiciona a Pessoa na Lista de Pessoas
        public void adicionarPessoa(Pessoa p)
        {
            lp.Add(p);
        }


}
}

