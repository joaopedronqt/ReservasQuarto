using System;
using System.Globalization;

namespace ReservaQuartos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Estudante[] vect = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine();
                Console.WriteLine($"Aluguel: #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                System.Console.Write("Email: ");
                string email = Console.ReadLine();
                System.Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);

            }

            System.Console.WriteLine();
            System.Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    System.Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}