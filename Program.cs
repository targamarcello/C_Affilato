using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaestraInGita
{
    class Program
    {
        static void Main(string[] args)
        {
            int bambini;
            string nome;
            int contaBambini=0;
            //inserimento bambini
            Console.WriteLine("quanti bambini ci sono in classe");
            bambini = Convert.ToInt32(Console.ReadLine());
            string[] classe = new string[bambini];
            for (int i = 0; i < bambini; i++)
            {
                Console.WriteLine("inserisci il nome del bambino");
                classe[i] = Console.ReadLine();
            }
            //visualizzazione registro di classe
            for (int i = 0; i < bambini; i++)
            {
                Console.WriteLine($"la posizione {i+1} del bambino è { classe[i]}");
            }
            do
            {
                Console.WriteLine("inserisci nome bambino");
                nome = Console.ReadLine();
                for(int i=0; i<bambini; i++)
                {
                    if (classe[i] == nome)
                    {
                        Console.WriteLine("il bamibno è salito nel bus");
                        contaBambini++;
                    }
                }
                if (contaBambini == bambini)
                {
                    Console.WriteLine("tutti i bambini sono saliti sul bus");
                }
                else
                {
                    Console.WriteLine("mancano dei bambini");
                }
            } while (contaBambini < bambini);
            Console.ReadLine();
        }
    }
}
