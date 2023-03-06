using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequenzaCaratteri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tasto, contCifre = 0, contCaratteri = 0;
            int[] cont = new int[26];
            Console.WriteLine("Inserisci frase, tutta maiuscola");
            
            do
            {
                tasto = Convert.ToInt32(Console.Read());
                if (tasto>=65 && tasto <= 90)
                {
                    for(int i=0; i<cont.Length; i++)
                    {
                        if (tasto == 65 + i)
                        {
                            cont[i]++;
                        }
                    }
                }else if(tasto>=48 && tasto <= 57)
                {
                    contCifre++;
                }
                else
                {
                    contCaratteri++;
                }
            } while (tasto != 13);
            for(int i=0; i < cont.Length; i++)
            {
                if (cont[i] != 0)
                {
                    Console.WriteLine($"la lettera {Convert.ToChar(65 + i)} appare {cont[i]} volte");
                }
            }
            Console.WriteLine($"il carattere appare {contCaratteri} volte");
            Console.WriteLine($"la cifra appare {contCifre} volte");
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
