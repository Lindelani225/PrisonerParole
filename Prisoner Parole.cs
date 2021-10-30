using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3545
{
    class Program
    {
        static void Main(string[] args)
        {
            string prison = "",name ="",role = "",d = "";
            int prisoner = 0, x = 0;

            Console.Write("Enter name of a Prison\t:");
            prison = Console.ReadLine();
            Console.Write("Enter number of Prisoner aplied for parole \t:");
            prisoner = int.Parse(Console.ReadLine());

            for (int k = 0 , sentenced = 0 , served =0 ; k < prisoner; k++)
            {
                Console.Write("Enter name of personer \t:");
                name = Console.ReadLine();
                Console.Write("Enter role of prisoner in jail\t:");
                role = Console.ReadLine();

                Console.Write("Enter number of years sentenced \t :");
                
                sentenced = int.Parse(Console.ReadLine());
                Console.Write("Enter number of years served \t\t:");
                served = int.Parse(Console.ReadLine());
                Console.Write("Enter your satifaction as"+" \"YES\""+" or "+"\"NO\""+" with regards to role played by prisoner:");
                d = Console.ReadLine();

                if (d == "YES")
                {   
                    x = served/ sentenced * 100;
                    if (x >= 60)
                    {
                        Console.Write("The parole is granted");
                    }
                    else
                    {
                        Console.WriteLine("The parole not granted");
                    }
                };
                 if(d == "NO")
                {
                    Console.Write("The parole not granted");
                }
//Console.WriteLine("The);
                 Console.ReadLine();
            }
        }
    }
}
