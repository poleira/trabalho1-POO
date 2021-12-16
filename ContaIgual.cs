using System;
using System.Collections.Generic;
using System.IO;

namespace Pasta_main
{
    class ContaIgual : Conta
    {
        TextWriter sw = new StreamWriter("C:\\Test.txt", true);
        TextWriter sq = new StreamWriter("C:\\Test2.txt", true);
        private int somapessoas;
        public ContaIgual (float q, float v, string n)
        {
            quantidadeBebida = q;
            valorBebida = v;
            nomeBar = n;
            valorTotalMesa = quantidadeBebida * valorBebida;
            sw.WriteLine(nomeBar);
            sq.WriteLine(valorBebida);
            sw.Close();
            sq.Close();
        } 
        public int somarPessoas()
        {
            foreach (Pessoa p in lp)
            {
                somapessoas++;
            }
            return somapessoas;
        }

        public void contaIgualmente()
        {           
            double totaal = valorTotalMesa / somarPessoas();
            Console.WriteLine("Cada um terá que pagar: {0}", totaal);
            lp.Clear();
        }
    }
}