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
    
    public static void listaBares()
    {    
    StreamReader sr = new StreamReader("C:\\Test.txt");
    line = sr.ReadLine();
    
    while (line != null)
    {
        Console.WriteLine(line);
        line = sr.ReadLine();
    }
        sr.Close();
    }

    public static void listaPrecoBares()
    {    
    StreamReader sr = new StreamReader("C:\\Test2.txt");
    line = sr.ReadLine();
    
    while (line != null)
    {
        Console.WriteLine(line);
        line = sr.ReadLine();
    }
        sr.Close();
    }

    private static int getPosicao()
    {
        StreamReader sr = new StreamReader("C:\\Test2.txt");

        while (!sr.EndOfStream)
        {  
            string str = sr.ReadLine();
            
            if (menor >= double.Parse(str) || menor==0){ 
            menor = double.Parse(str);
            posicao = c;
            }

            c++;
        }
        
        return posicao;
        sr.Close();
    }
    

    private static double getMenorBreja()
    {
        StreamReader sr = new StreamReader("C:\\Test2.txt");

        while (!sr.EndOfStream)
        {
            string str = sr.ReadLine();
            
            if (menor >= double.Parse(str) || menor==0){ 
            menor = double.Parse(str);
            }
        }
        
        return menor;
        sr.Close();
    }

    public static void BarMaisBarato()
    {
        StreamReader sr = new StreamReader("C:\\Test.txt");
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

