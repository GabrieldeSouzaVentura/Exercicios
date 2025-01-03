using System;
public class Introdução{
    static void Main(){
        Produto();
    }
    static void Produto(){

        string descrição = "O produto ({0}) de quantidade ({1}) de valor ({2}) deu ({3})";
   
        Console.Clear();
        Console.WriteLine("Qual o nome do produto ?");
        string nome = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Qual o valor do produto ?");
        string valor = Console.ReadLine();
        decimal Valor = decimal.Parse(valor);
    
        Console.Clear();
        Console.WriteLine("Qual a quantidade do produto ({0})", nome);
        string quantidade = Console.ReadLine();
        decimal Quantidade = decimal.Parse(quantidade);

        decimal total = Valor * Quantidade; 

        if(Quantidade >= 25){ 
            decimal vcinco = total - ((total / 100) * 25);
            Console.WriteLine(descrição + "com 25% de desconco", nome, Quantidade, Valor, vcinco);

        }else if(Quantidade >= 20){
            decimal vinte = total - ((total / 100) * 20);
            Console.WriteLine(descrição + "com 20% de desconco", nome, Quantidade, Valor, vinte);

        }else if (Quantidade > 10){
            decimal dez = total - ((total / 100) * 10);
            Console.WriteLine(descrição + "com 10% de desconco", nome, Quantidade, Valor, dez);

        }else if(Quantidade <= 10){
            Console.WriteLine(descrição, nome, Quantidade, Valor, total);
        }
    }
}
