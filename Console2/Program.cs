using Libreria2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci un numero");
            int n1;
            try
            {
                double n = double.Parse(Console.ReadLine());
                if(Utilità.VerificaIntero(n))
                {
                    Console.WriteLine($"il numero {n} è intero");
                    n1 = (int)n;
                }
                else
                {
                    Console.WriteLine($"il numero {n} non è intero");
                     n1 = Utilità.Arrotonda(n);
                }
                if (Utilità.Pari_Dispari(n1))
                {
                    Console.WriteLine($"il numero {n1} è pari");
                }
                else
                {
                    Console.WriteLine($"il numero {n1} è dispari");
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("inserisci solo numeri: "+ e.Message);
            }
           
            Console.ReadLine();
        }
    }
}
