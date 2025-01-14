using System;

public class tempo{
    static void Main(){
        Tempo();
    }
    static void Tempo(){
        Console.Clear();
        Console.WriteLine("Escreva o tempo em segundos");
        int segundos = int.Parse(Console.ReadLine());

        int Horas = segundos / 3600;
        int Minutos = (segundos % 3600) / 60;
        int Segundos = segundos % 60;

        Console.WriteLine("{0} Horas, {1} Minutos, {2} Segundos", Horas, Minutos, Segundos);
        Console.WriteLine("Deseja executar novamente (S/N)");
        string es = Console.ReadLine();
        if(es == "s"){
            Tempo();
        }else{
            System.Environment.Exit(0);
        }
    }
}