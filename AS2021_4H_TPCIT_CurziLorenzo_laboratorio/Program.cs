using System;
using AS2021_4H_TPCIT_CurziLorenzo_laboratorio.Models;

namespace AS2021_4H_TPCIT_CurziLorenzo_laboratorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programma gestione laboratorio di Lorenzo Curzi 4H, 22/01/2021");

            Laboratorio strumenti = new Laboratorio();

            //inserimento degli strumenti 
            strumenti.InserisciStrumento(1, "stampante", 300, 2015, 0);
            strumenti.InserisciStrumento(2, "computer", 600, 2018, 1);
            strumenti.InserisciStrumento(3, "tastiera", 20, 2010, 0);
            strumenti.InserisciStrumento(4, "mouse", 15, 2014, 0);
            strumenti.InserisciStrumento(5, "computer", 500, 2020, 2);
            strumenti.InserisciStrumento(6, "computer", 1000, 2021, 3);

            Console.WriteLine("\nRicerca tramite identificativo di uno strumento.");
            Console.WriteLine(strumenti.RicercaPerIdentificativo(2));

            Console.WriteLine("\nRicerca tramite descrizione di uno o più strumenti");
            Console.WriteLine(strumenti.RicercaPerdescrizione("computer"));

            Console.WriteLine("\nCalcolo del valore dei prodotti acquistati dal 2010 al 2021.");
            Console.WriteLine("Valore:" + strumenti.CalcoloValoreStrumenti(2010, 2021));

            Console.WriteLine("\nCalcolo del valore dei prodotti acquistati dal 2014 al 2018.");
            Console.WriteLine("Valore:" + strumenti.CalcoloValoreStrumenti(2014, 2018));

            Console.WriteLine("\nLista di tutti gli strumenti aventi ancora garanzia:");
            string tmp = strumenti.ListaStrumentiGaranzia();
            if (tmp != "")
                Console.WriteLine(tmp);
            else
                Console.WriteLine("Non vi è alcun strumento in garanzia.");

            Console.WriteLine("\nRimozione dell'elemento 4 dalla lista.");
            if (strumenti.EliminaStrumento(4))
                Console.WriteLine("Operazione riuscita.");
            else
                Console.WriteLine("Operazione non riuscita!");


            Console.WriteLine("\nStrumenti salvati in memoria:");
            Console.WriteLine(strumenti.ToString());

            Console.WriteLine("\nSalvataggio dei dati su un file di testo.");
            if(strumenti.SalvataggioDati())
                Console.WriteLine("Salvataggio riuscito.");
            else
                Console.WriteLine("Salvataggio non riuscito!");
        }
    }
}
