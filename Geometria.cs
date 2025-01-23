using System;
namespace Formas_Geometricas{
    public class Geometria{
        static void Main(){
            Console.Clear();
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("1 - Quadrado");
            Console.WriteLine("2 - Triangulo");
            Console.WriteLine("3 - Retangulo");
            Console.WriteLine("4 - Trapezio");
            Console.WriteLine("5 - Sair");
            string escolha = Console.ReadLine();
            switch (escolha){
                case "1": Quadrado(); break;
                case "2": Triangulo(); break;
                case "3": Retangulo(); break;
                case "4": Trapezio(); break;
                case "5": Console.Clear(); System.Environment.Exit(0); break;
                default: Main(); break;
            }
        }
        static void Quadrado(){
            Console.Clear();
            Console.WriteLine("Qual o valor dos lados ?");
            double lados = double.Parse(Console.ReadLine());

            double resultado = lados * lados;
            Console.WriteLine("O Quadrado com lados: {0} tem a area de: {1}", lados, resultado.ToString("N2"));
            
            Console.WriteLine("Deseja continuar (S/N) ?");
            string continuar = Console.ReadLine();
            if(continuar == "s" || continuar == "S"){
                Main();
            }else{
                Console.Clear();
                System.Environment.Exit(0);
            }
        }
        static void Triangulo(){
            Console.Clear();
            Console.WriteLine("Qual o valor da altura ?");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor da base ?");
            double Base = double.Parse(Console.ReadLine());

            double resultado = (altura * Base) / 2;
            Console.WriteLine("O Triangulo com altura: {0} e Base: {1} tem a area de: {2}", altura, Base, resultado.ToString("N2"));
            
            Console.WriteLine("Deseja continuar (S/N) ?");
            string continuar = Console.ReadLine();
            if(continuar == "s" || continuar == "S"){
                Main();
            }else{
                Console.Clear();
                System.Environment.Exit(0);
            }
        }
        static void Retangulo(){
            Console.Clear();
            Console.WriteLine("Qual o valor da altura ?");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor da base ?");
            double Base = double.Parse(Console.ReadLine());

            double resultado = altura * Base;
            Console.WriteLine("O Retangulo com altura: {0} e Base: {1} tem a area de: {2}", altura, Base, resultado.ToString("N2"));
            
            Console.WriteLine("Deseja continuar (S/N) ?");
            string continuar = Console.ReadLine();
            if(continuar == "s" || continuar == "S"){
                Main();
            }else{
                Console.Clear();
                System.Environment.Exit(0);
            }
        }
        static void Trapezio(){
            Console.Clear();
            Console.WriteLine("Qual o valor da base maior ?");
            double BaseMaior = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor da base menor ?");
            double BaseMenor = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor da altura ?");
            double Altura = double.Parse(Console.ReadLine());

            double resultado = (((BaseMaior + BaseMenor) * Altura) / 2);
            Console.WriteLine("Trapezio com Base maior: {0}, Base Menor: {1} e Altura: {2} tem a area de: {3}", BaseMaior, BaseMenor, Altura, resultado.ToString("N2"));
            
            Console.WriteLine("Deseja continuar (S/N) ?");
            string continuar = Console.ReadLine();
            if(continuar == "s" || continuar == "S"){
                Main();
            }else{
                Console.Clear();
                System.Environment.Exit(0);
            }
        }
    }
}