using System;

namespace Bhaskara{
    public class bhaskara{

        static void Main(){

            Console.Clear();
            Console.WriteLine("Calculador Bhaskara Insira o valor de A");
            string a = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Calculador Bhaskara Insira o valor de B");
            string b = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Calculador Bhaskara Insira o valor de C");
            string c = Console.ReadLine();

            double A = double.Parse(a);
            double B = double.Parse(b);
            double C = double.Parse(c);
            double D = (B)*B - 4 * (A) * (C);

            if(D < 0){
                Console.WriteLine("Sem valor consistente da raiz");
            }else{
                double x1 = (-(B) + Math.Sqrt(D)) / (2 * A);
                double x2 = (-(B) - Math.Sqrt(D)) / (2 * A);
                
                Console.Clear();
                Console.WriteLine("O valor de X1 é: {0}", x1);
                Console.WriteLine("O valor de X2 é: {0}", x2); 
            }
        }
    }
}