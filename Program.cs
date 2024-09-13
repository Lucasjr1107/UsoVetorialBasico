using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetores_nome_e_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solicite um numero de pessoas: ");
            int quantidade = int.Parse(Console.ReadLine());

            string[] nomes = new string[quantidade];
            int[] idades = new int[quantidade];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Escreva um nome: ");
                nomes[i] = Console.ReadLine();

                Console.Write("Solicite uma idade: ");
                idades[i] = int.Parse(Console.ReadLine());  
            } 
             for (int i = 0; i < quantidade; i++)
             {
                Console.WriteLine($"{nomes[i]} tem {idades[i]} anos");
             }
          

        }
    }
}
