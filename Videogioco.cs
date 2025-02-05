using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioOOPGianluca
{
    public class Videogioco
    {
        // TODO: Aggiungi le proprietà appropriate per un videogioco
        // Suggerimento: Pensa a: titolo, genere, anno di pubblicazione, completato
        public string Titolo { get; set; }
        // Aggiungi qui le altre proprietà...

        // TODO: Correggi il costruttore - contiene un bug!
        public Videogioco(string titolo, string genere, int annoPubblicazione)
        {
            genere = genere;  // Bug: questo assegnamento non funziona correttamente
            Titolo = Titolo;  // Bug: questo assegnamento non funziona correttamente
                              // Completa il costruttore...
        }

        // TODO: Scegli l'implementazione corretta del metodo ToString()
        // OPZIONE 1:
        public override string ToString()
        {
            return Titolo;
        }

        // OPZIONE 2:
        /*
        public override string ToString()
        {
            return $"{Titolo} ({Genere}) - {AnnoPubblicazione}";
        }
        */
    }
}
