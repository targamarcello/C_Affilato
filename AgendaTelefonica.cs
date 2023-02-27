using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxOpzione = 3, MaxNumeri = 3;
            int opzione, cont = 0;
            string[] nomi = new string[3];
            string[] numeriTelefonici = new string[3];
            do
            {
                do
                {
                    Console.WriteLine("====Registro Telefonico====");
                    Console.WriteLine("[1] Inserimento: nome, cognome, numero telefonico");
                    Console.WriteLine("[2] Visualizza contatti telefonici");
                    Console.WriteLine("[3] Esci");
                    opzione = Convert.ToInt32(Console.ReadLine());
                } while (opzione < 1 || opzione > MaxOpzione);
                switch (opzione)
                {
                    case 1:
                        if (cont != 3)
                        {
                            Console.WriteLine("Inserisci numero telefonico");
                            numeriTelefonici[cont] = Console.ReadLine();
                            Console.WriteLine("Inserisci nome del contatto");
                            nomi[cont] = Console.ReadLine();
                            cont++;
                        }
                        else
                        {
                            Console.WriteLine("hai inserito il numero massimo di contatti");
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        for(int i=0; i<MaxNumeri; i++)
                        {
                            Console.WriteLine($"il {i + 1}° contatto è: {nomi[i]} con numero {numeriTelefonici[i]}");
                        }
                        Console.ReadLine();
                        break;
                }
            } while (opzione != MaxOpzione);
        }
    }
}
