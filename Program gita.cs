using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GitaIstruzione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opzione, nAlunno = 0, adesioni = 0;
            string[] nomeAlunni = new string[3];
            string ricerca, adesioneGita="";
            string[] gita = new string[3];
            string[] elencoGita = new string[3];
            const int maxOpzione = 6, nAlunni = 3;
            //visualizzazione menù
            do
            {
                do
                {
                    Console.WriteLine("===Registro di classe===");
                    Console.WriteLine("[1] Inserimento");
                    Console.WriteLine("[2] Ricerca");
                    Console.WriteLine("[3] Ricerca posizione alunni nel registro");
                    Console.WriteLine("[4] Organizzazione gita");
                    Console.WriteLine("[5] Stampa elenco gita");
                    Console.WriteLine("[6] Esci");
                    opzione = Convert.ToInt32(Console.ReadLine());
                } while (opzione < 1 || opzione > maxOpzione);
                switch (opzione)
                {
                    case 1:
                        if (nAlunni != nAlunno)
                        {
                            Console.WriteLine("inserisci il nome del bimbo");
                            nomeAlunni[nAlunno] = Console.ReadLine();
                            nAlunno++;
                        }
                        break;
                    case 6:
                        //verifica che la classe sia al completo
                        if (nAlunno != 0)
                        {
                            //stampa dei presenti
                            for (int i = 0; i < nAlunni; i++)
                            {
                                Console.WriteLine(nomeAlunni[i]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Non hai insertito tutti i bambini");
                        }
                        break;
                    //ricerca
                    case 2:
                        if (nAlunno != 0)
                        {
                            Console.WriteLine("Inserire il nome del bambino da cercare");
                            ricerca = Console.ReadLine();
                            // ricerca del nome nell'array
                            bool trovato = false;
                            for (int i = 0; i < nAlunno && !trovato; i++)
                            {
                                if (ricerca == nomeAlunni[i])
                                {
                                    trovato = true;
                                }
                                trovato = ricerca == nomeAlunni[i];
                            }
                            if (trovato)
                            {
                                Console.WriteLine($"il bimbo {ricerca} è stato trovato");
                            }
                            else
                            {
                                Console.WriteLine($"il bimbo {ricerca} non è stato trovato");
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("inserisci nome di chi vuoi sapere la posizione");
                        ricerca = Console.ReadLine();
                        for (int i = 0; i < nAlunno; i++)
                        {
                            if (ricerca == nomeAlunni[i])
                            {
                                Console.WriteLine($"la posizione del bimbo che hai inserito è {i + 1}");
                            }
                        }
                        break;
                    case 4:
                        if (nAlunno != 0)
                        {
                            for(int i=0; i<nAlunno; i++)
                            {
                                Console.WriteLine($"il bambino {nomeAlunni[i] } aderisce alla gita?");
                                adesioneGita = Console.ReadLine().ToLower();
                                while(adesioneGita!= "si" && adesioneGita != "no")
                                {
                                    Console.WriteLine("la risposta data non è valida, puoi rispondere solo SI o NO");
                                    adesioneGita = Console.ReadLine().ToUpper();
                                }
                                if (adesioneGita == "si")
                                {
                                    gita[i] = nomeAlunni[i];
                                    adesioni++;
                                    elencoGita[i] = $"il bimbo {nomeAlunni[i]} viene in gita";
                                }
                                else if(adesioneGita== "no")
                                {
                                    elencoGita[i] = $"il bimbo {nomeAlunni[i]} sta a casa";
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("non ha inserito nessun nome, stavolta inserisci un nome");
                            Console.ReadLine();
                        }
                        break;
                    case 5:
                        for (int i = 0; i < nAlunno; i++)
                        {
                            Console.WriteLine(elencoGita[i]);
                        }
                        break;
                }
            } while (opzione != maxOpzione);
            Console.WriteLine("Fine ciclo");
            Console.ReadLine();
        }
    }
}
/* Chiede ad ogni bambino se viene in gita: se la risposta è "si" il bambino viene in gita, altrimenti non viene in gita.
 * Stampa l'elenco di chi viene in gita.
 * La maestra ha la necessità che l'elenco venga  mantenuto fino alla prossima visita d'istruzione. */

