using System;
using System.Collections.Generic;

namespace Pasta_main
{
    class ContaIgual : Conta
    {
        int somapessoas;
        public ContaIgual (float q, float v)
        {
            quantidadeBebida = q;
            valorBebida = v;
            valorTotalMesa = quantidadeBebida * valorBebida;
        } 
        public int somarPessoas()
        {
            foreach (Pessoa p in lp)
            {
                somapessoas++;
            }
            Console.WriteLine(somapessoas);
            return somapessoas;
        }

        public void contaIgualmente()
        {           
            double totaal = valorTotalMesa / somarPessoas();
            Console.WriteLine("Todos terão que pagar: {0}", totaal);
            lp.Clear();
        }
    }
}