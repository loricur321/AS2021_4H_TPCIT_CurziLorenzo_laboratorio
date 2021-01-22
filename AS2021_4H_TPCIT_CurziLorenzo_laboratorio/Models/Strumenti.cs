using System;
using System.Collections.Generic;
using System.Text;

namespace AS2021_4H_TPCIT_CurziLorenzo_laboratorio.Models
{
    class Strumenti
    {
        //codice identificativo dello strumento 
        int _identificativo;
        
        //descrizione dello strumento
        string _descrizione;

        //prezzo di acquisto dello strumento
        double _costo;

        //anno in cui è stato effettuato l'acquisto dello strumento
        int _annoAcquisto;

        //anni di garanzia rimanenti dello strumenti (se il valore è 0 la garanzia è terminata)
        int _anniGaranzia;


        //propery di sola lettura di tutti gli attributi
        public int Identificativo { get => _identificativo; }

        public string Descrizione { get => _descrizione;}

        public double Costo { get => _costo; }

        public int AnnoAcquisto { get => _annoAcquisto; }

        public int AnniGaranzia { get => _anniGaranzia; }

        public Strumenti () { }

        //costruttore che verrà richiamato dalla classe Laboratorio
        public Strumenti(int id, string descrizione, double costo, int annoAcquisto, int anniGaranzia)
        {
            _identificativo = id;
            _descrizione = descrizione;
            _costo = costo;
            _annoAcquisto = annoAcquisto;
            _anniGaranzia = anniGaranzia;
        }

        public override string ToString()
        {
            return $"\n\nIdentificativo: \t\t{_identificativo}" +
                   $"\nDescrizione: \t\t\t{_descrizione}" +
                   $"\nCosto: \t\t\t\t{_costo}" +
                   $"\nAnno dell'acquisto: \t\t{_annoAcquisto}" +
                   $"\nAnni di garanzia rimanenti: \t{_anniGaranzia}";
        }

    }
}
