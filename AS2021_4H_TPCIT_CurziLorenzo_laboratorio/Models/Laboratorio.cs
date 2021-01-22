using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AS2021_4H_TPCIT_CurziLorenzo_laboratorio.Models
{
    class Laboratorio
    {
        List<Strumenti> _strumenti = new List<Strumenti>();

        //Inserimento di un nuovo strumento alla lista 
        public void InserisciStrumento(int id, string descrizione, double costo, int annoAcquisto, int anniGaranzia)
        {
            _strumenti.Add(new Strumenti(id, descrizione, costo, annoAcquisto, anniGaranzia));
        }

        //Ricerca di uno strumento dato il suo codcie identificativo
        public string RicercaPerIdentificativo(int id)
        {
            string retVal = "Strumento non trovato.";

            foreach (var s in _strumenti)
                if (s.Identificativo == id)
                    retVal = s.ToString();

            return retVal;
        }

        //Ricerca di uno o più strumenti data la loro descrizione
        public string RicercaPerdescrizione(string descrizione)
        {
            string retVal = "";

            foreach (var s in _strumenti)
                if (s.Descrizione == descrizione)
                    retVal += s.ToString();


            return retVal;
        }

        //metodo che consente di sommare tutti i costi dei prodotti dato un determinato arco di tempo
        public double CalcoloValoreStrumenti(int annoInizio, int annoFine)
        {
            double valore = 0;

            foreach (var s in _strumenti)
                if ((s.AnnoAcquisto >= annoInizio) && (s.AnnoAcquisto <= annoFine)) //controllo che la data di acquisto del prodotto sia compresa nell'arco temporale ricevuto
                    valore += s.Costo;

            return valore;
        }

        //lista di tutti gli strumenti che dispongono ancora di un periodo in garanzia
        //uno strumento per venire considerato in garanzia deve avere un valore > 0
        public string ListaStrumentiGaranzia()
        {
            string retVal = "";

            foreach (var s in _strumenti)
                if (s.AnniGaranzia > 0)
                    retVal += s.ToString();

            return retVal;
        }

        //metodo che rimuove dalla lista _strumenti un elemento dato il suo codice identificativo
        //restituisce un booleano che afferma la riuscita o meno dell'operazione
        public bool EliminaStrumento(int id)
        {
            bool riuscita;
            int j = 0;

            for (int i = 0; i < _strumenti.Count; i++)
                if (_strumenti[i].Identificativo == id)
                    j = i; //mi salvo la posizione dell'elemento da eliminare

            try
            {
                _strumenti.RemoveAt(j); //e lo rimuovo dalla lista
                riuscita = true;
            }
            catch
            {
                riuscita = false;
            }

            return riuscita;
        }


        //Salvataggio dei dati su file
        public bool SalvataggioDati()
        {
            string salvataggio = $"\n\nSalvataggio {DateTime.Now}";

            foreach (var s in _strumenti)
            {
                salvataggio += $"\n{s.ToString()}";
            }

            try
            {
                File.AppendAllText("Salvataggio.txt", salvataggio);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //ovverride del metodo ToString() in modo da poter visualizzare nel main la lista completa degli strumenti
        public override string ToString()
        {
            string retVal = "";

            foreach (var s in _strumenti)
                retVal += s.ToString();

            return retVal;
        }

    }
}
