using System;

namespace DigitalInnovationOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            // int numeroDeVezes = 5;
            // for (int i = 0; i < numeroDeVezes; i++)
            // {
            //     Console.WriteLine("Contador: "  + i);
            // }

            var s = new Pilha();
            s.Empilha(1);
            s.Empilha(10);
            s.Empilha(100);
            System.Console.WriteLine(s.Desempilha);
            System.Console.WriteLine(s.Desempilha);
            System.Console.WriteLine(s.Desempilha);
        }
    }
}
