using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            /*
            int a;
            int b;

            a = 5;
            Console.WriteLine("Valor de a: {0}", ++a);
            Console.WriteLine("Valor de a: {0}", a);
            b = a++;
            Console.WriteLine("Valor de a: {0}", a);
            Console.WriteLine("Valor de b: {0}", b);
            */

            int qtde = 50;

            int i;
            int[] y;
            y = new int[qtde];

            Random r = new Random();
            
            for(i=0; i<qtde; i++)
            {
                //Console.Write("Digite o {0}º valor: ", i+1);
                //y[i] = int.Parse(Console.ReadLine());
                y[i] = r.Next(100);
            }

            for (i = 0; i < qtde; i++)
            {
                Console.WriteLine("{0}º valor: {1}", i+1, y[i]);
            }
            
        }
    }
}
