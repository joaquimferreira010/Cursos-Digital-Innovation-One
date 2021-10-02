using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___ESTRUTURADOPROGRAMA._02_Metodos
{
    public class _02_Out
    {
        static void Dividir(int x, int y, out int resultado, out int resto)
        {
            resultado = x / y;
            resto = x % y;
        }

        public static void Dividir()
        {
            Dividir(10, 3, out int resultado, out int resto);
            Console.WriteLine("{0}{1}", resultado, resto);
        }
    }
}
