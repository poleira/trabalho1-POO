namespace Pasta_main
{
    class Pessoa
    {
        private string nome; 
        private int bebeuQnts; 
        
        //construtor Pessoa
        public Pessoa(string n, int q)
        {
            nome = n;
            bebeuQnts = q; 
        }

        // Função para obter o nome da Pessoa
        public string obterNome(){
            return nome;
        }

        // Função para obter quantas Bebidas a Pessoa tomou
         public int obterBebeuQnts(){
            return bebeuQnts;
        }
    }
}
