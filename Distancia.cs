using System;
class distancia{
    static void Main (){
        
        Console.Clear();
        Console.WriteLine ("Distancia de dois pontos com três dimenções");
        Console.WriteLine ("Ponto A");
        Console.WriteLine ("Insira o valor de X1");
        string x1 = Console.ReadLine(); double X1 = double.Parse(x1);
        Console.WriteLine ("Insira o valor de Y1");
        string y1 = Console.ReadLine(); double Y1 = double.Parse(y1);
        Console.WriteLine ("Insira o valor de Z1");
        string z1 = Console.ReadLine(); double Z1 = double.Parse(z1);
        
        Console.Clear();
        Console.WriteLine ("Ponto B");
        Console.WriteLine ("Insira o valor de X2");
        string x2 = Console.ReadLine(); double X2 = double.Parse(x2);
        Console.WriteLine ("Insira o valor de Y2");
        string y2 = Console.ReadLine(); double Y2 = double.Parse(y2);
        Console.WriteLine ("Insira o valor de Z2");
        string z2 = Console.ReadLine(); double Z2 = double.Parse(z2);

        double D = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 1) + Math.Pow(Z2 - Z1, 2));

        Console.WriteLine ("A distancia de A e B é: {0}", D.ToString("N2"));
    }
}