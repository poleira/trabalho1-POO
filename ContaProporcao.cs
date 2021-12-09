using System;
using System.Collections.Generic;
using System.IO;

namespace Pasta_main
{
    class ContaProporcao : Conta
    {
        TextWriter sw = new StreamWriter("C:\\Test.txt", true);
        public ContaProporcao (float q, float v, string n)
        {
            quantidadeBebida = q;
            valorBebida = v;
            nomeBar= n;
            valorTotalMesa = quantidadeBebida * valorBebida;
            sw.WriteLine(nomeBar + valorBebida);
            sw.Close();
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