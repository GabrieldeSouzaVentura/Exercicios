using System;
public class romano{
    static void Main(){
        Console.Clear();
        Console.WriteLine("Tradutor para numeros romanos\nEscreva um numero de ate 3 digitos (1 a 999)");
        int numero = int.Parse(Console.ReadLine());
        if(numero < 1 || numero > 999){
            Main();  

        }else{
            int desenas = (numero % 100) / 10;
            int centenas = numero / 100;
            int unidades = numero % 10;
            Tradutor(centenas, desenas, unidades);

            string res = Tradutor(centenas, desenas, unidades);
            Console.WriteLine("O valor de {0} em romano é {1}", numero, res);
        }
    }
    static string Tradutor(int centenas, int desenas, int unidades){

        string[] Unidade = new string [10]{"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};
        string[] Desena = new string [10] {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"};
        string[] Centena = new string [10] {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"};

        string Traducao = Centena[centenas] + Desena[desenas] + Unidade[unidades];
        return Traducao;
    }
}