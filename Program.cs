using System;
using System.IO;

namespace Pasta_main
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // Criando a Conta
            ContaIgual conta1 = new ContaIgual (10, 9, "buana");

            // Criando os bebuns
            Pessoa player1 = new Pessoa ("gustavo",10);
            Pessoa player2 = new Pessoa ("julio",7);
            Pessoa player3 = new Pessoa ("marco",10);
            Pessoa player4 = new Pessoa ("lucas",4);
            
            // Adicionando as Pessoas na Conta
            conta1.adicionarPessoa(player1);    
            conta1.adicionarPessoa(player2);
            conta1.adicionarPessoa(player3);
            conta1.adicionarPessoa(player4);

            // Retornando quanto cada um deve pagar
            conta1.contaIgualmente(); 
            
            //----------------------------------------------------------

            // Criando a Conta2
            ContaProporcao conta2 = new ContaProporcao (10, 10, "Hebe");

            // Criando os bebuns
            Pessoa player5 = new Pessoa ("gustavo",10);
            Pessoa player6 = new Pessoa ("julio",7);
            Pessoa player7 = new Pessoa ("marco",10);
            Pessoa player8 = new Pessoa ("lucas",7);
            
            // Adicionando as Pessoas na Conta
            conta2.adicionarPessoa(player5);    
            conta2.adicionarPessoa(player6);
            conta2.adicionarPessoa(player7);
            conta2.adicionarPessoa(player8);

            // Retornando quanto cada um deve pagar
            conta2.contaProporcional();

            // Brincando com arquivos.
            
            Banco.BarMaisBarato();
            
            
            
    
            
        }
    }
}
