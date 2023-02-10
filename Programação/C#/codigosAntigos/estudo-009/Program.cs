using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace estudo
{
    public class Program
    {
        enum Opcao { Criar = 1, Deletar = 2, Editar = 3, Listar = 4, Atualizar = 5 };

        static void Main(string[] args)
        {
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());
            Opcao OpcaoSelecionada = (Opcao)index;

            switch (OpcaoSelecionada){
                case (Opcao.Criar): {
                    Console.WriteLine("Vc quer criar algo!!");
                }
                    break;

                case (Opcao.Deletar):{ 
                      Console.WriteLine("all deleted");
                }
                    break;
                case (Opcao.Editar):{ 
                     Console.WriteLine("Oq vc quer editar?");
                }          
                    break;
                 default:
                    Console.WriteLine("Opção inválida");
                    break;            
           }
            
            string editado = Console.ReadLine();
            Console.WriteLine( editado + " foi editado com sucesso");

       
            Console.ReadLine();
        }
    }
}