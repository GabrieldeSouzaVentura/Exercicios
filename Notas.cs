using System;
public class notas{
    static void Main(){
        nota();
    }
    static void nota(){
        Console.Clear();
        Console.WriteLine("Qual a sua nota ?");
        int Aluno = int.Parse(Console.ReadLine());

        if(Aluno >= 6){
            Console.WriteLine("Aprovado");
        }else if(Aluno >= 4){
            Console.WriteLine("Recuperação");
        }else if(Aluno <= 3){
            Console.WriteLine("Reprovado");
        }
    }
}