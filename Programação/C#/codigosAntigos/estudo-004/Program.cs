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
            Console.WriteLine("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());
            if (idade >= 0 && idade <= 11)
            {
                Console.WriteLine("Vc é uma criança");
            }
            else if (idade >=12 && idade <=17)
            {
                Console.WriteLine("Vc é um adolecente");    
            }
            else if (idade >=18 && idade <= 60)
            {
                Console.WriteLine("Vc é um adulto");
            }


            else
            {
                Console.WriteLine("Vc é um idoso");
            }




            Console.ReadLine();
        }
    }
}