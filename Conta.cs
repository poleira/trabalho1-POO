using System;
using System.Collections.Generic;

namespace Pasta_main{
class Conta{
        protected int somaBebeuQnts; //mudar public
        protected float valorTotalMesa;
        protected float quantidadeBebida;
        protected float valorBebida;
        protected string nomeBar;
         
        protected List<Pessoa> lp = new List<Pessoa>();

        // Função que adiciona a Pessoa na Lista de Pessoas
        public void adicionarPessoa(Pessoa p)
        {
            lp.Add(p);
        }


}
}

