namespace Pasta_main
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando a Mesa
            MesaBar mesa1 = new MesaBar (10, 10);

            // Criando os bebuns
            Pessoa player1 = new Pessoa ("gustavo",10);
            Pessoa player2 = new Pessoa ("julio",7);
            Pessoa player3 = new Pessoa ("marco",10);
            Pessoa player4 = new Pessoa ("lucas",4);
            
            // Adicionando as Pessoas na Mesa
            mesa1.adicionarPessoa(player1);    
            mesa1.adicionarPessoa(player2);
            mesa1.adicionarPessoa(player3);
            mesa1.adicionarPessoa(player4);

            // Retornando quanto cada um deve pagar
            mesa1.contaMesa();  
        }
    }
}
