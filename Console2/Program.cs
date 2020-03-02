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
            try
            {
                double n = double.Parse(Console.ReadLine());
                int n1 = (int)n;
                if (n == 1)
                {
                    Console.WriteLine($"il numero {n} è intero");
                    if(n % 2 == 0)
                    {
                        Console.WriteLine($"il numero{n} è pari");
                    }
                    else
                    {
                        Console.WriteLine($"il numero{n} è dispari");
                    }
                }
                else
                {
                    Console.WriteLine($"il numero {n} non è intero");

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
