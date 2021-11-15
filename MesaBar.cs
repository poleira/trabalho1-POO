using System;
using System.Collections.Generic;

namespace Pasta_main
{
    class MesaBar
    {
        int somaBebeuQnts;
        float valorTotalMesa;
        float quantidadeBebida;
        float valorBebida;

        // Construtor MesaBar
        public MesaBar(float q, float v)
        {
            quantidadeBebida = q;
            valorBebida = v;
            valorTotalMesa = quantidadeBebida * valorBebida;
        }

        List<Pessoa> lp = new List<Pessoa>();

        // Função que adiciona a Pessoa na Lista de Pessoas
        public void adicionarPessoa(Pessoa p)
        {
            lp.Add(p);
        }

        // Função que calcula e retorna a proporção da quantidade bebida
        public int somarProporcao()
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
        public void contaMesa()
        {
            somarProporcao();
            foreach (Pessoa p in lp)
            {
                p.obterNome();
                p.obterBebeuQnts();
                double finaal = (valorTotalMesa / somarProporcao()) * p.obterBebeuQnts();
                Console.WriteLine("O cachaceiro {0} tem que pagar: " + finaal.ToString("F"), p.obterNome());
            }
        }
    }
}