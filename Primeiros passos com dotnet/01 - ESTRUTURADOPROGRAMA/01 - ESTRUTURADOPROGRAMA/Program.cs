using _01___ESTRUTURADOPROGRAMA._01_Heranca;
using System;


namespace _01___ESTRUTURADOPROGRAMA
{
    class Program
    {
        static void Main(string[] args)
        {
            //var s = new Pilha();
            //s.Empilha(1);
            //s.Empilha(10);
            //s.Empilha(100);
            //Console.WriteLine(s.Desempilha());
            //Console.WriteLine(s.Desempilha());
            //Console.WriteLine(s.Desempilha());

            Instrucoes instrucoes = new Instrucoes();
            instrucoes.Declaracoes();            

            string[] a = new string[] { "1", "2" };
            string[] b = { "teste", "teste010", "teste0100"};
           

            instrucoes.InstrucaoIf(a);

            Ponto ponto = new Ponto(2,3);
            ponto.CalcularDistancia3();

            Ponto3D ponto2 = new Ponto3D(1,2,3);

            Ponto3D.Calcular();

            

            
        }
    }
}
