using System;
using System.IO;
using System.Collections.Generic;

namespace Pasta_main{
public static class Banco{

    private static string line;
    private static double menor;
    private static int c;
    private static int posicao;
    private static string strr;
    
    // Cria um arquivo de lista de Bares, onde cada linha é um bar
    public static void listaBares()
    {    
    StreamReader sr = new StreamReader("C:\\Bares.txt");
    line = sr.ReadLine();
    
    while (line != null)
    {
        Console.WriteLine(line);
        line = sr.ReadLine();
    }
        sr.Close();
    }

    // Cria um arquivo de lista de Valores das Bebidas, onde cada linha é um preço
    public static void listaPrecoBares()
    {    
    StreamReader sr = new StreamReader("C:\\Bebidas.txt");
    line = sr.ReadLine();
    
    while (line != null)
    {
        Console.WriteLine(line);
        line = sr.ReadLine();
    }
        sr.Close();
    }

    // Função para obter a posição no arquivo de Bebida
    private static int getPosicao()
    {
        StreamReader sr = new StreamReader("C:\\Bebidas.txt");

        while (!sr.EndOfStream)
        {  
            string str = sr.ReadLine();
            
            if (menor >= double.Parse(str) || menor==0){ 
            menor = double.Parse(str);
            posicao = c;
            }

            c++;
        }
        
        sr.Close();
        return posicao;
    }
    
    // Função para obter o menor valor de Bebida
    private static double getMenorBreja()
    {
        StreamReader sr = new StreamReader("C:\\Bebidas.txt");

        while (!sr.EndOfStream)
        {
            string str = sr.ReadLine();
            
            if (menor >= double.Parse(str) || menor==0){ 
            menor = double.Parse(str);
            }
        }
        
        sr.Close();
        return menor;
    }

    // Função que retorna ao Usuário o Bar que tem a Bebida mais Barata
    public static void BarMaisBarato()
    {
        StreamReader sr = new StreamReader("C:\\Bares.txt");
        int testee = getPosicao();

        for (int i = 0; i <= testee; i++){
            strr = sr.ReadLine();
        }

        Console.WriteLine("O bar mais barato da região é o: {0}, com o preço da breja: {1} R$", strr, getMenorBreja());
        strr = "-";
        sr.Close();
    }
    
    












}
}

