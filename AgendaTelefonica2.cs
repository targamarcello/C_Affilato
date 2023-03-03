using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxOpzione = 4, MaxNumeri = 3;
            int opzione, cont = 0;
            string[] nomi = new string[MaxNumeri];
            string nuovoNum;
            long[] numeriTelefonici = new long[MaxNumeri];
            long[] modifica = new long[MaxNumeri];
            bool numPresente = false;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("====Registro Telefonico====");
                    Console.WriteLine("[1] Inserimento: nome, cognome, numero telefonico");
                    Console.WriteLine("[2] Visualizza contatti telefonici");
                    Console.WriteLine("[3] Modifica numero di telefono");
                    Console.WriteLine("[4] Esci");
                    opzione = Convert.ToInt32(Console.ReadLine());
                } while (opzione < 1 || opzione > MaxOpzione);
                switch (opzione)
                {
                    case 1:
                        if (cont != 3)
                        {
                            Console.WriteLine("inserire nome del contatto");
                            nomi[cont] = Console.ReadLine();
                            Console.WriteLine("inserire numero telefonico");
                            numeriTelefonici[cont] = Convert.ToInt64(Console.ReadLine());
                            cont++;
                        }
                        else
                        {
                            Console.WriteLine("hai inserito il numero massimo di contatti");
                        }
                        numPresente = true;
                        Console.WriteLine("premi tasto");
                        Console.ReadLine();
                        break;
                    case 2:
                        for (int i = 0; i < MaxNumeri; i++)
                        {
                            Console.WriteLine($"il {i + 1}° contatto è: {nomi[i]} con numero {numeriTelefonici[i]}");

                        }
                        Console.WriteLine("premi tasto");
                        Console.ReadLine();
                        break;
                    case 3:
                        if (numPresente == true)
                        {
                            Console.WriteLine("inserire contatto da modificare");
                            nuovoNum = Console.ReadLine();
                            for(int i=0; i<MaxNumeri; i++)
                            {
                                if (nuovoNum == nomi[i])
                                {
                                    Console.WriteLine("inserisci nuovo nome per il contatto");
                                    nomi[i] = Console.ReadLine();
                                    Console.WriteLine("inserire nuovo numero per il contatto");
                                    numeriTelefonici[i] = Convert.ToInt64(Console.ReadLine());
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("nessuna modifica da eseguire");
                        }
                        Console.WriteLine("premi tasto");
                        Console.ReadLine();
                        break;
                }
            } while (opzione != MaxOpzione);

        }
    }
}
