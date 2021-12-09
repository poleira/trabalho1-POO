using System;
using System.Collections.Generic;
using System.IO;

namespace Pasta_main
{
    class ContaIgual : Conta
    {
        TextWriter sw = new StreamWriter("C:\\Test.txt", true);
        int somapessoas;
        public ContaIgual (float q, float v, string n)
        {
            quantidadeBebida = q;
            valorBebida = v;
            nomeBar= n;
            valorTotalMesa = quantidadeBebida * valorBebida;
            sw.WriteLine(nomeBar + valorBebida);
            sw.Close();
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