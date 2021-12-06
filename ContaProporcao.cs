using System;
using System.Collections.Generic;

namespace Pasta_main
{
    class ContaProporcao : Conta
    {
        public ContaProporcao (float q, float v)
        {
            quantidadeBebida = q;
            valorBebida = v;
            valorTotalMesa = quantidadeBebida * valorBebida;
        } 
        
        // Função que calcula e retorna a proporção da quantidade bebida
        private int somarProporcao()
        {
            somaBebeuQnts = 0;
            foreach (Pessoa p in lp)
            {
                p.obterBebeuQnts();
                somaBebeuQnts = somaBebeuQnts + p.obterBebeuQnts();
            }
            return somaBebeuQnts;
        }

        // Função que retorna a quantidade que cada Pessoa deve Pagar
        public void contaProporcional()
        {
            foreach (Pessoa p in lp)
            {
                double finaal = (valorTotalMesa / somarProporcao()) * p.obterBebeuQnts();
                Console.WriteLine("O cachaceiro {0} tem que pagar: " + finaal.ToString("F"), p.obterNome());
            }
        }
    }
}