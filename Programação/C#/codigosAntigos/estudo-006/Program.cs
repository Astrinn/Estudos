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
            string cor = "roxo";

            switch (cor)
            {
                case "Vermelho":
                    Console.WriteLine ("Sua cor favorita é vermelho");    
                    break;
                case "amarelo":
                    Console.WriteLine("Sua cor favorita é amarelo");
                    break;
                case "azul":
                    Console.WriteLine("Sua cor favorita é azul");
                    break;
                
                default: Console.WriteLine("Não identificamos uma cor válida");
                    break ;

            }
       
            Console.ReadLine();
        }
    }
}