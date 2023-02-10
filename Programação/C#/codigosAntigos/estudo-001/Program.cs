using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using estudo.People;


namespace estudo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome?"); //aprendendo a guardar informações e aplica-las posteriormente
            var nome = Console.ReadLine();//valor
            Console.WriteLine("Qual seu time favorito?");
            var time = Console.ReadLine();//valor

            Console.WriteLine($"Seu nome é {nome}, e seu time preferido é o {time}.");//manipulando esses valores

            Classe1 person = new Classe1();//criação de novo objeto(person) adicionando valores as suas propriedades impostas pela sua classe primária
            person.nome = "Hiago";
            person.dataDeNascimento = 2004;
            person.age = 18;

            person.Greeting();//prescrevendo no código o comando Greeting e com os valores do objeto person


        }
    }
}