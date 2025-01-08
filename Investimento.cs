using System;

public class Investimento{
    static void Main(){
        Console.Clear();
        Console.WriteLine("Investimento Financeiro \nQual o valor que será investido?");
        int ValorIvestido = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Qual será a taxa de juros mensal (%) ?");
        int Juros = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Por quantos meses será o investimento?");
        int Meses = int.Parse(Console.ReadLine());

        Console.Clear();
        double Res = Calculo(ValorIvestido, Juros, Meses);
        Console.WriteLine("O valor investido mensalmente ({0}) em ({1}) mêses será de:{2}", ValorIvestido, Meses, Res.ToString("N2"));
        
        Console.WriteLine("Deseja processar novamente ? (S/N)");
        string Es = Console.ReadLine();
        if(Es == "s"){
            Main();
        }else{
            System.Environment.Exit(0);
        }
    }
    static double Calculo(int ValorIvestido, int Juros, int Meses){
        double VI = 0;

        for (int Mês = 1; Mês <= Meses; Mês++){
            VI += ValorIvestido;
            VI += (VI * Juros / 100);
        }
        return VI;
    } 
}
