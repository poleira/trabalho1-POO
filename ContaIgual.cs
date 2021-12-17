using System;
using System.Collections.Generic;
using System.IO;

namespace Pasta_main
{
    // Conta Igual tem a Herança da Classe Conta
    class ContaIgual : Conta
    {
        // Criando os Arquivos
        TextWriter sw = new StreamWriter("C:\\Bares.txt", true);
        TextWriter sq = new StreamWriter("C:\\Bebidas.txt", true);
        private int somapessoas;

        // Construtor
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
        
        // Função que soma a quantidade de pessoas que estão bebendo na mesa  
        public int somarPessoas()
        {
            foreach (Pessoa p in lp)
            {
                somapessoas++;
            }
            return somapessoas;
        }

        // Função que divide a conta igualmente e retorna o mesmo valor para cada usuário pagar
        public void contaIgualmente()
        {           
            double totaal = valorTotalMesa / somarPessoas();
            Console.WriteLine("Cada um terá que pagar: {0}", totaal);
            lp.Clear();
        }
    }
}