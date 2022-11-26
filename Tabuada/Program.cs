using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada = "";
            int n = 0;

            Console.WriteLine("Programa Tabuada de um numero");
            Console.Write("Informe um numero: ");
            //Entrada de dados
            entrada = Console.ReadLine();
            n = Convert.ToInt32(entrada);
            //exibe a tabuada referente ao numero que o usuário inseriu
            Console.WriteLine("Tabuada do " + n);
            Console.WriteLine(n + " x 1 = " + (n * 1));
            Console.WriteLine(n + " x 2 = " + (n * 2));
            Console.WriteLine(n + " x 3 = " + (n * 3));
            Console.WriteLine(n + " x 4 = " + (n * 4));
            Console.WriteLine(n + " x 5 = " + (n * 5));
            //maneiras diferentes de calcular
            Console.WriteLine("{0} x 6 = {1}", n, (n * 6));
            Console.WriteLine("{0} x 7 = {1}", n, (n * 7));
            Console.WriteLine("{0} x 8 = {1}", n, (n * 8));
            Console.WriteLine("{0} x 9 = {1}", n, (n * 9));
            Console.WriteLine("{0} x 10 = {1}", n, (n * 10));

            Console.ReadKey();
        }
    }
}
