using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Autores:
            // Walter Dalla Torre Neto 17254 e Joao Henrique 17...

            ConsoleKeyInfo b;
            do
            {

                b = Console.ReadKey();

                if (b.Key.GetHashCode() == 112)
                    Console.WriteLine("Ajuda do sistema!");

            } while ((b.Modifiers != ConsoleModifiers.Alt) || (b.KeyChar != 'x'));
        }
    }
}
