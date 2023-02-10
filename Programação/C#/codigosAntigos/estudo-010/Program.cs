using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace estudo
{
    public class Program
    {

        static void Main(string[] args)
        {
            string[]palavras = { "eu", "vc", "ele", "ela"};
            
            for (int numero = 0; numero < 10; numero++)
			{
                Console.WriteLine(numero);
                Console.WriteLine("FOR RODANDO");
			}

            for(int numero = 0; numero < palavras.Length; numero++)
            {
                Console.WriteLine(numero);
                Console.WriteLine(palavras[numero]);


            }
            Console.WriteLine("_____________________________________");
            
            for(int contador = 3; contador >= 0;contador--)
            {
                Console.WriteLine(contador);
                Console.WriteLine(palavras[contador]);
            }

            Console.ReadLine();
        }
    }
}